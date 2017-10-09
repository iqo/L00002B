using System;
using System.Collections.Generic;

namespace Lab2{
	class EmployeeHandling{
		private List<Employee> employeeList;
		private List<int> articleLevels;
		private System.IO.StreamWriter file;
		private int employeeLevelCount;

		public EmployeeHandling(){
			this.employeeList = new List<Employee>();
			this.articleLevels = new List<int>() { 0, 0, 0, 0 };
			this.file = new System.IO.StreamWriter(@"/home/iqo/programming/github/L00002B/lab2/employeeFile.txt");
			this.employeeLevelCount = 0;

		}

		public void AddNewEmployee(int numberOfEmployees){
			for(int i = 0; i < numberOfEmployees; i++){
				int convertedItemsSold;
				Console.WriteLine("Enter the name of the employee: ");
				string name = Console.ReadLine();
				Console.WriteLine("Enter the social security number of the employee: ");
				string socialSecurityNumber = Console.ReadLine();
				Console.WriteLine("Enter the district of the employee: ");
				string district = Console.ReadLine();
				Console.WriteLine("Enter the amount of items sold: ");
				string itemsSold = Console.ReadLine();
				if(int.TryParse(itemsSold, out convertedItemsSold) && convertedItemsSold >= 0){
					this.employeeList.Add(new Employee(name, socialSecurityNumber, district, convertedItemsSold));
					Console.WriteLine("---new employee added---");
				}
			}
		}

		public static void PrintSingelEmployee(Employee employee){
			Console.WriteLine("{0, 20}{1,20}{2,20}{3,20}{4,20}", employee.GetName(), employee.GetSocialSecurityNumber(), employee.GetDistrict(), employee.GetItemsSold(), employee.GetArticleLevel());
		}

		public void DetermineArticleLevel(){
			foreach(var employee in this.employeeList){
				if(employee.GetItemsSold() < 50){
					employee.SetArticleLevel("1");
					this.articleLevels[0] = this.articleLevels[0] + 1;
				}
				else if(employee.GetItemsSold() < 100){
					employee.SetArticleLevel("2");
					this.articleLevels[1] = this.articleLevels[1] + 1;	
				}

				else if(employee.GetItemsSold() < 200){
					employee.SetArticleLevel("3");
					this.articleLevels[2] = this.articleLevels[2] + 1;	
				}
				else if(employee.GetItemsSold() >= 200){
					employee.SetArticleLevel("4");
					this.articleLevels[3] = this.articleLevels[3] + 1;	
				}
			}
		}

		public void SortEmployeeList(){
			for (int i = 0; i < this.employeeList.Count; i++){
				this.employeeList.Sort((e1, e2) => e1.GetItemsSold().CompareTo(e2.GetItemsSold()));
			}
		}

		public void PrintEmployeeDetailsToFileAndInTerminal(){
			using(this.file){
				this.file.Write("{0}","---- Employee information ----" + "\n");
				Console.WriteLine("{0}","---- Employee information ----" + "\n");
				foreach(var employee in this.employeeList){
					if(employee.GetItemsSold() < 50){
						this.file.Write("\n"+"{0}{1}{2}{3}{4}", "name: " +employee.GetName() + "\n", "Social security number: " + employee.GetSocialSecurityNumber() + "\n","District: " + employee.GetDistrict() + "\n", "Items sold: " +employee.GetItemsSold() + "\n", "Sales level: " + employee.GetArticleLevel() + "\n");
						Console.WriteLine("\n"+"{0}{1}{2}{3}{4}", "name: " +employee.GetName() + "\n", "Social security number: " + employee.GetSocialSecurityNumber() + "\n","District: " + employee.GetDistrict() + "\n", "Items sold: " +employee.GetItemsSold() + "\n", "Sales level: " + employee.GetArticleLevel() + "\n");
						this.employeeLevelCount = this.employeeLevelCount + 1;
						if(this.articleLevels[0] == this.employeeLevelCount){
							this.file.Write("{0}{1}", "\n" + this.employeeLevelCount," employees on level 1" + "\n");
							Console.WriteLine("{0}{1}", "\n" + this.employeeLevelCount," employees on level 1" + "\n");
							this.employeeLevelCount = 0;
						}

					}
					else if(employee.GetItemsSold() < 100){
						this.file.Write("\n"+"{0}{1}{2}{3}{4}", "name: " +employee.GetName() + "\n", "Social security number: " + employee.GetSocialSecurityNumber() + "\n","District: " + employee.GetDistrict() + "\n", "Items sold: " +employee.GetItemsSold() + "\n", "Sales level: " + employee.GetArticleLevel() + "\n");
						Console.WriteLine("\n"+"{0}{1}{2}{3}{4}", "name: " +employee.GetName() + "\n", "Social security number: " + employee.GetSocialSecurityNumber() + "\n","District: " + employee.GetDistrict() + "\n", "Items sold: " +employee.GetItemsSold() + "\n", "Sales level: " + employee.GetArticleLevel() + "\n");
						this.employeeLevelCount = this.employeeLevelCount + 1;
						if(this.articleLevels[1] == this.employeeLevelCount){
							this.file.Write("{0}{1}", "\n" + this.employeeLevelCount," employees on level 2" + "\n");
							Console.WriteLine("{0}{1}", "\n" + this.employeeLevelCount," employees on level 2" + "\n");
							this.employeeLevelCount = 0;
						}

					}
					else if(employee.GetItemsSold() < 200){
						this.file.Write("\n"+"{0}{1}{2}{3}{4}", "name: " +employee.GetName() + "\n", "Social security number: " + employee.GetSocialSecurityNumber() + "\n","District: " + employee.GetDistrict() + "\n", "Items sold: " +employee.GetItemsSold() + "\n", "Sales level: " + employee.GetArticleLevel() + "\n");
						Console.WriteLine("\n"+"{0}{1}{2}{3}{4}", "name: " +employee.GetName() + "\n", "Social security number: " + employee.GetSocialSecurityNumber() + "\n","District: " + employee.GetDistrict() + "\n", "Items sold: " +employee.GetItemsSold() + "\n", "Sales level: " + employee.GetArticleLevel() + "\n");
						this.employeeLevelCount = this.employeeLevelCount + 1;
						if(this.articleLevels[2] == this.employeeLevelCount){
							this.file.Write("{0}{1}", "\n" + this.employeeLevelCount," employees on level 3" + "\n");
							Console.WriteLine("{0}{1}", "\n" + this.employeeLevelCount," employees on level 3" + "\n");
							this.employeeLevelCount = 0;
						}

					}
					else if(employee.GetItemsSold() >= 200){
						this.file.Write("\n"+"{0}{1}{2}{3}{4}", "name: " +employee.GetName() + "\n", "Social security number: " + employee.GetSocialSecurityNumber() + "\n","District: " + employee.GetDistrict() + "\n", "Items sold: " +employee.GetItemsSold() + "\n", "Sales level: " + employee.GetArticleLevel() + "\n");
						Console.WriteLine("\n"+"{0}{1}{2}{3}{4}", "name: " +employee.GetName() + "\n", "Social security number: " + employee.GetSocialSecurityNumber() + "\n","District: " + employee.GetDistrict() + "\n", "Items sold: " +employee.GetItemsSold() + "\n", "Sales level: " + employee.GetArticleLevel() + "\n");
						this.employeeLevelCount = this.employeeLevelCount + 1;
						if(this.articleLevels[3] == this.employeeLevelCount){
							this.file.Write("{0}{1}", "\n" + this.employeeLevelCount," employees on level 4" + "\n");
							Console.WriteLine("{0}{1}", "\n" + this.employeeLevelCount," employees on level 3" + "\n");
							this.employeeLevelCount = 0;
						}
					}
				}
			}
		}
	}
}