using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifiers
{
    internal class product
    {
            private String name;
            private double price;
            private int quantity;

            // A constructor that takes the name, price and quantity as parameters
            public product(String name, double price, int quantity)
            {
                this.name = name;
                this.price = price;
                this.quantity = quantity;
            }

            public void setName(String newName)
            {
                this.name = newName;
            }

            public void setPrice(double newPrice)
            {
                this.price = newPrice;
            }

            public void setQuantity(int newQuantity)
            {
                this.quantity = newQuantity;
            }

            public String getName()
            {
                return name;
            }

            public double getPrice()
            {
                return price;
            }

            public int getQuantity()
            {
                return quantity;
            }
            public double getDiscountedPrice(double percentage)
            {
                double discount = price * percentage / 100;
                double discountedPrice = price - discount;
                return discountedPrice;
            }
    }
}
