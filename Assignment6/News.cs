using System;

namespace Assignment6
{
    class News: INews
    {
        private int id;
        private string title;
        private string publishDate;
        private string author;
        private string content;
        private float averageRate;

        int[] rateList = new int[3];
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
                return title;
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
   

        public void Display()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("PublishDate: " + publishDate);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Content: " + content);
        }
        public void Calculate()
        {
            averageRate = 0;
            for(int i = 0; i < rateList.Length; i++)
            {
                averageRate += rateList[i];
            }
            averageRate = averageRate / rateList.Length;
        }
    }
}
