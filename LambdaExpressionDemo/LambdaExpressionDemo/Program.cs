using System;
using System.Collections;
using System.Collections.Generic;
namespace LambdaExpressionDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Lambda expression tutorial");
            Console.WriteLine();
            Console.ReadLine();

            List<Person> students=new List<Person>();
            AddingPersonIntoList(students);
            Retrive_Age_LessThan_60(students);
            Retrive_All_Record_Teenager(students);
            Find_Average_Age(students);
            SearchPersonBasedOnName(students);

        }

        private static  void AddingPersonIntoList(List<Person> students)
        {
            students.Add(new Person() { SSN = 1,  Name= "Pawan", Address = "RFJ", Age = 21});
            students.Add(new Person() { SSN = 1, Name = "premlata", Address = "GAYA", Age = 93 });
            students.Add(new Person() { SSN = 2, Name = "Prem", Address = "DGR", Age = 13 });
            students.Add(new Person() { SSN = 3, Name = "Pratyush", Address = "NDL", Age = 41 });
            students.Add(new Person() { SSN = 4, Name = "Piyush", Address = "PNBE", Age = 61 });
            students.Add(new Person() { SSN = 5, Name = "Prafful", Address = "DHNB", Age = 81 });
            students.Add(new Person() { SSN = 6, Name = "Priyanshu", Address = "DDU", Age = 15 });
            DisplayPerson(students);
        }

        private static void DisplayPerson(List<Person> students)
        {
            foreach(Person person in students)
            {
                Console.WriteLine(person);
            }
        }

        //UC-2
        private static void Retrive_Age_LessThan_60(List<Person> students)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Age less than sixty with top two record");
            foreach (Person person in students.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
               
                Console.WriteLine("Name :" + person.Name + "Age : " + person.Age);
            }
        }

        //UC-3
        private static void Retrive_All_Record_Teenager(List<Person> students)
        {
            Console.WriteLine(" ");
            Console.WriteLine("All person lies between 13 to 18");
            foreach (Person person in students.FindAll(e => (e.Age > 13 && e.Age < 18)))
                {
                Console.WriteLine("Name: " + person.Name + " Age " + person.Age);
               }
        }
        //UC-4
        private static void Find_Average_Age(List<Person> students)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Here is the average");
            double average = students.Average<Person>(e=>e.Age);
            Console.WriteLine("the average of all student = " + average);
            Console.ReadLine();
        }

        //UC-5
        private static void SearchPersonBasedOnName(List<Person> students)
        {
            Console.WriteLine("");
            Console.WriteLine("searching person based on name");
            if (students.Any(e => e.Name == "Piyush"))
            {
                Console.WriteLine("The Person is Present");
            }
            else
            {
                Console.WriteLine("The Person is Absent");
            }
        }
    }
}