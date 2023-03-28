﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day36ThredingConcept
{
    internal class AddressBookRepo
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AddressBook;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);


        public void GetAddressBook()
        {
            try
            {
                AddressBookModel addressBookModel = new AddressBookModel();
                using (this.connection)
                {

                    string query = @"select id, first_name, last_name, address, city, state, zip, phone, email, name, contact_type from addressBook";
                    SqlCommand cmd = new SqlCommand(query, this.connection);
                    this.connection.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            addressBookModel.id = dr.GetInt32(0);
                            addressBookModel.first_name = dr.GetString(1);
                            addressBookModel.last_name = dr.GetString(2);
                            addressBookModel.address = dr.GetString(3);
                            addressBookModel.city = dr.GetString(4);
                            addressBookModel.state = dr.GetString(5);
                            addressBookModel.zip = dr.GetString(6);
                            addressBookModel.phone = dr.GetString(7);
                            addressBookModel.email = dr.GetString(8);
                            addressBookModel.name = dr.GetString(9);
                            addressBookModel.contact_type = dr.GetString(10);

                            Console.WriteLine(" {0} {1} ", addressBookModel.id, addressBookModel.first_name);

                        }
                    }
                    else
                    {
                        Console.WriteLine("Data not found!");
                    }
                    dr.Close();
                    this.connection.Close();




                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }



    }
}
