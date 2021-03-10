using System;

namespace KonstantinLesson
{
	public interface IInterface
	{
		string GetName(long id);
	}

	public class Person : IInterface
	{
		public string GetName(long id)
		{
			return "Vasya";
		}
	}

	public class People : IInterface
	{
		public string GetName(long id)
		{
			return "Petya";
		}
	}
	
	public class Employee
	{
		private readonly IInterface _person;
		
		public Employee(IInterface person)
		{
			_person = person;
		}
		public string Name { get; set; }
		public void SetName(int id)
		{
			
			Name = _person.GetName(id);
		}
	}

	class Program
	{
		public string Name { get; set; }
		
		static void Main(string[] args)
		{
			var person = new Employee(new People()); 
			person.SetName(1);
			person.SetName(1);
			Console.WriteLine(person.Name);
		}
	}
}