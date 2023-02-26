using AM.Core.Domain;
//using System.Numerics; //starr hedha lezemni na7ih mel class sinn ywalli ya9ra fih howa namspace
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World Mounaaaa!");

// TP1 Question7
Plane plane= new Plane();
plane.Capacity = 100;
plane.ManufactureDate = new DateTime(2000,1,1);
plane.MyPlaneType = PlaneType.BOING;

// TP1 Questtion8
Plane plane1 = new Plane(PlaneType.BOING, 100, new DateTime(2000, 1, 1));

//Tp1 Question 9
Plane plane3 = new Plane()
{
    Capacity = 100,
    ManufactureDate = new DateTime(2000, 1, 1),
    MyPlaneType = PlaneType.BOING,


};
// Question13.b
Passenger passenger = new Passenger();
Staff s= new Staff();
Console.WriteLine("******Question13.b********");
Console.WriteLine(s.getPassengerType());


// Execution  Question 14 
Passenger passenger3 = new Passenger();
passenger3.BirthDate = new DateTime(1999, 04, 19);
passenger3.PassportNumber = "MounPassport Nb123";
passenger3.EmailAddress = "mouna@esprit.tn";
passenger3.LastName = "AMdouni Mouuun";
passenger3.TelNumber = "123456789";
Console.WriteLine(passenger3.ToString()+" ******Age:"+passenger3.Age);

/*   public override string ToString()
        {
            return "BirthDate:" + BirthDate + ";"
                + "PassportNumber:" + PassportNumber + ";"
                + "EmailAddress:" + EmailAddress + ";"
                + "FirstName:" + FirstName + ";"
                + "LastName:" + LastName + ";"
                + "TelNumber:" + TelNumber;
        }*/
