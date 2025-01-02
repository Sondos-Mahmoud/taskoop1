using System;

namespace taskoop1
{
    internal class Program
    {
        static double calculatedestance(Point p1,Point p2) {
            double distance = Math.Sqrt((p1.X-p2.X)* (p1.X - p2.X)+ (p1.Y - p2.Y) * (p1.Y - p2.Y));
            
            return distance; }
        static person FindOldestPerson(person[] persons)
        {
            person oldest = persons[0];

            foreach (person person in persons)
            {
                if (person.Age > oldest.Age)
                {
                    oldest = person;
                }
            }

            return oldest;
        }
        static void Main(string[] args)
        {
            #region q1
            //Console.WriteLine("Enter the coordinates of the first point (x1 y1):");
            //double x1 = double.Parse(Console.ReadLine());
            //double y1 = double.Parse(Console.ReadLine());
            //Point point01 = new Point(x1, y1);
            ////Console.WriteLine(point.X);
            //Console.WriteLine("Enter the coordinates of the second point (x2 y2):");
            //double x2 = double.Parse(Console.ReadLine());
            //double y2 = double.Parse(Console.ReadLine());
            //Point point02 = new Point(x2, y2);
            //Console.WriteLine("The distance between the two points is: ");
            //Console.WriteLine(calculatedestance(point01, point02));
            #endregion
            #region q2
            // person[] persons = new person[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter details for person {i + 1}:");

            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();

            //    Console.Write("Age: ");
            //    int age = int.Parse(Console.ReadLine());

            //    persons[i] = new person(name, age);
            //}

            //    person oldest = FindOldestPerson(persons);

            //Console.WriteLine($"The oldest person is {oldest.Name}, aged {oldest.Age}.");
            #endregion

        }
    }
}