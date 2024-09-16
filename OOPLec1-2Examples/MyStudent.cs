using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLec1_2Examples
{
    public class MyStudent
    {
       // int[] arr;
        public MyStudent()
        { }

        public MyStudent(int a)
        {
            //arr = new int[a];
        }

        ~MyStudent()
        { }

        public string name;
        private int course;

        public void CourseChange()
        {
           
          
            course++;
        }
        public int GetCourse()
        {
            return course;
        }
    }
}
