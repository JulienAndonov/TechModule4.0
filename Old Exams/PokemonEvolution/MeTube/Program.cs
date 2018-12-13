using System;
using System.Collections.Generic;
using System.Linq;

namespace MeTube
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> videos = new Dictionary<string, int[]>();

            string input = Console.ReadLine();
            while (input != "stats time")
            {
                if (input.Contains("-"))
                {
                    string[] tokens = input.Split('-');
                    string videoName = tokens[0];
                    int views = int.Parse(tokens[1]);

                    if (!videos.ContainsKey(videoName))
                    {
                        videos[videoName] = new int[2];
                    }
                    videos[videoName][0] += views;
                }
                if (input.Contains(":"))
                {
                    string[] tokens = input.Split(':');
                    string likeDislike = tokens[0];
                    string videoName = tokens[1];

                    if (videos.ContainsKey(videoName))
                    {
                        if (likeDislike == "like")
                        {
                            videos[videoName][1]++;
                        }
                        else if (likeDislike == "dislike")
                        {
                            videos[videoName][1]--;
                        }
                    }
                }
                input = Console.ReadLine();
            }

            string command = Console.ReadLine();


            if (command == "by views")
            {

                foreach (var video in videos.OrderByDescending(v => v.Value[0]))
                {
                    Console.WriteLine($"{video.Key} - {video.Value[0]} views - {video.Value[1]} likes");
                }
            }
            else if (command == "by likes")
            {
                foreach (var video in videos.OrderByDescending(v => v.Value[1]))
                {
                    Console.WriteLine($"{video.Key} - {video.Value[0]} views - {video.Value[1]} likes");
                }
            }



        }
    }
}
