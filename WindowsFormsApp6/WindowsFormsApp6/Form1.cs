using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;


namespace TerrainGeneratorTutorial0._1
{
    public partial class Form1 : Form
    {
        private Device device = null;
        private VertexBuffer vb = null;
        private IndexBuffer ib = null;

        private static int terWidth = 30;
        private static int terLength = 30;
        private float moveSpeed = 0.2f;
        private float turnSpeed = 0.05f;
        private float rotY = 0;

        private float rotXZ = 0;
        private float tempXZ = 0;

        private static int vertCount = terWidth * terLength; //amount of vertices
        private static int indCount = (terWidth - 1) * (terLength - 1) * 6; //amount of indices

        private Vector3 camPosition, camLookAt, camUp;

        CustomVertex.PositionColored[] verts = null; //our veertices here can only store position and color information

        private static int[] indices = null;

        private FillMode fillMode = FillMode.WireFrame;

        public Form1()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.Opaque, true);
            InitializeComponent();

            InitializeGraphics();
            InitializeEventHandler();
        }

        private void InitializeGraphics()
        {
            PresentParameters pp = new PresentParameters();
            pp.Windowed = true;
            pp.SwapEffect = SwapEffect.Discard;
            pp.EnableAutoDepthStencil = true;
            pp.AutoDepthStencilFormat = DepthFormat.D16;

            device = new Device(0, DeviceType.Hardware, this, CreateFlags.HardwareVertexProcessing, pp);

            GenerateVertex();
            GenerateIndex();

            vb = new VertexBuffer(typeof(CustomVertex.PositionColored), vertCount, device, Usage.Dynamic | Usage.WriteOnly, CustomVertex.PositionColored.Format, Pool.Default);
            OnVertexBufferCreate(vb, null);

            ib = new IndexBuffer(typeof(int), indCount, device, Usage.WriteOnly, Pool.Default);//indexbuffer
            OnIndexBufferCreate(ib, null);

            //initial camera position
            camPosition = new Vector3(2, 4.5f, -3.5f);//2= x axis, 4.5 is heigth off the camera
            camUp = new Vector3(0, 1, 0);//where the top of the camera is
        }
        private void InitializeEventHandler()
        {
            vb.Created += new EventHandler(OnVertexBufferCreate);
            ib.Created += new EventHandler(OnIndexBufferCreate);

            this.KeyDown += new KeyEventHandler(OnKeyDown);
            this.MouseWheel += new MouseEventHandler(OnMouseScroll);
        }

            this.MouseMove += new MouseEventHandler(OnMouseMove);
            this.MouseDown += new MouseEventHandler(OnMouseDown);
            this.MouseUp += new MouseEventHandler(OnMouseUp);

    }

    private void OnIndexBufferCreate(object sender, EventArgs e)
    {
        IndexBuffer buffer = (IndexBuffer)sender;

        buffer.SetData(indices, 0, LockFlags.None);
    }
    private void OnVertexBufferCreate(object sender, EventArgs e)
    {
        VertexBuffer buffer = (VertexBuffer)sender;
        buffer.SetData(verts, 0, LockFlags.None);
    }
    private void SetupCamera()
    {
        camLookAt.X = (float)Math.Sin(rotY) + camPosition.X;
        camLookAt.Y = camPosition.Y - 1;
        camLookAt.Z = (float)Math.Cos(rotY) + camPosition.Z;


        device.Transform.Projection = Matrix.PerspectiveFovLH((float)Math.PI / 4, this.Width / this.Height, 1.0f, 100.0f);
        device.Transform.View = Matrix.LookAtLH(camPosition, camLookAt, camUp);

        device.RenderState.Lighting = false;
        device.RenderState.CullMode = Cull.CounterClockwise;
        device.RenderState.FillMode = fillMode;
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
        device.Clear(ClearFlags.Target | ClearFlags.ZBuffer, Color.Black, 1, 0);

        SetupCamera();

        device.BeginScene();

        device.VertexFormat = CustomVertex.PositionColored.Format;
        device.SetStreamSource(0, vb, 0);
        device.Indices = ib;

        device.DrawIndexedPrimitives(PrimitiveType.TriangleList, 0, 0, vertCount, 0, indCount / 3);

        device.EndScene();
        device.Present();

        menuStrip1.Update();//when program starts and tools (items, buttons, etc) are not shown: menuStrip1.Update(); makes them appear instantly
        button1.Update();//when program starts and tools (items, buttons, etc) are not shown: button1.Update(); makes them appear instantly


        this.Invalidate();//refreshes itself constantly, endless loop
    }
    private void GenerateVertex()
    {
        verts = new CustomVertex.PositionColored[vertCount];

        int k = 0;

        for (int z = 0; z < terWidth; z++)
        {
            for (int x = 0; x < terLength; x++)//ter = terrain
            {
                verts[k].Position = new Vector3(x, 0, z);//0 = for there is no heigth in the terrain yet.
                verts[k].Color = Color.White.ToArgb();
                k++;
            }
        }
    }
    private void GenerateIndex()
    {
        indices = new int[indCount];

        int k = 0;
        int l = 0;

        for (int i = 0; i < indCount; i += 6)//to count it up
        {
            indices[i] = k;
            indices[i + 1] = k + terLength; // left triangle of the square
            indices[i + 2] = k + terLength + 1;

            indices[i + 3] = k;
            indices[i + 4] = k + terLength + 1; // right triangle of the square
            indices[i + 5] = k + 1;
            k++;
            l++;
            if (l == terLength - 1)//once one line of rectangles is created and the end of the line is beeing reached skip one k
            {
                l = 0;//in the next line we start al over again, set the l back to zero
                k++;
            }
        }
    }
    private void OnKeyDown(object sender, KeyEventArgs e)
    {
        switch (e.KeyCode)
        {
            case (Keys.W):
                {
                    camPosition.X += moveSpeed * (float)Math.Sin(rotY);
                    camPosition.Z += moveSpeed * (float)Math.Cos(rotY);
                    break;
                }
            case (Keys.S):
                {
                    camPosition.X -= moveSpeed * (float)Math.Sin(rotY);
                    camPosition.Z -= moveSpeed * (float)Math.Cos(rotY);
                    break;
                }
            case (Keys.D):
                {
                    camPosition.X += moveSpeed * (float)Math.Sin(rotY + Math.PI / 2);//PI/2=90degree
                    camPosition.Z += moveSpeed * (float)Math.Cos(rotY + Math.PI / 2);//PI/2=90degree
                    break;
                }
            case (Keys.A):
                {
                    camPosition.X -= moveSpeed * (float)Math.Sin(rotY + Math.PI / 2);
                    camPosition.Z -= moveSpeed * (float)Math.Cos(rotY + Math.PI / 2);
                    break;
                }
            case (Keys.Q):
                {
                    rotY -= turnSpeed;
                    break;
                }
            case (Keys.E):
                {
                    rotY += turnSpeed;
                    break;
                }
        }
    }
    private void OnMouseScroll(object sender, MouseEventArgs e)
    {
        camPosition.Y += e.Delta * 0.001f;
    }
}
}
