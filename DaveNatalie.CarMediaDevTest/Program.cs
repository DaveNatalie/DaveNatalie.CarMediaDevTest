using DaveNatalie.CarMediaDevTest.Models;
using DaveNatalie.CarMediaDevTest.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;


//Certain Features have been intentionally left out, as they would increase the scope of the excercise
//These features include

// 1. Authentication
// 2. Data paging
// 3. Data selection (determining which data to include with each request)
// 4. Api returns Db Models. In a real application, I would likely create a seperate Api models
// 5. When I started this project, I didn't realize that Model validation wasn't built into minimal APIs. As such, model errors will return Http 500


//Some Assumptions that I made. These are things that could easily be changed based on business rules

// 1. Every song must belong to one, and only one, album
// 2. Every album must belong to one, and only one, artist
// 3. When creating or modifyfing an artist, you cannot create ablums/songs at the same time
// 4. Timestamps are stored in UTC
// 5. Create and Update endpoints return the artist model, rather than just Http status codes 

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(swaggerGen =>
{
    swaggerGen.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo()
    {
        Title = "Car Media Dev Test Api",
        Description = "Designed to demonstrate a REST api implementation for Car Media 2.0"
    });
});

builder.Services.AddDbContext<MusicDbContext>(context =>
{
    context.UseSqlite(builder.Configuration["Database:ConnectionString"]);
});


var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

    app.UseSwaggerUI(swaggerUi =>
    {
        swaggerUi.EnableTryItOutByDefault();
        swaggerUi.DocumentTitle = "Car Media Dev Test Api - Swagger";
    });
}

app.UseHttpsRedirection();

app.MapGet("/artist", async ([FromServices] MusicDbContext db) =>
{
    var artists = await db.Artists
        .Include(y => y.Albums)
        .ThenInclude(y => y.Songs)
        .ToListAsync();

    return artists;
})
.WithName("GetArtists")
.WithDisplayName("Get Artists")
.Produces<IEnumerable<Artist>>();

app.MapGet("/artist/{id}", async ([FromServices] MusicDbContext db, [FromRoute] long id) =>
{
    var artist = await db.Artists
        .Include(y => y.Albums)
        .ThenInclude(y => y.Songs)
        .FirstOrDefaultAsync(x => x.Id == id);

    return artist;
})
.WithName("GetArtistById")
.WithDisplayName("Get Artist")
.Produces<Artist>();


app.MapPost("/artist/", async ([FromServices] MusicDbContext db, [FromBody] Artist artist) =>
{

    //If the client specifies these values, we want to reset them back to defaults
    artist.Id = default;
    artist.Created = DateTimeOffset.UtcNow;
    artist.LastModified = null;

    //If the client specifies Albums in the request body, we will ignore them when creating the artist
    artist.Albums.Clear();

    db.Artists.Add(artist);
    await db.SaveChangesAsync();

    return Results.Created($"/artist/{artist.Id}", artist);
})
.WithName("CreateArtist")
.WithDisplayName("Create Artist")
.Produces<Artist>(201);


app.MapPut("/artist/{id}", async ([FromServices] MusicDbContext db, [FromRoute] long id, [FromBody] Artist artist) =>
{
    //Prefer to use the Id specified in the route, over the id supplied in the request body
    artist.Id = id;
    artist.LastModified = DateTimeOffset.Now;

    //If the client specifies Albums in the request body, we will ignore them when updating the artist
    artist.Albums.Clear();


    db.Artists.Attach(artist);
    db.Entry(artist).State = EntityState.Modified;
    db.Entry(artist).Property(x => x.Created).IsModified = false;
    db.Entry(artist).Collection(x => x.Albums).IsModified = false;

    await db.SaveChangesAsync();
    return Results.Ok(artist);
})
.WithName("UpdateArtist")
.WithDisplayName("Update Artist")
.Produces<Artist>();


app.MapDelete("/artist/{id}", async ([FromServices] MusicDbContext db, [FromRoute] long id) =>
{

    var existingArtist = await db.Artists.FindAsync(id);
    if (existingArtist == null)
    {
        return Results.NotFound();
    }

    db.Artists.Remove(existingArtist);
    await db.SaveChangesAsync();
    return Results.Ok();
})
.WithName("DeleteArtist")
.WithDisplayName("Delete Artist")
.Produces((int)HttpStatusCode.OK)
.Produces((int)HttpStatusCode.NotFound);



//Ensure the database gets created at startup if it does not already exist
var serviceScopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
using (var serviceScope = serviceScopeFactory.CreateScope())
{
    var dbContext = serviceScope.ServiceProvider.GetRequiredService<MusicDbContext>();
    dbContext.Database.EnsureCreated();
}

app.Run();