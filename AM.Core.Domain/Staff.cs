using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Staff:Passenger //heritage Question 3
    {
        public DateTime EmployementDate { get; set; }
        public string Function { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return base.ToString()
                + "EmployementDate" + EmployementDate + ";"
                + "Function" + Function + ";"
                + "Salary" + Salary;
        }
        public override string getPassengerType()
        {
            return base.getPassengerType() //AFFICHE l message mte3ha i am a passenger 
            + "I am a staff Member";
                }
    }

}
