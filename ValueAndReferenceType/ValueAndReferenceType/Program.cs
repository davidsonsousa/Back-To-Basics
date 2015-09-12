using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceType
{
	class Program
	{
		static void Main(string[] args)
		{
			// In order to make this work we must do the same thing for both Class and Struct
			// See below

			// 1. Create a class and assign some values to it
			PersonClass personClass = new PersonClass { GivenName = "Joe", Surname = "Class" };
			// 2. Create a new class and just copy the previous one into it
			PersonClass newPersonClass = personClass;
			// 3. Change one of the values from the newly created class
			newPersonClass.GivenName = "Paul";

			// 4. Create a struct and assign some values to it
			PersonStruct personStruct = new PersonStruct { GivenName = "Jane", Surname = "Struct" };
			// 5. Create a new struct and just copy the previous one into it
			PersonStruct newPersonStruct = personStruct;
			// 6. Change one of the values from the newly created struct
			newPersonStruct.GivenName = "Mary";

			// 7. Print all the values and see the result
			Console.WriteLine("** Result **");

			// personClass: Paul Class
			Console.WriteLine(string.Format("personClass: {0}", personClass.FullName));

			// newPersonClass: Paul Class
			Console.WriteLine(string.Format("newPersonClass: {0}", newPersonClass.FullName));

			// personStruct: Jane Struct
			Console.WriteLine(string.Format("personStruct: {0}", personStruct.FullName));

			// newPersonStruct: Mary Struct
			Console.WriteLine(string.Format("newPersonStruct: {0}", newPersonStruct.FullName));

			Console.ReadLine();
		}
	}
}
