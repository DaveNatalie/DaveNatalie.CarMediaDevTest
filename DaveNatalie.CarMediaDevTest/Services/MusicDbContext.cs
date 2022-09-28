#nullable disable
using DaveNatalie.CarMediaDevTest.Models;
using Microsoft.EntityFrameworkCore;

namespace DaveNatalie.CarMediaDevTest.Services
{
    public class MusicDbContext : DbContext
    {
        public MusicDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<Album> Albums { get; set; }

        public DbSet<Song> Songs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Artist>().HasData(new Artist("Muse") { Id = 1 });
            modelBuilder.Entity<Artist>().HasData(new Artist("Duran Duran") { Id = 2 });
            modelBuilder.Entity<Artist>().HasData(new Artist("Van Halen") { Id = 3 });

            modelBuilder.Entity<Album>().HasData(new Album(1, "Drones") { Id = 1, YearReleased = 2015 });
            modelBuilder.Entity<Album>().HasData(new Album(1, "Origin of Symmetry") { Id = 2, YearReleased = 2001 });
            modelBuilder.Entity<Album>().HasData(new Album(2, "Rio") { Id = 3, YearReleased = 1982 });
            modelBuilder.Entity<Album>().HasData(new Album(3, "1984") { Id = 4, YearReleased = 1984 });

            //Muse - Drones
            modelBuilder.Entity<Song>().HasData(new Song(1, "Dead Inside") { Id = 1, Track = 1 });
            modelBuilder.Entity<Song>().HasData(new Song(1, "Drill Sargeant") { Id = 2, Track = 2 });
            modelBuilder.Entity<Song>().HasData(new Song(1, "Psycho") { Id = 3, Track = 3 });
            modelBuilder.Entity<Song>().HasData(new Song(1, "Mercy") { Id = 4, Track = 4 });
            modelBuilder.Entity<Song>().HasData(new Song(1, "Reapers") { Id = 5, Track = 5 });
            modelBuilder.Entity<Song>().HasData(new Song(1, "The Handler") { Id = 6, Track = 6 });
            modelBuilder.Entity<Song>().HasData(new Song(1, "JFK") { Id = 7, Track = 7 });
            modelBuilder.Entity<Song>().HasData(new Song(1, "Defector") { Id = 8, Track = 8 });
            modelBuilder.Entity<Song>().HasData(new Song(1, "Revolt") { Id = 9, Track = 9 });
            modelBuilder.Entity<Song>().HasData(new Song(1, "Aftermath") { Id = 10, Track = 10 });
            modelBuilder.Entity<Song>().HasData(new Song(1, "The Globalist") { Id = 11, Track = 11 });
            modelBuilder.Entity<Song>().HasData(new Song(1, "Drones") { Id = 12, Track = 12 });

            //Muse - Origin of Symmetry
            modelBuilder.Entity<Song>().HasData(new Song(2, "Intro") { Id = 13, Track = 1 });
            modelBuilder.Entity<Song>().HasData(new Song(2, "Apocolypse Please") { Id = 14, Track = 2 });
            modelBuilder.Entity<Song>().HasData(new Song(2, "Time is Running Out") { Id = 15, Track = 3 });
            modelBuilder.Entity<Song>().HasData(new Song(2, "Sing for Absolution") { Id = 16, Track = 4 });
            modelBuilder.Entity<Song>().HasData(new Song(2, "Stokholm Syndrome") { Id = 17, Track = 5 });
            modelBuilder.Entity<Song>().HasData(new Song(2, "Falling Away With you") { Id = 18, Track = 6 });
            modelBuilder.Entity<Song>().HasData(new Song(2, "Interlude") { Id = 19, Track = 7 });
            modelBuilder.Entity<Song>().HasData(new Song(2, "Hysteria") { Id = 20, Track = 8 });
            modelBuilder.Entity<Song>().HasData(new Song(2, "Blackout") { Id = 21, Track = 9 });
            modelBuilder.Entity<Song>().HasData(new Song(2, "Butterflies and Hurricanes") { Id = 22, Track = 10 });
            modelBuilder.Entity<Song>().HasData(new Song(2, "The Small Print") { Id = 23, Track = 11 });
            modelBuilder.Entity<Song>().HasData(new Song(2, "Endlessly") { Id = 24, Track = 12 });
            modelBuilder.Entity<Song>().HasData(new Song(2, "Thoughts of a Dying Athiest") { Id = 25, Track = 13 });
            modelBuilder.Entity<Song>().HasData(new Song(2, "Ruled by Secrecy") { Id = 26, Track = 14 });
            modelBuilder.Entity<Song>().HasData(new Song(2, "Fury") { Id = 27, Track = 15 });


            //Duran Duran - Rio
            modelBuilder.Entity<Song>().HasData(new Song(3, "Rio") { Id = 28, Track = 1 });
            modelBuilder.Entity<Song>().HasData(new Song(3, "My Own Way") { Id = 29, Track = 2 });
            modelBuilder.Entity<Song>().HasData(new Song(3, "Lonely in Your Nightmare") { Id = 30, Track = 3 });
            modelBuilder.Entity<Song>().HasData(new Song(3, "Hungry Like the Wolf") { Id = 31, Track = 4 });
            modelBuilder.Entity<Song>().HasData(new Song(3, "Hold Back the Rain") { Id = 32, Track = 5 });
            modelBuilder.Entity<Song>().HasData(new Song(3, "New Religion") { Id = 33, Track = 6 });
            modelBuilder.Entity<Song>().HasData(new Song(3, "Last Chance on the Stairway") { Id = 34, Track = 7 });
            modelBuilder.Entity<Song>().HasData(new Song(3, "Save a Prayer") { Id = 35, Track = 8 });
            modelBuilder.Entity<Song>().HasData(new Song(3, "The Chauffeur") { Id = 36, Track = 9 });

            //Van Halen - 1984
            modelBuilder.Entity<Song>().HasData(new Song(4, "1984") { Id = 37, Track = 1 });
            modelBuilder.Entity<Song>().HasData(new Song(4, "Jump") { Id = 38, Track = 2 });
            modelBuilder.Entity<Song>().HasData(new Song(4, "Panama") { Id = 39, Track = 3 });
            modelBuilder.Entity<Song>().HasData(new Song(4, "Top Jimmy") { Id = 40, Track = 4 });
            modelBuilder.Entity<Song>().HasData(new Song(4, "Drop Dead Legs") { Id = 41, Track = 5 });
            modelBuilder.Entity<Song>().HasData(new Song(4, "Hot for Teacher") { Id = 42, Track = 6 });
            modelBuilder.Entity<Song>().HasData(new Song(4, "I'll Wait") { Id = 43, Track = 7 });
            modelBuilder.Entity<Song>().HasData(new Song(4, "Girl Gone Bad") { Id = 44, Track = 8 });
            modelBuilder.Entity<Song>().HasData(new Song(4, "House of Pain") { Id = 45, Track = 9 });

        }

    }
}
