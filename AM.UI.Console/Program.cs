using AM.Core.Domain;
using AM.Core.Extensions;
using AM.Core.Interfaces;
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
//IFlightService.GetScore methode1 = delegate (Passenger p) //calcule par nbr de vol
//{
//    return p.flights.Count();
//};
//IFlightService.GetScore methode2 = delegate (Passenger p)  // calcule par nbr de vol det et depar tiunisia
//{

//    return p.flights.Where(f => f.Destination == "Tunisia"
//                        || f.Departure == "Tunisia").Count();
//};
//IFlightService flightService = new FlightService();
//var passengerSenior = flightService.GetSeniorPassenger(methode2);
//Flight f = new Flight();
//f.GetDelay();

//Flight f2 = new Flight()
//{
//    Destination="Tunis1",
//    Departure ="Tunis2",
//    FlightDate = new DateTime(2000, 10, 10),
//    EffectiveArrival = new DateTime(2000,10,10),
//    estimationDuration=20,
//    Comment="Hi Mouna",
//    MyPlane=plane3


//};

//AMContext amc = new AMContext();
////amc.Add(plane3);
//amc.Add(f2);
//Passenger passengerTest = new Passenger()
//{
//    FirstName="Mouna",
//    LastName="AMdouni",
//    BirthDate = new DateTime(2000, 07, 27),
//    PassportNumber = "1234567",
//    EmailAddress = "mouna@gmail.com",
//    FullName = new FullName()
//    {

//        FirstName = "Mouna",
//        LastName = "Amdouni"
//    },
//    TelNumber = "20618005"
//};
//amc.Add(passengerTest);
//Reservation r =new Reservation()
//{
//    Price= 10,
//    Seat="A24",
//    Vip=true,
//    MyFlight=f2,
//    MyPassenger=passengerTest
//};
//amc.Add(r);

//amc.SaveChanges();

AMContext ctxt = new AMContext();
IRepository<Flight> flightRepository = new Repository<Flight>(ctxt);
FlightService flightService1 = new FlightService(flightRepository);
Flight flightQ12 = new Flight()
{
    Comment = "comment",
    Departure = "Tunis",
    Destination = "Canada",
    EffectiveArrival = new DateTime(2023, 09, 01, 12, 0, 0),
    estimationDuration = 60,
    FlightDate = new DateTime(2023, 09, 01, 10, 30, 0)
};
flightService1.Add(flightQ12);
/*
 
 
///
ay objet bel virtual

 Dima
menfassakhch l base
Regenere l'application

 Migration jdida Add-Migration ...
update-database


Discriminator==> bech ta3mel reference bin les instances mte3  classe Fel config ==> ki yabdew 2 classes yeritou men nafs l classe nesta3mle colonne discrimibatrice

one to many ==> representé mapr un cle id
ManyToMany ==> reprsenté par esm les2class

ki nhot l context w nzid fazet l Add ==> l add metzidech lel base ema tzidha lel image 
w bech nsajjel fel base naamel saveChanges()


install packages: f dossier Data

dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore --version 6.0.0
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.9

dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.9


Creation Projet:
1-Domain:entités
2-Services:Interface+Classe
3-Data:AMContext:BD--->
EntityFrameworkCore version 6.0.9.
EntityFrameworkCore.SqlServer version 6.0.9.
EntityFrameworkCore.Tools version 6.0.9
EntityFrameworkCore.Proxies.   // lazyLoading+ virtual dans chaque proprieté sde mappage
** njib fiha les tables lkol   public DbSet<Passenger> Passengers { get; set; } 
**    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // options Builder nhotou fih les parametremte3 l bdd
        {
           
        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb; 
        Initial Catalog = Airport;  
        Integrated Security = true");
           
           


           // base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlaneConfig());
            modelBuilder.ApplyConfiguration(new FlightConfig());
    
         
           

        }
 protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateTime>()
                .HaveColumnType("date");
        }


***** Dossier configurations


4-Console:
EntityFrameworkCore.Design version 6.0.9.

EntityFrameworkCore version 6.0.9.
EntityFrameworkCore.SqlServer version 6.0.9.
EntityFrameworkCore.Design version 6.0.9.
EntityFrameworkCore.Tools version 6.0.9

Add-Migration CommentInFlight
Update-Database


*******************Contrintes


Cle Primaire
[key]
    [MinLength(7, ErrorMessage = "MinLength 7")]
        [MaxLength(7, ErrorMessage = "MaxLength 7")]
*************************Email
        [EmailAddress(ErrorMessage = "une address email invalid .")]
************************Phone
[Phone(ErrorMessage ="phone number")]
********************Obligatoire
   [Required]

*******************Entier Positif
  [Range(0, int.MaxValue, ErrorMessage = "entier positive")]
*******************************Valeur Monetaire
 [DataType(DataType.Currency)]



************************Configurations

   public class PlaneConfig : IEntityTypeConfiguration<Plane>
    {
        public void Configure(EntityTypeBuilder<Plane> builder)
        {
            builder.ToTable("MyPlanes");// nbadel esm table
            builder.Property(p => p.Capacity).HasColumnName("PlaneCapacity"); // nabdel esm colonne
            builder.HasKey(p => p.PlaneId); // nhotlou Primary Key


        }
    }


    public void Configure(EntityTypeBuilder<Flight> builder)
        {

            // relation many to many Flight * -->  * Passenger
            builder
                .HasMany(f => f.passengers)
                .WithMany(p => p.flights);

            // relation Plane 1 --> * Flight
          builder
                .HasOne(f=>f.MyPlane) // relation 1
                .WithMany(p=>p.Flights) // chnowa ba3thetlha 
                .HasPrincipalKey(f=>f.PlaneId) // FK
                .OnDelete(DeleteBehavior.SetNull); // ki tetfassakh avion kol flight tebe3 l avion hedhykja  ywalli null 
        }






// hedhy ki yabda aandi f west classe proprieté de type classe okhra w l classe okhra fiha deja des propretés lezemni nhotelhom contraints 
 public class PassengerConfig : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
           builder
                .OwnsOne(p => p.FullName,full =>
                {
                    full.Property(f => f.FirstName)
                    .HasMaxLength(30)
                    .HasColumnName("Name");
                    full.Property(f => f.LastName)
                    .IsRequired();
                }
            );
        }










/******************* Configuration Classe Porteuse 
   public void Configure(EntityTypeBuilder<Reservation> builder)
        {

            builder
                   .HasOne(r => r.MyPassenger)
                   .WithMany(p => p.Reservations)
                   .HasForeignKey(r => r.PassengerId)
                   .OnDelete(DeleteBehavior.Cascade);
            builder
                 .HasOne(r => r.MyFlight)
                 .WithMany(p => p.Reservations)
                 .HasForeignKey(r=>r.FlightId)
                 .OnDelete(DeleteBehavior.Cascade);
            builder.HasKey(r => new { r.FlightId,r.PassengerId });


        }



Colonne Affiché par Date of Birth:[Dispaly(Name="Date of birth")]




champ obligatoire

 */