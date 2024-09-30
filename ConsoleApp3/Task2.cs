using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Play : IDisposable
    {
        private string? title;
        private string? theater;
        private string? genre;
        private int duration;
        private List<string> actors = new List<string>();

        private bool disposed = false;

        public Play()
        {
            Title = "Untitled Play";
            Theater = "Unknown Theater";
            Genre = "Unknown Genre";
            Duration = 0;
        }

        public Play(string title, string theater, string genre, int duration, List<string> actors)
        {
            Title = title;
            Theater = theater;
            Genre = genre;
            Duration = duration;
            Actors = actors;
        }

        public string? Title
        {
            get { return title; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    title = value;
                }
                else
                {
                    throw new ArgumentException("Назва не може бути пустою");
                }
            }
        }

        public string? Theater
        {
            get { return theater; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    theater = value;
                }
                else
                {
                    throw new ArgumentException("Театр не може бути пустим");
                }
            }
        }

        public string? Genre
        {
            get { return genre; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    genre = value;
                }
                else
                {
                    throw new ArgumentException("Жанр не може бути пустим");
                }
            }
        }

        public int Duration
        {
            get { return duration; }
            set
            {
                if (value > 0)
                {
                    duration = value;
                }
                else
                {
                    throw new ArgumentException("Тривалість повинна бути більше 0");
                }
            }
        }

        public List<string> Actors
        {
            get { return actors; }
            set
            {
                if (value != null && value.Count > 0)
                {
                    actors = value;
                }
                else
                {
                    throw new ArgumentException("Список акторів не може бути порожнім");
                }
            }
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Назва: {Title}\nТеатр: {Theater}\nЖанр: {Genre}\nТривалість: {Duration} хвилин\nАктори:");
            foreach (var actor in Actors)
            {
                Console.WriteLine($"{actor}");
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (Actors != null)
                    {
                        Actors.Clear();
                    }
                }


                disposed = true;
            }
        }


        ~Play()
        {
            Dispose(disposing: false);
            Console.WriteLine($"Вистава {Title} знищена збирачем сміття");
        }
    }
}
