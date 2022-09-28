using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DaveNatalie.CarMediaDevTest.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Created", "LastModified", "Name" },
                values: new object[] { 1L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(2772), new TimeSpan(0, -4, 0, 0, 0)), null, "Muse" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Created", "LastModified", "Name" },
                values: new object[] { 2L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(2857), new TimeSpan(0, -4, 0, 0, 0)), null, "Duran Duran" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Created", "LastModified", "Name" },
                values: new object[] { 3L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(2869), new TimeSpan(0, -4, 0, 0, 0)), null, "Van Halen" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "ArtistId", "Created", "LastModified", "Name", "YearReleased" },
                values: new object[] { 1L, 1L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(2883), new TimeSpan(0, -4, 0, 0, 0)), null, "Drones", 2015 });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "ArtistId", "Created", "LastModified", "Name", "YearReleased" },
                values: new object[] { 2L, 1L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(2900), new TimeSpan(0, -4, 0, 0, 0)), null, "Origin of Symmetry", 2001 });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "ArtistId", "Created", "LastModified", "Name", "YearReleased" },
                values: new object[] { 3L, 2L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(2912), new TimeSpan(0, -4, 0, 0, 0)), null, "Rio", 1982 });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "ArtistId", "Created", "LastModified", "Name", "YearReleased" },
                values: new object[] { 4L, 3L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(2924), new TimeSpan(0, -4, 0, 0, 0)), null, "1984", 1984 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 1L, 1L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(2937), new TimeSpan(0, -4, 0, 0, 0)), null, "Dead Inside", 1 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 2L, 1L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(2951), new TimeSpan(0, -4, 0, 0, 0)), null, "Drill Sargeant", 2 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 3L, 1L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(2962), new TimeSpan(0, -4, 0, 0, 0)), null, "Psycho", 3 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 4L, 1L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(2974), new TimeSpan(0, -4, 0, 0, 0)), null, "Mercy", 4 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 5L, 1L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(2986), new TimeSpan(0, -4, 0, 0, 0)), null, "Reapers", 5 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 6L, 1L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3000), new TimeSpan(0, -4, 0, 0, 0)), null, "The Handler", 6 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 7L, 1L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3011), new TimeSpan(0, -4, 0, 0, 0)), null, "JFK", 7 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 8L, 1L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3023), new TimeSpan(0, -4, 0, 0, 0)), null, "Defector", 8 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 9L, 1L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3034), new TimeSpan(0, -4, 0, 0, 0)), null, "Revolt", 9 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 10L, 1L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3047), new TimeSpan(0, -4, 0, 0, 0)), null, "Aftermath", 10 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 11L, 1L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3059), new TimeSpan(0, -4, 0, 0, 0)), null, "The Globalist", 11 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 12L, 1L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3070), new TimeSpan(0, -4, 0, 0, 0)), null, "Drones", 12 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 13L, 2L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3156), new TimeSpan(0, -4, 0, 0, 0)), null, "Intro", 1 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 14L, 2L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3169), new TimeSpan(0, -4, 0, 0, 0)), null, "Apocolypse Please", 2 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 15L, 2L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3180), new TimeSpan(0, -4, 0, 0, 0)), null, "Time is Running Out", 3 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 16L, 2L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3192), new TimeSpan(0, -4, 0, 0, 0)), null, "Sing for Absolution", 4 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 17L, 2L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3203), new TimeSpan(0, -4, 0, 0, 0)), null, "Stokholm Syndrome", 5 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 18L, 2L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3216), new TimeSpan(0, -4, 0, 0, 0)), null, "Falling Away With you", 6 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 19L, 2L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3228), new TimeSpan(0, -4, 0, 0, 0)), null, "Interlude", 7 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 20L, 2L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3240), new TimeSpan(0, -4, 0, 0, 0)), null, "Hysteria", 8 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 21L, 2L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3251), new TimeSpan(0, -4, 0, 0, 0)), null, "Blackout", 9 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 22L, 2L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3263), new TimeSpan(0, -4, 0, 0, 0)), null, "Butterflies and Hurricanes", 10 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 23L, 2L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3274), new TimeSpan(0, -4, 0, 0, 0)), null, "The Small Print", 11 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 24L, 2L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3286), new TimeSpan(0, -4, 0, 0, 0)), null, "Endlessly", 12 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 25L, 2L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3298), new TimeSpan(0, -4, 0, 0, 0)), null, "Thoughts of a Dying Athiest", 13 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 26L, 2L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3309), new TimeSpan(0, -4, 0, 0, 0)), null, "Ruled by Secrecy", 14 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 27L, 2L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3321), new TimeSpan(0, -4, 0, 0, 0)), null, "Fury", 15 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 28L, 3L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3332), new TimeSpan(0, -4, 0, 0, 0)), null, "Rio", 1 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 29L, 3L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3344), new TimeSpan(0, -4, 0, 0, 0)), null, "My Own Way", 2 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 30L, 3L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3356), new TimeSpan(0, -4, 0, 0, 0)), null, "Lonely in Your Nightmare", 3 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 31L, 3L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3367), new TimeSpan(0, -4, 0, 0, 0)), null, "Hungry Like the Wolf", 4 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 32L, 3L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3379), new TimeSpan(0, -4, 0, 0, 0)), null, "Hold Back the Rain", 5 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 33L, 3L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3391), new TimeSpan(0, -4, 0, 0, 0)), null, "New Religion", 6 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 34L, 3L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3404), new TimeSpan(0, -4, 0, 0, 0)), null, "Last Chance on the Stairway", 7 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 35L, 3L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3416), new TimeSpan(0, -4, 0, 0, 0)), null, "Save a Prayer", 8 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 36L, 3L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3427), new TimeSpan(0, -4, 0, 0, 0)), null, "The Chauffeur", 9 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 37L, 4L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3475), new TimeSpan(0, -4, 0, 0, 0)), null, "1984", 1 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 38L, 4L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3488), new TimeSpan(0, -4, 0, 0, 0)), null, "Jump", 2 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 39L, 4L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3500), new TimeSpan(0, -4, 0, 0, 0)), null, "Panama", 3 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 40L, 4L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3511), new TimeSpan(0, -4, 0, 0, 0)), null, "Top Jimmy", 4 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 41L, 4L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3523), new TimeSpan(0, -4, 0, 0, 0)), null, "Drop Dead Legs", 5 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 42L, 4L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3535), new TimeSpan(0, -4, 0, 0, 0)), null, "Hot for Teacher", 6 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 43L, 4L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3546), new TimeSpan(0, -4, 0, 0, 0)), null, "I'll Wait", 7 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 44L, 4L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3557), new TimeSpan(0, -4, 0, 0, 0)), null, "Girl Gone Bad", 8 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "Created", "LastModified", "Name", "Track" },
                values: new object[] { 45L, 4L, new DateTimeOffset(new DateTime(2022, 9, 28, 16, 24, 43, 499, DateTimeKind.Unspecified).AddTicks(3569), new TimeSpan(0, -4, 0, 0, 0)), null, "House of Pain", 9 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "Id",
                keyValue: 3L);
        }
    }
}
