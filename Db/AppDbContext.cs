using Microsoft.EntityFrameworkCore;
using Entities;

namespace DB
{
    /// <summary>
    /// Application database context.
    /// </summary>
    public sealed class AppDbContext : DbContext
    {
        /// <summary>
        /// Passenger items.
        /// </summary>
        public DbSet<Passenger> Passengers { get; set; } = null!;

        /// <summary>
        /// Passport items.
        /// </summary>
        public DbSet<Passport> Passports { get; set; } = null!;

        /// <summary>
        /// Flight items.
        /// </summary>
        public DbSet<Flight> Flights { get; set; } = null!;

        /// <summary>
        /// Booking items.
        /// </summary>
        public DbSet<Booking> Bookings { get; set; } = null!;

        /// <summary>
        /// Carrier items.
        /// </summary>
        public DbSet<Carrier> Carriers { get; set; } = null!;

        /// <summary>
        /// Creates AppDBContext object.
        /// </summary>
        public AppDbContext()
        {
            Database.EnsureCreated();
        }

        /// <summary>
        /// Configuring database connection.
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql($"Host=localhost;Port=5432;Database=test;Username=postgres;Password=admin");
        }

        /// <summary>
        /// Fills database with data.
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string[] name = { "Sergey", "Vadim", "Andrey", "Nikolay", "Anton", 
                "Tatjana", "Olga", "Elena", "Alena", "Svetlana" };
            string[] surname = { "Ivanov", "Petrov", "Sergeev", "Trofimov", "Gavrilov", 
                "Dmitrieva", "Orlova", "Mironova", "Anikina", "Lavrova" };
            DateTime[] dateOfBirth = { new(1978, 1, 5, 0, 0, 0, DateTimeKind.Utc), new(1980, 3, 24, 0, 0, 0, DateTimeKind.Utc), 
                new(1995, 12, 19, 0, 0, 0, DateTimeKind.Utc), new(2000, 9, 4, 0, 0, 0, DateTimeKind.Utc), 
                new(1968, 7, 29, 0, 0, 0, DateTimeKind.Utc), new(2001, 2, 3, 0, 0, 0, DateTimeKind.Utc), 
                new(1970, 6, 13, 0, 0, 0, DateTimeKind.Utc), new(1987, 8, 30, 0, 0, 0, DateTimeKind.Utc), 
                new(1993, 5, 20, 0, 0, 0, DateTimeKind.Utc), new(1950, 8, 21, 0, 0, 0, DateTimeKind.Utc) };
            int[] passportNo = { 12567653, 89757804, 12357580, 90632458, 09535672, 95367428, 69237505, 60247438, 32185479, 78309356 };
            DateTime[] dateOfIssue = { new(2000, 1, 5, 0, 0, 0, DateTimeKind.Utc), new(2002, 3, 24, 0, 0, 0, DateTimeKind.Utc), 
                new(2003, 12, 19, 0, 0, 0, DateTimeKind.Utc), new(2000, 9, 4, 0, 0, 0, DateTimeKind.Utc), 
                new(1995, 7, 29, 0, 0, 0, DateTimeKind.Utc), new(2001, 2, 3, 0, 0, 0, DateTimeKind.Utc), 
                new(2019, 6, 13, 0, 0, 0, DateTimeKind.Utc), new(2021, 8, 30, 0, 0, 0, DateTimeKind.Utc), 
                new(2017, 5, 20, 0, 0, 0, DateTimeKind.Utc), new(1999, 8, 21, 0, 0, 0, DateTimeKind.Utc) };
            string[] companyName = { "Aeroflot", "UT Air", "S7", "Nord Wing", "Pobeda", 
                "KLM", "Emirates", "American Airlanes", "Air France", "Alitalia" };
            string[] country = { "Russia", "Russia", "Russia", "Russia", "Russia", "Netherlands", "UAE", "USA", "France", "Italy" };
            string[] city = { "Tomsk", "Moscow", "New York", "London", "Berlin", "Rio", "Dubai", "Rome", "Madrid", "Athens" };
            DateTime[] dateOfFlight = { new(2022, 1, 5, 20, 15, 0, DateTimeKind.Utc), new(2002, 3, 24, 14, 6, 0, DateTimeKind.Utc), 
                new(2003, 12, 19, 3, 55, 0, DateTimeKind.Utc), new(2000, 9, 4, 5, 45, 0, DateTimeKind.Utc), 
                new(1995, 7, 29, 12, 10, 0, DateTimeKind.Utc), new(2001, 2, 3, 17, 30, 0, DateTimeKind.Utc), 
                new(2019, 6, 13, 23, 0, 0, DateTimeKind.Utc), new(2021, 8, 30, 21, 40, 0, DateTimeKind.Utc), 
                new(2017, 5, 20, 11, 55, 0, DateTimeKind.Utc), new(1999, 8, 21, 7, 20, 0, DateTimeKind.Utc) };
            int[] flightNo = { 1256, 8975, 1235, 9063, 0953, 9536, 6923, 6024, 3218, 7830 };
            int[] bookingNo = { 847, 980, 317, 2098, 0185, 0959, 362, 0463, 8763, 9876 };

            List<Carrier> carriers = new();
            Carrier carrier;
            List<Passport> passports = new();
            Passport passport;
            List<Passenger> passengers = new();
            Passenger passenger;
            List<Flight> flights = new();
            Flight flight;
            List<Booking> bookings = new();
            Booking booking;

            for (int i = 0; i < 10; i++)
            {
                passenger = new Passenger
                {
                    Id = i + 1,
                    Surname = surname[i],
                    Name = name[i],
                    DateOfBirth = dateOfBirth[i]
                };
                passengers.Add(passenger);

                carrier = new Carrier
                {
                    Id = i + 1,
                    Name = companyName[i],
                    Country = country[i],
                    PassengerId = i + 1
                };
                carriers.Add(carrier);

                passport = new Passport
                {
                    Id = i + 1,
                    PassportNo = passportNo[i],
                    DateOfIssue = dateOfIssue[i],
                    PassengerId = i + 1
                };
                passports.Add(passport);

                flight = new Flight
                {
                    Id = i + 1,
                    FlightNo = flightNo[i],
                    Departure = city[i],
                    Arrival = city[9 - i],
                    DateTime = dateOfFlight[i],
                    PassengerId = i + 1,
                    CarrierId = i + 1
                };
                flights.Add(flight);

                booking = new Booking
                {
                    Id = i + 1,
                    BookingNo = bookingNo[i],
                    PassengerID = i + 1,
                    PassportID = i + 1,
                    FlightId = i + 1
                };
                bookings.Add(booking);
            }

            modelBuilder.Entity<Carrier>().HasData(carriers);
            modelBuilder.Entity<Passport>().HasData(passports);
            modelBuilder.Entity<Passenger>().HasData(passengers);
            modelBuilder.Entity<Flight>().HasData(flights);
            modelBuilder.Entity<Booking>().HasData(bookings);
        }
    }
}
