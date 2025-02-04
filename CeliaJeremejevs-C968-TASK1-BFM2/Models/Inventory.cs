using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Models
{
    public class Inventory
    {
        public BindingList<Product> Products
        {
            get; set;
        }

        public BindingList<Part> AllParts
        {
            get; set;
        }

        public Inventory()
        {
            AllParts = new BindingList<Part>();
            Products = new BindingList<Product>();
        }

        public void addProduct(Product product)
        {
            Products.Add(product);
        }

        public bool removeProduct(int productID)
        {
            try
            {
                var productIndex = this.Products.ToList().FindIndex(x => x.ProductID == productID);

                Products.RemoveAt(productIndex);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public Product lookupProduct(int productID)
        {
            return Products.Where(x => x.ProductID == productID).FirstOrDefault();
        }

        public void updateProduct(int productID, Product updatedProduct)
        {
            int productIndex = Products.ToList().FindIndex(part => part.ProductID == productID);
            if (productIndex == -1)
                throw new Exception($"There is no product with ID {productID}");

            updatedProduct.ProductID = productID;
            Products[productIndex] = updatedProduct;
        }

        public void addPart(Part part)
        {
            AllParts.Add(part);
        }

        public bool deletePart(Part part)
        {
            return this.AllParts.Remove(part);
        }

        public Part lookupPart(int partID)
        {
            return AllParts.Where(x => x.PartID == partID).FirstOrDefault();
        }

        public void updatePart(int partID, Part updatedPart)
        {
            int partIndex = AllParts.ToList().FindIndex(part => part.PartID == partID);
            if (partIndex == -1)
                throw new Exception($"There is no part with ID {partID}");

            updatedPart.PartID = partID;
            AllParts[partIndex] = updatedPart;
        }
    }
}