using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Assignment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter Number of student you want to add :- ");
            int s = Convert.ToInt32(Console.ReadLine());
            Student[] student = new Student[s];

           CreateArray(student);
            PrintInfo(student);
            ReverseArray(student);
            //student[0].AcceptDetails();
            //student[1].AcceptDetails();
            //student[0].PrintDetails();
            //student[1].PrintDetails();
             
        }

       public static void CreateArray(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();
                students[i].AcceptDetails();
            }

        }

        public static void PrintInfo(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
               Console.WriteLine(students[i].PrintDetails());
            }

        }


        public static void ReverseArray(Student[] students)
        {
            Student[] students1 = new Student[students.Length];

            for (int i = 0; i < students.Length; i++)
            {
                students1[i] = students[students.Length-i - 1];
               Console.WriteLine(students1[i].PrintDetails());
            }

        }
    }

    public struct Student
    {
        internal string _Name;
        internal bool _Gender;
        internal int _Age;
        internal int _Std;
        internal char _Div;
        internal double _Marks;
   

        public Student(string name, bool gender, int age, int std, char div, double marks)
        {
            this._Name = name;
            this._Gender = gender;
            this._Age = age;
            this._Std = std;
            this._Div = div;
            this._Marks = marks;
          
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public bool Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }

        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }
        public int Std
        {
            get { return _Std; }
            set { _Std = value; }
        }

        public char Div
        {
            get { return _Div; }
            set { _Div = value; }
        }

        public double Marks
        {
            get { return _Marks; }
            set { _Marks = value; }
        }

        public void AcceptDetails()
        {
            Console.WriteLine("Enter Name :- ");
            _Name=Console.ReadLine();
            Console.WriteLine("\nEnter Gender :- ");
            _Gender=Convert.ToBoolean(Console.ReadLine());
       
            Console.WriteLine("\nEnter Age :- ");
            _Age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter Std :- ");
            _Std=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter Div :- ");
            _Div=Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\nEnter Marks :- ");
            _Marks=Convert.ToDouble(Console.ReadLine());

        }

        public string PrintDetails()
        {
            return _Name + " " +_Gender + " " +_Age+" "+Std+" "+_Div+" "+_Marks;
        }




    }
           

    }
