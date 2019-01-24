using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentObject;

namespace Lab8WithObjects
{
	class Program
	{
		static void Main()
		{
			Student s = new Student("Jimmy", "Hot dogs", "Detroit");
			Student s2 = new Student("Laura", "Bibimbap", "New Mexico");
			Student s3 = new Student("Kendra", "Veggie Burger + Fries", "Oak Park");
			List<Student> students = new List<Student>
			{
				s,
				s2,
				s3,

				new Student("Coleslaw Kendawg", "Peach Cobbler", "Heart of ATX")
			};

			//List<Student> students = new List<Student>();
			//students.Add(s);
			//students.Add(s2);			This is an alternative way for the above list. 
			//students.Add(s3);

			//students.Add(new Student("Coleslaw Kendawg", "Peach Cobbler", "Heart of ATX"));
			Console.WriteLine("Please put in a number from 0 to " + (students.Count -1));
			string input = Console.ReadLine();
			int choice = int.Parse(input);

			Student output = students[choice];
			output.PrintInfo();
		}
	}
}
