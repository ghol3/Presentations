using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace PresentationClient
{
    class Connection
    {
        protected MySqlConnection connect;

        public Connection()
        {
            string connectstring = "server=localhost;database=presentationclient;uid=root;pwd=";
            this.connect = new MySqlConnection(connectstring);
            connect.Open();
        }

        protected void registerUser(string nickname, string name, string lastname, int age, string password)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO Users(nickname, name, lastname, age, password) VALUES(" + nickname + ","+ name +"," + lastname +"," + age + ","+ password+")");
            
        }
    }
}
