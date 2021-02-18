using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product: IEntity
    {
        /*public Product(int ProductId, int CategoryId, string ProductName, decimal UnitPrice, short UnitsInStock)
        {
            this.ProductId = ProductId;
            this.CategoryId = CategoryId;
            this.ProductName = ProductName;
            this.UnitPrice = UnitPrice;
            this.UnitsInStock = UnitsInStock;
        }*/
        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public string ProductName { get; set; }

        public short UnitsInStock { get; set; }

        public decimal UnitPrice { get; set; }
    }
}
