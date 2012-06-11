namespace Scenarios.Controllers
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Web.Http.Data.EntityFramework;
    using Sample.Models;

    public partial class InventoryController : DbDataController<InventoryContext>
    {
        static TimeSpan SimulatedLatency = TimeSpan.FromMilliseconds(500);

        public IQueryable<Product> GetProducts()
        {
            return this.DbContext.Products.OrderByDescending(p => p.Name);
        }

        public void InsertProduct(Product product)
        {
            Thread.Sleep(SimulatedLatency);
            product.ID = Guid.NewGuid().ToString();

            this.InsertEntity(product);
        }

        public void UpdateProduct(Product product)
        {
            Thread.Sleep(SimulatedLatency);
            this.UpdateEntity(product);
        }

        public void DeleteProduct(Product product)
        {
            Thread.Sleep(SimulatedLatency);
            this.DeleteEntity(product);
        }
    }
}