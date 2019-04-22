using System;
using System.Collections.Generic;
namespace Lap_Ass2
{
     class Product
    {
        string name;
        int id;
        float price;
        int qty;
        string image;
        string desc;
        List<string> gallery = new List<string>();


        public Product()
        {

        }

        public Product(int id, string name, float price, int qty, string image, string desc, List<string> list)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
            for (int i = 0; i < list.Count && i < 10; i++)
            {
                gallery.Add(list[i]);
            }

        }
        public void getInfo()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Quanty: " + qty);
            Console.WriteLine("Image: " + image);
            Console.WriteLine("Description: " + desc);
        }
        public void GetQtyInfo()
        {
            if (this.qty > 0)
            {
                Console.WriteLine("In Stock: " + qty);
            }
            else
            {
                Console.WriteLine("Out of stock");
            }
        }
        public void AddToGallery(string img)
        {
            if (gallery.Count < 10)
            {
                gallery.Add(img);
            }
            else
            {
                Console.WriteLine("Gallery is full. ");
            }
        }
        public void RemoveFromGallery()
        {
            Console.WriteLine("Remove at? ");
            int i = Int16.Parse(Console.ReadLine());
            gallery.RemoveAt(i);
        }

    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("item1");
            Product product = new Product(1, "IphoneX", (float)5.5, 5, "image1", "hot", list);
            product.getInfo();
        }
    }
}
