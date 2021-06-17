using System;
using System.Collections.Generic;
using System.Text;

namespace WpfDay03
{
  public class Employee
    {
        public int Id { get; set; }
        public String Fname { get; set; }
        public String  LastName { get; set; }
        public override string ToString()
        {
            return $" Id ={Id} ";
        }
    }
}
