using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L0002BInl3
{
    class PersonCalculator
    {
        private string FirstName ;
        private string SurName;
        private string SocialSecurityNumber;
        private int Buffer;
        private int Holder;
        private int TempHolder;

        public PersonCalculator(string FirstName, string SurName, string SocialSecurityNumber)
        {
            this.FirstName = FirstName;
            this.SurName = SurName;
            this.SocialSecurityNumber = SocialSecurityNumber;
        }

        public string GetSex()
        { 
            if(this.SocialSecurityNumber.Length != 10 ){
                return "social security number is wrong,  enter a 10 digit number";
            }
            else if(this.SocialSecurityNumber[8] % 2 == 0) {
                return "Woman";
            }
            return "Man";
        }

        public string GetFirstName() {
            return this.FirstName;
        }

        public string GetSurName() {
            return this.SurName;
        }

        public string GetSocialSecurityNumber() {
            return this.SocialSecurityNumber;
        }

        public Boolean CalculateSocialSecurityNumber() {
            if (this.SocialSecurityNumber.Length != 10) {
                return false;
            }
            for (int PlaceCounter = 0; PlaceCounter < this.SocialSecurityNumber.Length; PlaceCounter++ )
            {
                this.Holder = (int)Char.GetNumericValue(this.SocialSecurityNumber[PlaceCounter]);
                if (PlaceCounter % 2 == 0)
                {
                    this.Holder = this.Holder * 2;
                    if (this.Holder >= 10) {
                        this.TempHolder = this.Holder % 10;
                        this.Holder = this.Holder / 10;
                        this.Holder = this.Holder + this.TempHolder;
 
                    }
                }
                this.Buffer = this.Buffer + this.Holder;
            }
            if(this.Buffer % 10 != 0){
                return false;
            }

            return true;
        }
    }
}
