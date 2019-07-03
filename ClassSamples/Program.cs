using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSamples
{
    partial class Program
    {
        static void Main(string[] args)
        {

            Person student1 = new Person();
            student1.FirstName = "John";
            student1.LastName = "Smith";
            student1.DOB = new DateTime(1900, 10, 1);

            Address address1 = new Address();
            address1.Line1 = "Line 1";
            address1.Line2 = "Line 2";
            address1.City = "canberra";
            address1.State_Province = "ACT";
            address1.Country = "Australia";

            Information si1 = new Information();
            si1.Title = "Student Information";
            si1.Person = student1;
            si1.Address = address1;


            Console.WriteLine("{0}", si1.Title);
            Console.WriteLine("{0}|{1}|{2}|{3}", si1.Person.FirstName, si1.Person.LastName, si1.Address.Line1, si1.Address.Line2);

    
            Person teacher1 = new Person();
            teacher1.FirstName = "Jim";
            teacher1.LastName = "cook";
            teacher1.DOB = new DateTime(1900, 10, 1);

            Address address2 = new Address();
            address2.Line1 = "Line 1";
            address2.Line2 = "Line 2";
            address2.City = "Canberra";
            address2.State_Province = "ACT";
            address2.Country = "Australia";

            Information ti1 = new Information();
            ti1.Title = "Teacher Information";
            ti1.Person = teacher1;
            ti1.Address = address2;
            

            Console.WriteLine("{0}", ti1.Title);
            Console.WriteLine("{0}|{1}|{2}|{3}|{4}", ti1.Person.FirstName, ti1.Person.LastName, ti1.Address.Line1, ti1.Address.Line2);

            Console.ReadLine();

        }


    }
    }
