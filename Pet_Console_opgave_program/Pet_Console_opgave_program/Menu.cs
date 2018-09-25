using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pet_Console_opgave_program
{
    class Menu
    {
        private string connectionString = "Server=EALSQL1.eal.local; Database=DB2017_A18; User id=USER_A18; Password=SesamLukOp_18;";
        public void Show()
        {
            Console.WriteLine("Menu\n");
            Console.WriteLine("1) Insert Pet \n");

            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1": InsertPet(); break;

                default :  Show(); break;
            }
        }
        
        public void InsertPet()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("spInsertPet", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    Console.WriteLine("yo skriv det navn på dit dyr");
                    cmd.Parameters.Add(new SqlParameter("@PetName", Console.ReadLine()));
                    Console.WriteLine("yo skriv hvilket dyr du har");
                    cmd.Parameters.Add(new SqlParameter("@PetType", Console.ReadLine()));
                    Console.WriteLine("yo skriv den rase på det dyr");
                    cmd.Parameters.Add(new SqlParameter("@PetBreed", Console.ReadLine()));
                    Console.WriteLine("yo skriv den fødselsdag på det dyr YYYY-MM-DD");
                    cmd.Parameters.Add(new SqlParameter("@PetDOB", Console.ReadLine()));
                    Console.WriteLine("yo skriv den vægt på det dyr");
                    cmd.Parameters.Add(new SqlParameter("@PetWeight", Console.ReadLine()));
                    Console.WriteLine("yo spasser skriv id'et på ejeren");
                    cmd.Parameters.Add(new SqlParameter("@OwnerID", Console.ReadLine()));


                    cmd.ExecuteNonQuery();
                }
                catch(SqlException e)
                {
                    Console.WriteLine("UPS " + e.Message);
                }
                {

                }

            }
        }
    }
}
