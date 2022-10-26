using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Tam.LeNgocTai.entity
{
    interface IEntity
    {
        string name { get; set; }
        int id { get; set; }
    }
    public class BaseEntity : IEntity
    {
        public string name { get; set; }
        public int id { get; set; }
    }
}
