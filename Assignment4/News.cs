using System;
namespace Assignment4
{
    public class News : INews
    {

        private int id;
        private string title;
        private string publishDate;
        private string author;
        private string content;
        private float averageRate;

        public int[] rateList = new int[3];

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                this.id = value;
            }
        }
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                this.title = value;
            }
        }
        public string PublishDate
        {
            get
            {
                return publishDate;
            }
            set
            {
                this.publishDate = value;
            }
        }
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                this.author = value;
            }
        }
        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                this.content = value;
            }
        }
        public float AverageRate
        {
            get
            {
                return averageRate;
            }
       
        }
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
