using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.DAL.Models
{
    public class Worker
    {
        public int Id { get; set; }
        public string WorkeLastName { get; set; }
        public string WorkerFirstName { get; set; }
        public string WorkerPhoneNumber { get; set; }
        public string WorkerEmail { get; set; }
        public string WorkerPassword { get; set; }
        public Worker(int id, string workeLastName, string workerFirstName, string workerPhoneNumber, string workerEmail, string workerPassword)
        {
            this.Id = id;
            this.WorkeLastName = workeLastName;
            this.WorkerFirstName = workerFirstName;
            this.WorkerPhoneNumber = workerPhoneNumber;
            this.WorkerEmail = workerEmail;
            this.WorkerPassword = workerPassword;
        }
        public Worker(string workeLastName, string workerFirstName, string workerPhoneNumber, string workerEmail, string workerPassword)
        {
            this.WorkeLastName = workeLastName;
            this.WorkerFirstName = workerFirstName;
            this.WorkerPhoneNumber = workerPhoneNumber;
            this.WorkerEmail = workerEmail;
            this.WorkerPassword = workerPassword;
        }
        public Worker() { }
        public override string ToString()
        {
            return "WorkerId: " + this.Id +
                "\n" + "\t" + "WorkeLastName: " + this.WorkeLastName +
                "\n" + "\t" + "WorkerFirstName: " + this.WorkerFirstName +
                "\n" + "\t" + "WorkerPhoneNumber: " + this.WorkerPhoneNumber +
                "\n" + "\t" + "WorkerEmail: " + this.WorkerEmail +
                "\n" + "\t" + "WorkerPassword: " + this.WorkerPassword;
        }
    }
}
