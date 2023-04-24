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
        //public int Id { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime BirthDate { get; set; }

        [Key]
        [MinLength(7, ErrorMessage = "MinLength 7")]
        [MaxLength(7, ErrorMessage = "MaxLength 7")]
        //[StringLength(7, MinimumLength = 7, ErrorMessage = "il faut etre 7 characters .. ... ...")]
        public string PassportNumber { get; set; }

        [EmailAddress(ErrorMessage = "une address email invalid .")]
        public string EmailAddress { get; set; }

        [MinLength(3, ErrorMessage = "MinLength 3")]
        [MaxLength(25, ErrorMessage = "MaxLength 25")]
        //[StringLength(25, MinimumLength = 3, ErrorMessage = "First entre 3 characters et 25 characters .")]
       
        // public string FirstName { get; set; }
       // public string LastName { get; set; }

        public FullName MyFullName { get; set; }

        [Phone(ErrorMessage ="phone number")]
        //[DataType(DataType.PhoneNumber)]
        public string TelNumber { get; set; }
        //tp5 Q6
        //public IList<Flight> Flights { get; set; }
        public virtual IList<Reservation> Reservations { get; set; }
        int age;
        public int Age //ecriture full si j'ai un traitement à faire dans get
        {
            get {
                DateTime now = DateTime.Now;
                age = now.Year - BirthDate.Year;
                if (now < BirthDate.AddYears(age)) //comparer now avec le futur anniversaire
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
                + "FirstName:" + MyFullName.FirstName + ";"
                + "LastName:" + MyFullName.LastName + ";"
                + "TelNumber:" + TelNumber;
        }

        //Question11.a
        public bool CheckProfile(string lastName, string firstName)
        {
            if (lastName == MyFullName.LastName && firstName == MyFullName.FirstName)
                return true;
            return false;
        }

        //Question11.b
        /*
        public bool CheckProfile(string lastName, string firstName, string emailAdress)
        {
            if (lastName == LastName && firstName == FirstName && emailAdress == EmailAddress)
                return true;
            return false;
        }
        */
        //*Question11.c (on remplace les 2 fonctions des Q.11.a ET Q.11.b )
        public bool CheckProfile(string lastName, string firstName, string emailAdress = null)
        {
            if (emailAdress == null)
                return lastName == MyFullName.LastName && firstName == MyFullName.FirstName;
            else
                return lastName == MyFullName.LastName && firstName == MyFullName.FirstName && emailAdress == EmailAddress;
        }


        //question 12 Polymorphisme par héritage
        public virtual string GetPassengerType()
        {
            return "I am a passenger";
        }
        //Question 13
        public void GetAge(DateTime birthDate, ref int calculatedAge)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - birthDate.Year;

            if (now < birthDate.AddYears(age))
            {
                age--;
            }

            calculatedAge = age;
        }

        // Autres propriétés et méthodes de la classe Passenger
        //public void GetAge(Passenger aPassenger)
        //{
        //    DateTime now = DateTime.Now;
        //    int age = now.Year - aPassenger.BirthDate.Year;

        //    if (now < BirthDate.AddYears(age))
        //    {
        //        age--;
        //    }

        //    aPassenger.Age = age;
        //}








































        //tp1 Question 13.a
        /* public void GetAge(DateTime birthDate, ref int calculatedAge)
         {
             DateTime now = DateTime.Now;
             int age = now.Year - birthDate.Year;
             if (now < birthDate.AddYears(age)) //comparer now avec le futur anniversaire
             {
                 age--;
             }
             calculatedAge = age;            
         }
        */
        /* public void GetAge(Passenger aPassenger)
         {
             DateTime now = DateTime.Now;
             int age = now.Year - aPassenger.BirthDate.Year;
             if (now < aPassenger.BirthDate.AddYears(age)) //comparer now avec le futur anniversaire
             {
                 age--;
             }
             aPassenger.Age = age;

         }
        */

    }

}
