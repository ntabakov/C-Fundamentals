using System;
using System.Collections.Generic;

namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<Article> storeArticles = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                Article article = new Article();

                article.Title = input[0];
                article.Content = input[1];
                article.Author = input[2];
                storeArticles.Add(article);
            }
            string command = Console.ReadLine();

            if (command == "title")
            {
                storeArticles.Sort();
            }
            Console.WriteLine(Environment.NewLine,storeArticles);

        }

        public class Article
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            


            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
    }
}
