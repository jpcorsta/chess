namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            Voertuig voertuig = new Voertuig();
            Bus bus = new Bus();
            Auto auto = new Auto();

            Console.ReadLine();
        }
    }
    class Voertuig
    {
        public bool VierWieler = true;
        public string merk;
        public string model;
    }
    class Bus:Voertuig
    {
        public int AantalRijenZitplaatsen;
        public bool KanVanBinnenStaan;
    }
    class Auto : Voertuig
    {
        public bool VierZitter;
    }
}