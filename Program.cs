using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tabel
{
    class Program
    {
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOPSAYA\\Asus;database=ProdiTI;Integrated Security=true");
                con.Open();
                SqlCommand cm = new SqlCommand("create table Mahasiswa_Coba(NIM char(12)not null primary key,Nama varchar(50),Alamat varchar(255),Jenis_Kelamin(1))", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Tabel berhasil dibuat");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal" + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
        static void Main(string[]args)
        {
            new Program().CreateTable();
        }
    }
}
