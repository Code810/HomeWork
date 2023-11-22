using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Domain.Models
{
    public class Student
    {
        private static int _id;
        public string  FullName { get; set; }
        public int Point { get; set; }
        public int Id 
        {
            get
            {
                return _id;
            }
        }
        public Student()
        {
            _id++;
        }
        public void StudentInfo()
        {
            Console.WriteLine($"{Id} {FullName} {Point}");
        }
    }
}
