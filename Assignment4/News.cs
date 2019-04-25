using System;
namespace Assignment4
{
    public class News : INews
    {

        public int id;
        public string title;
        public string publishDate;
        public string author;
        public string content;
        public float averageRate;

        public int[] rateList = new int[3];


        public News()
        {
        }

        public News(int id, string title, string publishDate, string author, string content)
        {
            this.id = id;
            this.title = title;
            this.publishDate = publishDate;
            this.author = author;
            this.content = content;

        }

        public void Display()
        {

            Console.WriteLine("ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("PublishDate: " + publishDate);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Content: " + content);
            Console.WriteLine("Average Rate: " + averageRate);
        }
        public void Calculate()
        {
            averageRate = (float)((this.rateList[0] + this.rateList[1] + this.rateList[2]) / 3.0);
        }


    }
}
