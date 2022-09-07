using System;

namespace articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(", ");

            Article article = new Article(arr[0], arr[1], arr[2]);
            int n = int.Parse(Console.ReadLine());
            //Console.WriteLine(article);
            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split(": ");

                if (commands[0] == "Edit")
                {
                    //new content
                    article.Content = commands[1];
                }
                else if (commands[0] == "ChangeAuthor")
                {
                    //new autor
                    article.Author = commands[1];
                }
                else if (commands[0] == "Rename")
                {
                    //new title
                    article.Title = commands[1];
                }
            }
            Console.WriteLine(article);
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
