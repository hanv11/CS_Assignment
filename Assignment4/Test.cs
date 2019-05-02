using System;
using System.Collections.Generic;
namespace Assignment4
{
    public class Test
    {
        static List<News> newsList = new List<News>();
        public static void Main(string[] args)
        {
            Console.WriteLine("News Management System");
            ShowMenu();

        }

        public static void ShowMenu()
        {
            Console.WriteLine("1. Insert news");
            Console.WriteLine("2. View list news");
            Console.WriteLine("3. Average list");
            Console.WriteLine("4. Exit");
            string opt = Console.ReadLine();
            switch (opt)
            {
                case "1":
                    InsertNews();
                    ShowMenu();
                    break;
                case "2":
                    ViewNewsList(newsList);
                    ShowMenu();
                    break;
                case "3":
                    AverageRate();
                    ShowMenu();
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Wrong option. Input again");
                    ShowMenu();
                    break;


            }
        }
        public static void InsertNews()
        {
            Console.Write("Enter ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter title: ");
            string title = Console.ReadLine();
            Console.Write("Publish date: ");
            string date = Console.ReadLine();
            Console.Write("Author: ");
            string author = Console.ReadLine();
            Console.Write("Enter content: ");
            string content = Console.ReadLine();
            News news = new News(id, title, date, author, content);
            Console.WriteLine("Enter 3 rates: ");
            news.rateList[0] = Convert.ToInt16(Console.ReadLine());
            news.rateList[1] = Convert.ToInt16(Console.ReadLine());
            news.rateList[2] = Convert.ToInt16(Console.ReadLine());

            newsList.Add(news);

        }
        public static void ViewNewsList(List<News> newsList)
        {
            foreach(News news in newsList)
            {
                news.Display();
                Console.WriteLine("\n");
            }

        }
        public static void AverageRate()
        {
            foreach(News news in newsList)
            {
                news.Calculate();
            }
            ViewNewsList();
        }
    }
}
