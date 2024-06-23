using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_19._06_Despose
{
    internal class Movie: IDisposable
    {
        public string Name { get; set; }
        public string StudioName { get; set; }
        public string Genre { get; set; }
        public double Duration { get; set; }
        public DateTime Year { get; set; }
        public Movie(string name, string studioName, string genre, double duration, int year)
        {
            Name = name;
            StudioName = studioName;
            Genre = genre;
            Duration = duration;
            Year = new DateTime(year,1,1);
        }
        public override string ToString()
        {
            return $"Movie name: {Name}, Studio: {StudioName}, Genre: {Genre}\n" +
                $"Duration: {Duration}  Year: {Year.Year}";
        }

        ~Movie()
        {
            Console.WriteLine("Movie Finalizer ()");
        }

        public void Dispose()
        {
            Console.WriteLine("Movie Dispose()...");
        }

    }
}
