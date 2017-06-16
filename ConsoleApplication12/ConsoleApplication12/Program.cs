using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ConsoleApplication12
{
    class Specialiaz
    {
        public int SpecId{ get; set; }
        public string Title{ get; set; }
        public string Doctor { get; set; }
    }
    class Event
    {
        public string NameP{ get; set; }
        public string NameD { get; set; }
    }
    

    class Program
    {
        static void Main(string[] args)
        {

            List<Specialiaz> listSpec = new List<Specialiaz>();
            List<Event> ev = new List<Event>();

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                connection.Open();

                Console.WriteLine($"{nameof(connection.ClientConnectionId)}: {connection.ClientConnectionId}");
                Console.WriteLine($"{nameof(connection.ConnectionString)}: {connection.ConnectionString}");
                Console.WriteLine($"{nameof(connection.ClientConnectionId)}: {connection.ClientConnectionId}");
                Console.WriteLine($"{nameof(connection.ClientConnectionId)}: {connection.ClientConnectionId}");

                var sqlPatient = "SELECT * FROM Patient";
                var adapter = new SqlDataAdapter(sqlPatient, connection);
                var dataSet = new DataSet();

                adapter.Fill(dataSet);

                var datatable = dataSet.Tables[0];

                var newRow = datatable.NewRow();
                newRow["Id"] = 6;
                newRow["Name"] = "Pipa";
                newRow["Age"] = 42;

                

                foreach (var row in datatable.Rows)
                {
                    Console.WriteLine(row);
                }

                //string title = "Nurse";

                //using (var command = connection.CreateCommand())
                //{
                //    command.CommandText = @"SELECT p.Id , p.Name AS PatientName, d.Name AS DoctorName FROM Patient p
                //                            LEFT JOIN PatientDoctor pd ON pd.PatientId = p.Id 
                //                            LEFT JOIN Doctor d ON pd.DoctorId = d.Id
                //                            WHERE [Title] = @Title";
                //    var titleSqlParam = new SqlParameter("Title", title);
                //    command.Parameters.Add(titleSqlParam);

                //    using (var reader = command.ExecuteReader())
                //    {
                //        while (reader.Read())
                //        {
                //            ev.Add(new Event
                //            {
                //                NameD = (string)reader["DoctorName"],
                //                NameP = (string)reader["PatientName"],
                               
                //            });
                        }
                    }
                }
            }
           
 