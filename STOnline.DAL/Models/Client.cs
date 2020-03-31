using STOnline.DAL.Interfaces.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.DAL.Models
{
    public class Client : IEntity<int>
    {
        public int Id { get; set; }
        public string ClientLastName { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientPhoneNumber { get; set; }
        public string ClientEmail { get; set; }
        public string ClientPassword { get; set; }

        public Client(int id, string clientLastName, string clientFirstName, string clientPhoneNumber, string clientEmail, string clientPassword)
        {
            this.Id = id;
            this.ClientLastName = clientLastName;
            this.ClientFirstName = clientFirstName;
            this.ClientPhoneNumber = clientPhoneNumber;
            this.ClientEmail = clientEmail;
            this.ClientPassword = clientPassword;
        }
        public Client(string clientLastName, string clientFirstName, string clientPhoneNumber, string clientEmail, string clientPassword)
        {
            this.ClientLastName = clientLastName;
            this.ClientFirstName = clientFirstName;
            this.ClientPhoneNumber = clientPhoneNumber;
            this.ClientEmail = clientEmail;
            this.ClientPassword = clientPassword;
        }
        public Client() { }

        public override string ToString()
        {
            return "ClientId: " + this.Id +
                "\n" + "\t" + "ClientLastName: " + this.ClientLastName +
                "\n" + "\t" + "ClientFirstName: " + this.ClientFirstName +
                "\n" + "\t" + "ClientPhoneNumber: " + this.ClientPhoneNumber +
                "\n" + "\t" + "ClientClientEmail: " + this.ClientEmail +
                "\n" + "\t" + "ClientPassword: " + this.ClientPassword;
        }
    }
}
