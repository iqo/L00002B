using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab2{

	class Program{
		static void Main(string[] args){
			var test = new EmployeeHandling();
			test.AddNewEmployee(1);
			test.SortEmployeeList();
			test.DetermineArticleLevel();
			test.PrintEmployeeDetailsToFileAndInTerminal();
		}
	}
}