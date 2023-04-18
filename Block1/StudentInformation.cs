using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block1
{
    internal class StudentInformation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Information");

            int studentId = 1260;
            Console.WriteLine("Student ID:" + studentId);
            string firstName = "Jace";
            Console.WriteLine("First Name:" + firstName);
            string lastName = "Cockrell";
            Console.WriteLine("Last Name:" + lastName);
            char gender = 'M';
            Console.WriteLine("Gender (Male = M, Female = F, Not Given = N):" + gender);
            string major = "Xrp";
            Console.WriteLine("Major:" + major);
            float gPa = 3.9f;
            Console.WriteLine("GPA:" + gPa);
            decimal tuitionPaid = 500;
            Console.WriteLine("Tuition Paid:" + tuitionPaid);
            decimal tuitionOwed = 24500;
            Console.WriteLine("Tuition Owed:" + tuitionOwed);
            byte semHours = 2;
            Console.WriteLine("Credit Hours This Semester:" + semHours);
            byte totHours = 8;
            Console.WriteLine("Total Credit Hours:" + totHours);
        }//end main()
    }
}//end namspace
