using System;

namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string inputTitle = input[0];
            string inputContent = input[1];
            string inputAuthor = input[2];
            Article article = new Article(inputTitle,inputContent,inputAuthor);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(": ",StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "Edit")
                {
                    article.Edit(command[1]);
                }
                else if (command[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(command[1]);
                }
                else
                {
                    article.Rename(command[1]);
                }
            }
            Console.WriteLine(article.ToString());

        }

        public class Article
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public Article(string title, string content, string author)
            {
                this.Title = title;
                this.Content = content;
                this.Author = author;
            }

            public void Edit(string content)
            {
                this.Content = content;
            }

            public void ChangeAuthor (string author)
            {
                this.Author = author;
            }

            public void Rename (string title)
            {
                this.Title = title;
            }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
    }
}
