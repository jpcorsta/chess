using System.Configuration;
using System.Data.SqlClient;

void btnBulkCopy_Click(object sender, EventArgs e)
{
    String ShajarConString;
    String NorthWindConString;
    SqlConnection ShajarCon 

    SqlCommand ShajarCom = new SqlCommand();
    SqlDataReader ShajarReader;

    ShajarConString = ConfigurationManager.ConnectionStrings["DSN_Shajar"].ConnectionString;

    NorthWindConString = ConfigurationManager.ConnectionStrings[""].ConnectionString;
        
}