using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp3
{
    class Film
    {
        private string? title;
        private string? studio;
        private string? genre;
        private int duration;
        private int year;

        public Film()
        {
            title = "Untitled Film";
            studio = "Unknown Studio";
            genre = "Unknown Genre";
            duration = 0;
            year = 0;
        }

        public Film(string title, string studio, string genre, int duration, int year)
        {
            Title = title;
            Studio = studio;
            Genre = genre;
            Duration = duration;
            Year = year;
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

        public string? Studio
        {
            get { return studio; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    studio = value;
                }
                else
                {
                    throw new ArgumentException("Кіностудія не може бути пустою");
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
                    throw new ArgumentException("Тривалість має бути більшою за 0");
                }
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value > 0)
                {
                    year = value;
                }
                else
                {
                    throw new ArgumentException("Рік має бути більшим за 0");
                }
            }
        }
        ~Film()
        {
            Console.WriteLine($"Фільм {Title} видалено з пам'яті");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Назва: {Title}\nКіностудія: {Studio}\nЖанр: {Genre}\nТривалість: {Duration} хвилин\nРік: {Year}\n");
        }
    }
}
