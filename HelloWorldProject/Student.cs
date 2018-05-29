using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProject {
	class Student {
		string Firstname;
		string Lastname;
		int StudentId;
		double GPA;
		int SAT;
		bool IsFemale;

		//FIRST NAME
		public string GetFirstname() {
			return Firstname;
		}
		public void SetFirstname(string pFirstname) {
			Firstname = pFirstname;
		}

		//LAST NAME
		public string GetLastname() {
			return Lastname;
		}
		public void SetLastname(string pLastname) {
			Lastname = pLastname;
		}

		//STUDENT ID
		public int GetStudentId() {
			return StudentId;
		}
		public void SetStudentId(int pStudentId) {
			StudentId = pStudentId;
		}

		//GPA
		public double GetGPA() {
			return GPA;
		}
		public void SetGPA(double pGPA) {
			GPA = pGPA;
		}

		//SAT;
		public int GetSAT() {
			return SAT;
		}
		public void SetSAT(int pSAT) {
			SAT = pSAT;
		}


		//IsFemale;
		public bool GetIsFemale() {
			return IsFemale;
		}
		public void SetIsFemale(bool pIsFemale) {
			IsFemale = pIsFemale;
		}
	}
}
