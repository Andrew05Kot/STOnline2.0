using Newtonsoft.Json;
using STOnline.DAL.Interfaces.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace STOnline.DAL.Models
{
    public class Worker : BaseEntity
    {
        [Required]
        public string WorkeLastName { get; set; }
        [Required]
        public string WorkerFirstName { get; set; }
        [Required]
        public string WorkerPhoneNumber { get; set; }
        [Required]
        public string WorkerEmail { get; set; }
        [Required]
        public string WorkerPassword { get; set; }
        [JsonIgnore]
        public Guid WorkerCategory { get; set; }
        //public Worker(int id, string workeLastName, string workerFirstName, string workerPhoneNumber, string workerEmail, string workerPassword)
        //{
        //    this.Id = id;
        //    this.WorkeLastName = workeLastName;
        //    this.WorkerFirstName = workerFirstName;
        //    this.WorkerPhoneNumber = workerPhoneNumber;
        //    this.WorkerEmail = workerEmail;
        //    this.WorkerPassword = workerPassword;
        //}
        //public Worker(string workeLastName, string workerFirstName, string workerPhoneNumber, string workerEmail, string workerPassword)
        //{
        //    this.WorkeLastName = workeLastName;
        //    this.WorkerFirstName = workerFirstName;
        //    this.WorkerPhoneNumber = workerPhoneNumber;
        //    this.WorkerEmail = workerEmail;
        //    this.WorkerPassword = workerPassword;
        //}
        //public Worker() { }
        //public override string ToString()
        //{
        //    return "WorkerId: " + this.Id +
        //        "\n" + "\t" + "WorkeLastName: " + this.WorkeLastName +
        //        "\n" + "\t" + "WorkerFirstName: " + this.WorkerFirstName +
        //        "\n" + "\t" + "WorkerPhoneNumber: " + this.WorkerPhoneNumber +
        //        "\n" + "\t" + "WorkerEmail: " + this.WorkerEmail +
        //        "\n" + "\t" + "WorkerPassword: " + this.WorkerPassword;
        //}
    }
}
