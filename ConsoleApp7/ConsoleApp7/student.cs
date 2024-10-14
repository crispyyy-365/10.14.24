using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp7
{
    class student
    {
        public string Name;
        public string Surname;
        public string Group;
        public int Point;
        public bool IsGraduated;

       public student(string name, string surname, string group, int point)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;

            if (point >= 0 && point < 65)
            {
                IsGraduated = false;
            }
            else
            {
                IsGraduated = true;
            }
        }
        public void GetInfo(string name, string surname, string group, int point)
        {
            Console.WriteLine($"Name : {name} , surname : {surname} , group : {group} , point : {point}");
        }
        public void CheckGraduation(bool isgraduated)
        {
            if (isgraduated)
            {
                Console.WriteLine("the student is graduated.");
            }
            else
            {
                Console.WriteLine("the student is not graduated , because the point is below 65.");
            }
        }
        public void GetDiplomDegree(int point)
        {
            if (0 <= point && point <= 65)
            {
                Console.WriteLine("the student has no diploma.");
            }
            else if (65 < point && point <= 80)
            {
                Console.WriteLine("the student has an ordinary diploma.");
            }
            else if (80 < point && point <= 90)
            {
                Console.WriteLine("the student has an honor diploma.");
            }
            else if (90 < point && point <= 100)
            {
                Console.WriteLine("the student has a high honor diploma . ");
            }
            else
            {
                Console.WriteLine("there is no such point!");
            }
        }
    }
}
