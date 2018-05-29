using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProject {
	class Program {
		static void Main(string[] args)	{
			Console.WriteLine("Hello, world!");

			Student student = new Student();
			student.SetFirstname("Frank");
			student.SetLastname("Zappa");
			student.SetStudentId(123);
			student.SetGPA(3.5);
			student.SetSAT(1520);
			student.SetIsFemale(false);

			string fname;
			string lname;
			int sid;
			double gpa;
			int sat;
			bool female;

			fname = student.GetFirstname();
			lname = student.GetLastname();
			sid = student.GetStudentId();
			gpa = student.GetGPA();
			sat = student.GetSAT();
			female = student.GetIsFemale();

			Console.WriteLine();
			Console.WriteLine("Name:\t" + fname + " " + lname);
			Console.WriteLine("Id:" + "\t" + sid);
			Console.WriteLine("GPA:\t" + gpa);
			Console.WriteLine("SAT:\t" + sat);
			Console.WriteLine("Female:\t" + female);
			Console.WriteLine();
		}
	}
}
