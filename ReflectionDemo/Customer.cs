using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    internal class Customer
    {
        public int a, b;
        public int Id { get; set; }
        public string Name { get; set; }
        public Customer()
        {
            Id = 2;
            Name = "Vali";
        }
        public Customer(int id)
        {
            Id = id;
        }
        public void Print()
        {

        }
        public void Test(int a)
        {

        }
    }
}
