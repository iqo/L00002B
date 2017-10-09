using System;

class Employee{

	private string name;
	private string socialSecurityNumber;
	private string district;
	private int itemsSold;
	private string ArticleLevel;

	public Employee(string name, string socialSecurityNumber, string district, int itemsSold){
		this.name = name;
		this.socialSecurityNumber = socialSecurityNumber;
		this.district = district;
		this.itemsSold = itemsSold;
	}

		public void SetArticleLevel(string articleLevel){
		this.ArticleLevel = articleLevel;
	}

		public string GetArticleLevel(){
		return this.ArticleLevel;
	}

	public string GetName(){
		return this.name;
	}

	public string GetSocialSecurityNumber(){
		return this.socialSecurityNumber;
	}

	public string GetDistrict(){
		return this.district;
	}

	public int GetItemsSold(){
		return this.itemsSold;
	}
}