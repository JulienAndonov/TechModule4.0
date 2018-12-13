using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Articles
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }


        public void Edit(string newContent)
        {
            this.Content = newContent;
        }


        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }



        public void toString()
        {
            Console.WriteLine($"{this.Title} - {this.Content}: {this.Author}");
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();


           

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                List<string> commands = Console.ReadLine().Split(new string[] {", "},StringSplitOptions.None).Select(x => x.Trim()).ToList();
                

                articles.Add(new Article()
                {
                    Title = commands[0],
                    Content = commands[1],
                    Author = commands[2]
                });
            }

            String command = Console.ReadLine();
            switch (command)
            {
                case "title":
                    articles = articles.OrderBy(x => x.Title).ToList();
                    break;
                case "content":
                    articles = articles.OrderBy(x => x.Content).ToList();
                    break;
                case "author":
                    articles = articles.OrderBy(x => x.Author).ToList();
                    break;
            }



            foreach (var currentArticle in articles)
            {
                currentArticle.toString();
            }
        }
    }
}
