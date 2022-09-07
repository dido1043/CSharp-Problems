using System;
using System.Collections.Generic;
using System.Linq;
namespace articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split(", ");
                Article article = new Article(arr[0], arr[1], arr[2]);
                articles.Add(article);
            }
            string command = Console.ReadLine();
            if (command == "title")
            {
                //Alphabetical order
                articles = articles.OrderBy(x => x.Title).ToList();
            }
            else if (command == "content")
            {
                articles = articles.OrderBy(x => x.Content).ToList();
            }
            else if (command == "author")
            {
                articles = articles.OrderBy(x=> x.Author).ToList();
            }


            Console.WriteLine(String.Join("\n ", articles));
        }
    }
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
      
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
