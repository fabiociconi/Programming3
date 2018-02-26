using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_2
{
    class ProductItems
    {

        private string name;
        private string category;
        private double price;
        private int quantity;

        
        /// <summary>
        /// default constructor
        /// </summary>
        public ProductItems()
        {
           
        }
      
        public ProductItems(string name, string category, double price)
        {
            this.category = category;
            this.name = name;
            this.price = price;
            

        }
        public ProductItems(string name, string category, double price, int quantity)
        {
            this.category = category;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
        /// <summary>
        /// Getters and Setters
        /// </summary>
        public string Category { get => category; set => category = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
 

    }
}
