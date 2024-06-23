using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_19._06_Despose
{
    internal class Perfomance: IDisposable
    {
        public string Name { get; set; }
        public string TheaterName { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
        public List<string> ActorsList { get; set; }

        public Perfomance(string name, string theaterName, string genre, int duration, params string[] actorsList)
        {
            Name = name;
            TheaterName = theaterName;
            Genre = genre;
            Duration = duration;
            ActorsList = new List<string> (actorsList);
        }
        public Perfomance(string name, string theaterName, string genre, int duration, List<string> actorsList)
        {
            Name = name;
            TheaterName = theaterName;
            Genre = genre;
            Duration = duration;
            ActorsList = new List<string>(actorsList);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Theater: {TheaterName}, Genre: {Genre}, Duration: {Duration}" +
                 $"\nActors: {string.Join(", ", ActorsList)}";
        }

        public void Dispose()
        {
            ActorsList.Clear();
            Console.WriteLine("Dispose() .Clear()...");
        }

        ~Perfomance()
        {
            ActorsList.Clear ();
            Console.WriteLine("Finalizer()...");
        }

    }
}
