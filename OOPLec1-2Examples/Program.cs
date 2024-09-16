using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLec1_2Examples
{
    enum myEnum { green, blue }

    class Student
    {

        public string nsame;
        string lName;
        int age;
        int course;
        public int Index { get; }
        public string FName { get; private set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public int Course { get; set; }

        public Student()
        { }
        public void UpdateStudent(Student student)
        { }

        public void UpdateName(string lname, string fname)
        { }

        public void UpdateAge()
        {
            Age++;
        }
    }

    public class Sqr
    {
        int side;
        public bool b;

        public int Side
        {
            get { return side; }
            set
            {
                if (value > 0)
                    side = value;
            }
        }
        public double Side1 { get; set; }


        public Sqr()
        {
            side = 1;
        }

        public Sqr(int side)
        {
            this.side = side;
        }


        public Sqr(int parside, Boolean f)
        {
            if (f == true)
                side = parside;
            else
                side = parside * 2;
        }

        public Sqr(Sqr obj)
        {
            side = obj.side;
        }

        public int P()
        {
            return side * 4;

        }

        public int S()
        {
            return side * side;
        }

        public int Get()
        {
            return side;
        }

        public void Set(int parside)
        {
            if (parside > 0)
            {
                side = parside;
            }
        }

        public static Sqr operator +(Sqr s1, Sqr s2)
        {
            Sqr s3 = new Sqr();
            s3.side = s1.side + s2.side;
            return s3;
        }

        public static Sqr operator +(Sqr s1, int i2)
        {
            Sqr s3 = new Sqr();
            s3.side = s1.side + i2;
            return s3;
        }

        public static Sqr operator +(int i1, Sqr s2)
        {
            Sqr s3 = new Sqr();
            s3.side = i1 + s2.side;
            return s3;
        }

        public static bool operator >(Sqr s1, Sqr s2)
        {
            if (s1.side > s2.side)
                return true;
            else
                return false;
        }

        public static bool operator <(Sqr s1, Sqr s2)
        {
            if (s1.side < s2.side)
                return true;
            else
                return false;
        }

        public static bool operator !(Sqr s2)
        {
            if (0 < s2.side)
                return true;
            else
                return false;
        }

        public static bool operator true(Sqr s2)
        {
            if (0 == s2.side)
                return true;
            else
                return false;
        }

        public static bool operator false(Sqr s2)
        {
            if (0 != s2.side)
                return true;
            else
                return false;
        }

        public static Sqr operator ++(Sqr s)
        {
            s.side++;
            return s;
        }
    }

    class Student1
    {
       public string str;
       public int course;

    }

    //class Head
    //{ }
    //interface IStudy
    //{
    //    void Study();
    //}
    class St
    {
        
        //delegate void MyDelegate();
        //event MyDelegate someEvent;
        //IStudy study;
        //Head head;
        public string name;
        //public string GetName()
        //{ return name; }
        //public void SetName(string name)
        //{ this.name = name; }

        public int course;
        protected int averageMark;

        //public St()
        //{ }
        //~St()
        //{ }

        //public string Name { get; set; }

        public void CourseChange()
        {
            course++;
        }
    }

    // class Starosta: St
    //{
    //    private void SetAverageMArkForStarosta()
    //    {
    //        averageMark = 100;
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass;// = new MyClass();
            myClass = new MyClass();


            MyStudent myStudent = new MyStudent();
            myStudent.name = "Vasia";
            
            
            myStudent.GetType();
            myStudent.CourseChange();

            MyStudent myStudent1 = new MyStudent();

            myStudent1 = myStudent;
            myStudent1.name = "Kolia";

            int a;
            //System.Int32 a1;


            int[] mas;
            mas = new int[5];
            mas = new int[10];
            mas[0] = 1;
            mas[1] = 2;
            //   Array.Sort(mas);
            //string str = "sdfsf";

            int[,] arr;
            //arr[0] = new int[5];

            
              

            string str = "ser";
            //str[0] = '';
          

            St st = new St();
            st.name = "Vasia";
            
           
            st.CourseChange();

            //MyStudent myStudent = new MyStudent();
            //myStudent.CourseChange();
           

            //Math.Tan(45);
            //Math.Pow(myStudent.course, 2);
            //Math.Sqrt(myStudent.course);
            //Student1 student1 = new Student1();
            //student1.course = 4;

            Console.WriteLine("Some text");
           // string str = Console.ReadLine();

            //Program prg = new Program();
            //prg.Method();

            myEnum me = myEnum.blue;
            int aa = Convert.ToInt32(me);

            Student[][] students = new Student[10][];
            students[0] = new Student[5];
            students[1] = new Student[10];

            int result = 5;

            Sqr s1 = new Sqr();
            Sqr s2 = new Sqr(50);
            Sqr s3 = new Sqr(s2);
            Sqr s4 = new Sqr(23, false);
            Sqr s5 = new Sqr(s1);



            s5 = s1;
           
            Sqr s10 = s1;
            //       s10.side = 100;



            //Sqr s5 = s1;
            //s1.side = 100;
            //result = s1.side;
            //s5.side = 500;
            //result = s5.side;



            //s1.Set(-125);
            //s1.Set(5);

            result = s1.P();
            result = s1.S();
            result = s1.Get();

            //s2.Set(10);
            result = s2.P();
            result = s2.S();
            result = s2.Get();
        }
    }
}
