using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            activity1();

            activity2();
            activity3();
            activity4();



          



        }
        static void activity1()
        {
            //create a list of integers
            List<int> numbers = new List<int>();

             //Add integers to the list
             numbers.Add(6);
             numbers.Add(7);
             numbers.Add(3);
             numbers.Add(4);
             numbers.Add(0);

             Console.WriteLine("Orignal list:");
             foreach( int number in numbers)
             {
                 Console.WriteLine(number);
             }

              numbers.Sort();
              Console.WriteLine("Sorted list");
             foreach (int number in numbers)
             {
                   Console.WriteLine(number);
             }

                numbers.Remove(4);
               Console.WriteLine("List after removing 4");
               foreach (int number in numbers)
               {
                 Console.WriteLine(number);
               }
        }
        static void activity2()
        {
            // create dictionary
            Dictionary<string, string> countries = new Dictionary<string, string>();

            //add countries
            countries["USA"] = "Washington DC";
            countries["France"] = "Paris";
            countries["Japan"] = "Tokyo";
            countries["India"] = "Dehli";


            //display all countries and their capitals
            Console.WriteLine("Countries and capitals");
            foreach (var pair in countries)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }

            // retrieve capital of specific coutry
            Console.WriteLine($"\ncapital of japan: {countries["Japan"]}");

            //remove a specific country
            countries.Remove("France");

            //display countries after removing
            Console.WriteLine("Countries after removing france");
            foreach (var pair in countries)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }
           
        }
        static void activity3()
        {

             ArrayList arrayList = new ArrayList();
              arrayList.Add(10);
              arrayList.Add("HELLO");
              arrayList.Add(30.5);
              arrayList.Add("WORLD");

              Console.WriteLine("Array list items");
              foreach(var item in arrayList)
              {
                  Console.WriteLine(item);
              }

              Console.WriteLine($"\nArray list items after removing hello");
              arrayList.Remove("HELLO");
              foreach (var item in arrayList)
              {
                  Console.WriteLine(item);
              }
        }
        static void activity4()
        {
            Dictionary<string, List<int>> students = new Dictionary<string, List<int>>();

            students["Alice"] = new List<int> { 85, 88, 90 };
            students["Bob"] = new List<int> { 70, 60, 75 };
            students["Charlie"] = new List<int> { 95, 92, 94 };
            students["Daisy"] = new List<int> { 55, 60, 58 };

            Console.WriteLine("Students average");
            foreach (var student in students)
            {
                double average = student.Value.Average();
                Console.WriteLine($"{student.Key}:{average:F2}");

            }

            var topStudent = students.OrderByDescending(a => a.Value.Average()).First();
            var lowStudent = students.OrderBy(a => a.Value.Average()).First();
            Console.WriteLine();
            Console.WriteLine($"Top performing student: {topStudent.Key}");
            Console.WriteLine($"worst performing student: {lowStudent.Key}");

            var failingStudent = students.Where(a => a.Value.Average() < 60).Select(a => a.Key).ToList();
            foreach (var student in failingStudent)
            {
                students.Remove(student);
            }

            Console.WriteLine($"\nafter removing low performing student");


            foreach (var student in students)
            {
                double average = student.Value.Average();
                Console.WriteLine($"{student.Key}:{average:F2}");

            }
        }
    }
}
