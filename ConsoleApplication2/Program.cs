using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Book
    {
        static int MaxPage { get;}

        static int numberOfDay { get; set; }
        int StartPage { get; }
        DateTime StartDate { get; }
        DateTime FinalDate { get; }
        public static int DayNorm { get; private set; }
        public int CurrentDayMaxPage { get; private set; }
        public int CurrentPage { get; set; }

        private static int DaysLeft { get; set;}


        static Book()
        {
            Book.MaxPage = 1000;
        }

        public Book()
        {
            this.StartPage = 33;
            this.StartDate = new DateTime(2016, 1, 19);
            this.FinalDate = new DateTime(2016, 2, 8);
            Book.DayNorm = Book.MaxPage / (FinalDate-StartDate).Days;
            //Узнаем текущий день
            numberOfDay = Convert.ToInt32((DateTime.Now - StartDate).TotalDays);
            //Узнаем сколько  дней соталось
            Book.DaysLeft = Convert.ToInt32((FinalDate - DateTime.Now).TotalDays);
        }

        public void KnowPagesLeft(int page)
        {
            //Вернуть кол-во страниц на сегодня
            CurrentDayMaxPage = DayNorm*numberOfDay + StartPage;
            Console.WriteLine("Текущая дневная норма {0} страниц", DayNorm);
            Console.WriteLine("Сегодня тебе еще осталось прочитать {0} страниц",CurrentDayMaxPage-page);
            Console.WriteLine("Читать до {0} страницы",CurrentDayMaxPage);

            if (page >= CurrentDayMaxPage)
            {
                Console.WriteLine("Время учить аглийский");
            }
            else
            {
                Console.WriteLine("Желаете пересчитать норму? Y / N");
                string answer = Console.ReadLine().ToString().ToUpper();
                switch (answer)
                {
                    case "Y":
                    case "Н":
                       this.ReCalculateDayNorm(page);
                        break;
                    default:
                        Console.WriteLine("\nИди читай, еще {0} страниц осталось сегодня!", CurrentDayMaxPage - page);
                        break;

                }
            }
        }

        public void ReCalculateDayNorm(int page)
        {
            int pagesLeft = Book.MaxPage - page;
            DayNorm = pagesLeft / DaysLeft;
            CurrentDayMaxPage = DayNorm * numberOfDay + StartPage;
            Console.WriteLine("Сегодня тебе еще осталось прочитать {0} страниц", CurrentDayMaxPage - page);
            Console.WriteLine("Читать до {0} страницы", CurrentDayMaxPage);
            Console.WriteLine("Новая дневная норма {0} страниц", DayNorm);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(50, 20);
            Console.WriteLine("Введи текущую страницу");
            int curPage= Convert.ToInt32(Console.ReadLine());

            new Book().KnowPagesLeft(curPage);
            Console.ReadKey();
        }
    }
}
