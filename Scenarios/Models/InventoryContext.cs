using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web;

namespace Sample.Models
{
    public class InventoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public InventoryContext()
            : base("name=InventoryContext")
        {
                Database.SetInitializer<InventoryContext>(new InventoryContextInitializer());
        }
    }

    public class InventoryContextInitializer : DropCreateDatabaseAlways<InventoryContext>
    {
        protected override void Seed(InventoryContext context)
        {
            var products = new List<Product>
            {
                new Product { ID = "1", Name = "EOS Rebel T3i 18 MP CMOS Digital SLR Camera and DIGIC 4 Imaging with EF-S 18-55mm f/3.5-5.6 IS Lens", Manufacturer = "Canon", Price = 849, Rating = 5, ProductDescription = "The EOS Rebel T3i has an 18.0 Megapixel CMOS (Complementary Metal Oxide Semiconductor) sensor that captures images with exceptional clarity and tonal range and offers more than enough resolution for big enlargements or crops." },
                new Product { ID = "2", Name = "D5100 16.2MP CMOS Digital SLR Camera with 18-55mm f/3.5-5.6 AF-S DX VR Nikkor Zoom Lens", Manufacturer = "Nikon", Price = 794, Rating = 4, ProductDescription = "The Nikon D5100 offers a host of new photographic and video tools that deliver superior performance and exceptional image quality with surprising versatility. " },
                new Product { ID = "3", Name = "D3100 14.2MP Digital SLR Camera with 18-55mm f/3.5-5.6 AF-S DX VR Nikkor Zoom Lens", Manufacturer = "Nikon", Price = 599, Rating = 3, ProductDescription = "Nikon's affordable, compact and lightweight D3100 digital SLR features a high-resolution 14-megapixel CMOS DX sensor, high-quality 3x NIKKOR 18-55mm VR image stabilization zoom lens and intuitive onboard assistance including the learn-as-you grow Guide Mode." },
                new Product { ID = "4", Name = "EOS Rebel T3 12.2 MP CMOS Digital SLR with 18-55mm IS II Lens and EOS HD Movie Mode", Manufacturer = "Canon", Price = 549, Rating = 4, ProductDescription = "Canon’s CMOS (Complementary Metal Oxide Semiconductor) sensor captures images with exceptional clarity and tonal range, and offers the most pixels in its class." },
                new Product { ID = "5", Name = "EOS Rebel T2i 18 MP CMOS APS-C Digital SLR Camera with 3.0-Inch LCD and EF-S 18-55mm f/3.5-5.6 IS Lens", Manufacturer = "Canon", Price = 749, Rating = 2, ProductDescription = "The new flagship of the EOS Rebel line, Canon EOS Rebel T2i brings professional EOS features into an easy to use, lightweight digital SLR that's a joy to use." },
                new Product { ID = "6", Name = "D7000 16.2MP DX-Format CMOS Digital SLR with 3.0-Inch LCD (Body Only)", Manufacturer = "Nikon", Price = 1199, Rating = 0, ProductDescription = "Meet the new Nikon D7000, a camera ready to go wherever your photography or cinematography takes you." },
                new Product { ID = "7", Name = "EOS 60D 18 MP CMOS Digital SLR Camera with 3.0-Inch LCD and 18-135mm f/3.5-5.6 IS UD Standard Zoom Lens", Manufacturer = "Canon", Price = 1199, Rating = 5, ProductDescription = "With the new EOS 60D DSLR, Canon gives the photo enthusiast a powerful tool fostering creativity, with better image quality, more advanced features and automatic and in-camera technologies for ease-of-use." },
                new Product { ID = "8", Name = "D3000 10.2MP Digital SLR Camera with 18-55mm f/3.5-5.6G AF-S DX VR Nikkor Zoom Lens", Manufacturer = "Nikon", Price = 443, Rating = 3, ProductDescription = "Breathtaking digital SLR image quality and easy operation highlight the 10.2-megapixel D3000--Nikon's friendliest DSLR ever." },
                new Product { ID = "9", Name = "D7000 16.2MP DX-Format CMOS Digital SLR with 3.0-Inch LCD and 18-105mm f/3.5-5.6 AF-S DX VR ED Nikkor Lens", Manufacturer = "Nikon", Price = 1429, Rating = 3, ProductDescription = "Meet the new Nikon D7000, a camera ready to go wherever your photography or cinematography takes you." },
                new Product { ID = "10", Name = "EOS 60D 18 MP CMOS Digital SLR Camera with 3.0-Inch LCD (Body Only)", Manufacturer = "Canon", Price = 899, Rating = 2, ProductDescription = "With the new EOS 60D DSLR, Canon gives the photo enthusiast a powerful tool fostering creativity, with better image quality, more advanced features and automatic and in-camera technologies for ease-of-use." }
            };

            products.ForEach(p => context.Products.Add(p));
        }
    }
}