using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Passenger
    {
        public DateTime BirthDate
        {
            get;
            set;
        }
        [Key]
        public string PassportNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelNumber { get; set; }
        public IList<Flight> flights { get; set; }


     
        //TP1 Question 11.a
        public bool checkProfile(string nom,string prenom)
        {
            if(FirstName==nom && LastName==prenom) return true;
            return false;
        }
        //TP1 Question 11.b
        //public bool checkProfile(string nom,string prenom,string email)
        //{
        //    if(FirstName==nom && LastName==prenom&& email==EmailAddress) return true;
        //    return false;
        //}
        // TP1 Question11.c ==> methode t3awedh les deuxmethodes 11.a w 11.b
        public bool checkProfile(string nom, string prenom, string email)
        {
            if (email == null)
                return (LastName == prenom && FirstName == nom);
            else
                return LastName == prenom && FirstName == nom;

            
        }
        //Qyestion12: Polymorphisme par heritage :virtual fel classe mere
        public virtual string getPassengerType()
        {
            return "I am a passenger";
        }

        //Question 14 encapsulation
        int age;
        public int Age
        {
            get
            {
                DateTime now= DateTime.Now; // wa9t taw
                age=now.Year -BirthDate.Year; // bech nkharej da3mor direct
                if(now<BirthDate.AddYears(age))//bech y9aren taw bel anniversaire jey 
                {
                    age--;
                }


                return age;
            }
           
            
        }
        public override string ToString()
        {
            return "BirthDate:" + BirthDate + ";"
                + "PassportNumber:" + PassportNumber + ";"
                + "EmailAddress:" + EmailAddress + ";"
                + "FirstName:" + FirstName + ";"
                + "LastName:" + LastName + ";"
                + "TelNumber:" + TelNumber + ";"
                + "Age:" + age;
        }



    }
}
