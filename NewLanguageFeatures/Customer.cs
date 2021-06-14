using System;
using System.Collections.Generic;
using System.Text;

namespace NewLanguageFeatures
{
    class Customer
    {
        public string Name { get; set; }
        public string City { get; set; }
        public int CustomerId { get;private set; }
        public override string ToString()
        {
            return Name + "\t" + City;
        }
        public Customer(int Id)
        {
            CustomerId = Id;
        }

    }
}
