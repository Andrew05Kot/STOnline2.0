using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.DAL.Interfaces.EntityInterfaces
{
    public interface IEntity
    {
        Guid Id { get; set; }
        string ToString();
    }
}
    