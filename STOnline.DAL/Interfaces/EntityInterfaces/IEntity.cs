using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.DAL.Interfaces.EntityInterfaces
{
    public interface IEntity
    {
        int Id { get; set; }
        string ToString();
    }
}
    