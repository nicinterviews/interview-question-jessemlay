using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Notown.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notown.Data
{
  public class SeedData
  {
    public static void Intialize(IApplicationBuilder app)
    {
      using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
      {
        var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
        context.Database.EnsureCreated();


        //Look for any Musicians
       

        var musicians = SeedData.GetMusicians(context).ToArray();
        context.Musicians.AddRange(musicians);
        context.SaveChanges();

        var addresses = SeedData.GetAddresses(context).ToArray();
        context.Addresses.AddRange(addresses);
        context.SaveChanges();

        var albums = SeedData.GetAlbums(context).ToArray();
        context.Albums.AddRange(albums);
        context.SaveChanges();

        var songs = SeedData.GetSongs(context).ToArray();
        context.Songs.AddRange(songs);
        context.SaveChanges();

        var instruments = SeedData.GetInstruments(context).ToArray();
        context.Instruments.AddRange(instruments);
        context.SaveChanges();
      }
    }

    public static List<Musician> GetMusicians(ApplicationDbContext context)
    {
      List<Musician> musicians = new List<Musician>
      {
        new Musician
        {
          Name = "John Smith",
          SSN = "450-999-0550",
          Address = context.Addresses.Find(1)

        }
      };

      return musicians;
    }

    public static List<Address> GetAddresses(ApplicationDbContext context)
    {
      List<Address> addresses = new List<Address>
      {
        new Address
        {
          Street = "1001 Nowhere Drive",
          City = "Santa Fe",
          State = "New Mexico",
          Zip = 87501,
          PhoneNumber = "505-567-0000"

        }
      };

      return addresses;
    }

    public static List<Album> GetAlbums(ApplicationDbContext context)
    {
      List<Album> albums = new List<Album>
      {
        new Album
        {
          AlbumIdentifier = 100,
          CopyRightDate = DateTime.Today,
          Producer = context.Musicians.Find(1),
          Format = "CD",
          ProducerName = context.Musicians.Find(1).Name,
          Title = "Truely Awesome"
          
        }
      };

      return albums;
    }

    public static List<Song> GetSongs(ApplicationDbContext context)
    {
      List<Song> songs = new List<Song>
      {
        new Song
        {
          Author = "the author",
          Title = "Way Way Cooler",        
        }
      };

      return songs;
    }

    public static List<Instrument> GetInstruments(ApplicationDbContext context)
    {
      List<Instrument> instruments = new List<Instrument>
      {
        new Instrument
        {
          MusicalKey = "D",
          Name = "Flute"
        },
        new Instrument
        {
          MusicalKey = "C#",
          Name = "Guitar"
        }
      };

      return instruments;
    }


  }
}
