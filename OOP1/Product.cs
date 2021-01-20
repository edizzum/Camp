using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        //CRUD:(Create Read Update Delete)
        //snippet
        public int ID { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}
