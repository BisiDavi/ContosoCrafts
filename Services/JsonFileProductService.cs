using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using firstWebApp.Models;
using Microsoft.AspNetCore.Hosting;

namespace firstWebApp.Services
{
  public class JsonFileProductService
  {
    public JsonFileProductService(IWebHostEnvironment webHostEnvironment)
    {
      WebHostEnvironment = webHostEnvironment;
    }

    public IWebHostEnvironment WebHostEnvironment { get; }

    private string JsonFileName
    {
      get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "products.json"); }
    }
    public IEnumerable<Product> GetProducts()
    {
      using(var jsonFileReader = File.OpenText(JsonFileName))
      {
        return JsonSerializer.Deserialize<Product[]>(jsonFileReader.ReadToEnd(),
            new JsonSerializerOptions
            {
              PropertyNameCaseInsensitive = true
            });
      }
    }
    // public void AddRating(string productId, int rating)
    // {
    //   var products = GetProducts();
    //   //LINQ
    //   var query = products.first(x => x.Id == productId);

    //   if(query.Ratings == null)
    //   {
    //     query.Ratings = new int[] {rating};
    //   }else
    //   {
    //       var ratings = query.Ratings.ToList();
    //       ratings.Add(rating);
    //       query.Ratings = rating.ToArray();
    //   }
    //   using(var outputStream = File.OpenWrite(JsonFileName))
    //   {
    //     JsonSerializer.serialize<IEnumerable<Product>>(
    //       new Utf8JsonWriter(putputStream, new JsonWriterOptions
    //       {
    //         SkipValidation = true,
    //         Indented = true
    //       }),
    //       products 
    //     );
    //   };
    // }
  }
}