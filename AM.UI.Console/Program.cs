// See https://aka.ms/new-console-template for more information
//using System.Numerics;

using AM.Core.Domain;
using AM.Core.Extensions;
using AM.Core.Interfaces;
using AM.Core.Services;
using AM.Data;

////TP1. Question 7
//Console.WriteLine("Hello, World!");
//Plane plane= new Plane();
//plane.Capacity = 100;
//plane.ManufactureDate = new DateTime(2000,1,1);
//plane.MyPlaneType = PlaneType.BOING;

////TP1. Question 8  (on utilise ce methode quand il y a des proprietes obligatoires)
//Plane plane2 = new Plane(PlaneType.BOING, 100, new DateTime(2000, 1, 1));

////TP1 Question 9 construire le constructore et l'initialiser (initialiseur d'objet) - plus dynamique
//Plane plane3 = new Plane()
//{
//    Capacity= 100,
//    ManufactureDate= new DateTime(2000, 1, 1),
//    MyPlaneType= PlaneType.BOING
//};

//Passenger passenger = new Passenger();
//passenger.BirthDate = new DateTime(1990, 5, 1);
////passenger.GetAge1();
//Console.WriteLine(passenger.Age);


////tp1 question 12.b
//Passenger passanger2 =new Passenger();
//Passenger staff2= new Staff();
//Passenger traveller2 = new Traveller();
//Console.WriteLine(passanger2.GetPassengerType());
//Console.WriteLine(staff2.GetPassengerType());
//Console.WriteLine(traveller2.GetPassengerType());

////tp1 question 13.c
//Passenger passenger3=new Passenger();
////int calculatedAge = 5;
////passenger3.GetAge(new DateTime(2000,1,1), ref calculatedAge);
////Console.WriteLine(calculatedAge);
//passenger3.BirthDate = new DateTime(2000, 1, 1);
////passenger3.GetAge(passenger3);
//Console.WriteLine(passenger3.Age);

////tp2 13.c
//IFlightService.GetScore methode1 = delegate (Passenger p) //calcule par nbr de vol
//{
//    return p.Flights.Count();
//}; 
//IFlightService.GetScore methode2 = delegate (Passenger p)  // calcule par nbr de vol det et depar tiunisia
//{

//    return p.Flights.Where(f => f.Destination=="Tunisia" 
//                        || f.Departure =="Tunisia" ).Count();
//};
//IFlightService flightService = new FlightService();
//var passengerSenior = flightService.GetSeniorPassenger(methode2);   
//Flight f= new Flight();
//f.GetDelay();

//Tp3.III-8
//Plane plane = new Plane()
//{
//    Capacity = 10,
//    ManufactureDate = new DateTime(1998, 09, 01, 10, 30, 0),
//    MyPlaneType = PlaneType.AIRBUS
//};

//Flight flight = new Flight() { 
//    Comment = "comment",
//    Departure="Tunis",
//    Destination="Algerie",
//    EffectiveArrival=new DateTime(2023,09,01,12,0,0),
//    EstimatedDuration=60,
//    FlightDate=new DateTime(2023,09,01,10,30,0),
//    MyPlane=plane

//};

//AMContext aMContext = new AMContext();
//aMContext.Add(plane);
//aMContext.Add(flight);
//aMContext.SaveChanges();

//Tp5 Q8

//Flight flightTest = new Flight()
//{
//    Comment = "comment",
//    Departure = "Tunis",
//    Destination = "Algerie",
//    EffectiveArrival = new DateTime(2023, 09, 01, 12, 0, 0),
//    EstimatedDuration = 60,
//    FlightDate = new DateTime(2023, 09, 01, 10, 30, 0)
//};

//Passenger passengerTest = new Passenger()
//{
//    BirthDate = new DateTime(2000, 07, 27),
//    PassportNumber = "1234567",
//    EmailAddress = "aziz@gmail.com",
//    MyFullName = new FullName()
//    {

//        FirstName="aziz",
//        LastName="ben ismail"
//    },
//     TelNumber= "21438447"
//};

//Reservation reservation = new Reservation()
//{
//Price=200,
//Seat="A24",
//Vip=true,
//MyPassenger=passengerTest,
//MyFlight=flightTest
//};

//AMContext aMContext = new AMContext();
//aMContext.Add(flightTest);
//aMContext.Add(passengerTest);
//aMContext.Add(reservation);
//aMContext.SaveChanges();

//TP5 Q10

//Plane planeQ10 = new Plane()
//{
//    Capacity = 10,
//    ManufactureDate = new DateTime(1998, 09, 01, 10, 30, 0),
//    MyPlaneType = PlaneType.AIRBUS

//};

//Flight flightQ10 = new Flight()
//{
//    Comment = "comment",
//    Departure = "Tunis",
//    Destination = "Canada",
//    EffectiveArrival = new DateTime(2023, 09, 01, 12, 0, 0),
//    EstimatedDuration = 60,
//    FlightDate = new DateTime(2023, 09, 01, 10, 30, 0),
//    MyPlane = planeQ10

//};


//AMContext aMContext = new AMContext();
//aMContext.Add(flightQ10);
//aMContext.Add(planeQ10);
//aMContext.SaveChanges();
//Console.WriteLine(flightQ10);
//Console.WriteLine(flightQ10.MyPlane);

//Flight flightQ11 = aMContext.Find<Flight>(2);
//Console.WriteLine(flightQ11);
//Console.WriteLine(flightQ11.MyPlane);

//TP6 P partie6
//AMContext ctxt = new AMContext();

//IRepository<Flight> flightRepository = new Repository<Flight>(ctxt);

//Flight flightQ12 = new Flight()
//{
//    Comment = "comment",
//    Departure = "Tunis",
//    Destination = "Canada",
//    EffectiveArrival = new DateTime(2023, 09, 01, 12, 0, 0),
//    EstimatedDuration = 60,
//    FlightDate = new DateTime(2023, 09, 01, 10, 30, 0)
//};

//flightRepository.Add(flightQ12);
//flightRepository.Commit();

// Q6
AMContext ctxt = new AMContext();
IRepository<Plane> planeRepository = new Repository<Plane>(ctxt);
PlaneService planeService = new PlaneService(planeRepository);

Plane planeQ10 = new Plane()
{
    Capacity = 10,
    ManufactureDate = new DateTime(1998, 09, 01, 10, 30, 0),
    MyPlaneType = PlaneType.AIRBUS

};
planeService.Add(planeQ10);

IRepository<Flight> flightRepository = new Repository<Flight>(ctxt);
FlightService flightService = new FlightService(flightRepository);
Flight flightQ12 = new Flight()
{
    Comment = "comment",
    Departure = "Tunis",
    Destination = "Canada",
    EffectiveArrival = new DateTime(2023, 09, 01, 12, 0, 0),
    EstimatedDuration = 60,
    FlightDate = new DateTime(2023, 09, 01, 10, 30, 0)
};
flightService.Add(flightQ12);