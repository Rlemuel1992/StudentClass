using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentObject
{
	class Student
	{
		public string name;
		public string favoriteFood;
		public string homeTown;

		public Student(string name, string favoriteFood, string homeTown)
		{
			this.name = name;
			this.favoriteFood = favoriteFood;
			this.homeTown = homeTown;
		}
		public void PrintInfo()
		{
			Console.WriteLine("Name: " + name);
			Console.WriteLine("Hometown: " + homeTown);
			Console.WriteLine("Favorite Food: " + favoriteFood);

		}
	}
}
