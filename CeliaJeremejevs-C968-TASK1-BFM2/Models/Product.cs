﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int InStock { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }
        public BindingList<Part> AssociatedParts
        {
            get; set;
        }

        public Product()
        {
            AssociatedParts = new BindingList<Part>();
        }

        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int partID)
        {
            try
            {
                int partIndex = AssociatedParts.ToList().FindIndex(part => part.PartID == partID);
                this.AssociatedParts.RemoveAt(partIndex);
                return true;
            }
            catch { 
                return false; 
            }
        }

        public Part lookupAssociatedPart(int partID)
        {
            return AssociatedParts.Where(x => x.PartID == partID).FirstOrDefault();
        }
    }
}
