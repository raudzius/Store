using API.Entities;

namespace API.Data
{
  public static class DbInitializer
  {
    public static void Initialize(StoreContext context)
    {
      if (context.Products == null) return;
      if (context.Products.Any()) return;
      var products = new List<Product>
      {
        new Product{
            Name="Oxylabs pen, blue",
            Description="A pen with oxylabs logo",
            Price=145,
            PictureUrl="/images/products/oxylabs-pen-blue.jpg",
            Brand="Oxylabs",
            Type="Pen",
            QuantityInStock=1
    },
        new Product{
            Name="Adeo web pen, blue",
            Description="A pen with adeo web logo",
            Price=145,
            PictureUrl="/images/products/adeo-web-pen-blue.jpg",
            Brand="Adeo web",
            Type="Pen",
            QuantityInStock=1
    },
        new Product{
            Name="Grand Partners pen, blue",
            Description="A pen with grand partners logo",
            Price=145,
            PictureUrl="/images/products/grand-partners-pen-blue.jpg",
            Brand="Grand Partners",
            Type="Pen",
            QuantityInStock=1
    },
        new Product{
            Name="Pencil, grey",
            Description="A black pencil with a grey core",
            Price=145,
            PictureUrl="/images/products/pencil-grey.jpg",
            Brand="Colorino",
            Type="Pencil",
            QuantityInStock=1
    },
        new Product{
            Name="Pencil, brown",
            Description="A black pencil with a brown core",
            Price=145,
            PictureUrl="/images/products/pencil-brown.jpg",
            Brand="Colorino",
            Type="Pencil",
            QuantityInStock=1
    },
        new Product{
            Name="Pencil, black",
            Description="A black pencil with a black core",
            Price=145,
            PictureUrl="/images/products/pencil-black.jpg",
            Brand="Colorino",
            Type="Pencil",
            QuantityInStock=1
    },
        new Product{
            Name="Pencil, orange",
            Description="A black pencil with a orange core",
            Price=145,
            PictureUrl="/images/products/pencil-orange.jpg",
            Brand="Colorino",
            Type="Pencil",
            QuantityInStock=1
    },
        new Product{
            Name="Pencil, green",
            Description="A black pencil with a green core",
            Price=145,
            PictureUrl="/images/products/pencil-green.jpg",
            Brand="Colorino",
            Type="Pencil",
            QuantityInStock=1
    },
        new Product{
            Name="Pencil, pink",
            Description="A black pencil with a pink core",
            Price=145,
            PictureUrl="/images/products/pencil-pink.jpg",
            Brand="Colorino",
            Type="Pencil",
            QuantityInStock=1
    },
        new Product{
            Name="Pencil, red",
            Description="A black pencil with a red core",
            Price=145,
            PictureUrl="/images/products/pencil-red.jpg",
            Brand="Colorino",
            Type="Pencil",
            QuantityInStock=1
    },
        new Product{
            Name="Pencil, yellow",
            Description="A black pencil with a yellow core",
            Price=145,
            PictureUrl="/images/products/pencil-yellow.jpg",
            Brand="Colorino",
            Type="Pencil",
            QuantityInStock=1
    },
        new Product{
            Name="Pencil, gold",
            Description="A black pencil with a gold core",
            Price=145,
            PictureUrl="/images/products/pencil-gold.jpg",
            Brand="Colorino",
            Type="Pencil",
            QuantityInStock=1
    },
        new Product{
            Name="Pencil, purple",
            Description="A black pencil with a purple core",
            Price=145,
            PictureUrl="/images/products/pencil-purple.jpg",
            Brand="Colorino",
            Type="Pencil",
            QuantityInStock=1
    },
      };

      foreach (var product in products)
      {
        context.Add(product);
      }

      context.SaveChanges();
    }
  }
}