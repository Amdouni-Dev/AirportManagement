using AM.Core.Domain;
using AM.Core.Extensions;
using AM.Core.Services;
using AM.Data;
//using System.Numerics; //starr hedha lezemni na7ih mel class sinn ywalli ya9ra fih howa namspace
// See https://aka.ms/new-console-template for more information



// TP2 
// Question 13.c

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




//IFlightService.GetScore methode2 = delegate (Passenger p)
//{



//}

//tp2 13.c
IFlightService.GetScore methode1 = delegate (Passenger p) //calcule par nbr de vol
{
    return p.flights.Count();
};
IFlightService.GetScore methode2 = delegate (Passenger p)  // calcule par nbr de vol det et depar tiunisia
{

    return p.flights.Where(f => f.Destination == "Tunisia"
                        || f.Departure == "Tunisia").Count();
};
IFlightService flightService = new FlightService();
var passengerSenior = flightService.GetSeniorPassenger(methode2);
Flight f = new Flight();
f.GetDelay();

Flight f2 = new Flight()
{
    Destination="Tunis1",
    Departure ="Tunis2",
    FlightDate = new DateTime(2000, 10, 10),
    EffectiveArrival = new DateTime(2000,10,10),
    estimationDuration=20,
    Comment="Hi Mouna",
    MyPlane=plane3
   

};

AMContext amc = new AMContext();
//amc.Add(plane3);
amc.Add(f2);
Passenger passengerTest = new Passenger()
{
    FirstName="Mouna",
    LastName="AMdouni",
    BirthDate = new DateTime(2000, 07, 27),
    PassportNumber = "1234567",
    EmailAddress = "mouna@gmail.com",
    FullName = new FullName()
    {

        FirstName = "Mouna",
        LastName = "Amdouni"
    },
    TelNumber = "20618005"
};
amc.Add(passengerTest);
Reservation r =new Reservation()
{
    Price= 10,
    Seat="A24",
    Vip=true,
    MyFlight=f2,
    MyPassenger=passengerTest
};
amc.Add(r);

amc.SaveChanges();