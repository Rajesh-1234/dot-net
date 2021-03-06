﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign5_2
{

    public class Employee
    {
        int empno;
        string name;
        string designation;
        int age;

        public Employee(int empno, string empname, string designation, int age)
        {
            this.empno = empno;
            this.name = empname;
            this.designation = designation;
            this.age = age;
        }

        public override string ToString()
        {
            return empno + " " + name + " " + designation + " " + age;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1, "Raj", "manager", 24);
            Employee e2 = new Employee(2, "Manu", "genral manager", 22);
            List<Employee> list = new List<Employee>();

            list.Add(e1);
            list.Add(e2);

            //foreach(Employee li in list)
            // {
            //     Console.WriteLine(li);
            // }

            Employee[] emp = list.ToArray();

            foreach (Employee lio in emp)
            {
                Console.WriteLine(lio);
            }

            Console.ReadLine();
        }
    }
}