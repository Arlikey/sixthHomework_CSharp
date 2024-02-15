using WordsCounter;

namespace sixthHomework
{
    /*class MainTask
    {
        static void Main(string[] args)
        {
            Birthday birthday = new Birthday(new DateTime(2005, 04, 30));
            Console.WriteLine(birthday.GetDayOfWeek());
            Console.WriteLine(birthday.GetDayOfWeekOfYear(2024));
            Console.WriteLine(birthday.DaysUntilBirthday());
        }

        struct Birthday
        {
            private DateTime birthDate;

            public DateTime BirthDate
            {
                get => birthDate;
                set => birthDate = value;
            }

            public Birthday(DateTime birthDate)
            {
                this.birthDate = birthDate;
            }

            public string GetDayOfWeek()
            {
                return birthDate.ToString("dddd");
            }

            public string GetDayOfWeekOfYear(int year)
            {
                DateTime birthdate2 = new DateTime(year, birthDate.Month, birthDate.Day);
                return birthdate2.ToString("dddd");
            }

            public int DaysUntilBirthday()
            {
                DateTime today = DateTime.Today;
                DateTime nextBirthday = new DateTime(today.Year, birthDate.Month, birthDate.Day);
                if (nextBirthday < today) nextBirthday = nextBirthday.AddYears(1);
                return (nextBirthday - today).Days;
            }
        }
    }*/

    class AdditionalTask1
    {
        static void Main()
        {
            string text = "The sun dipped below the horizon, casting a warm glow across the tranquil beach. " +
                "Waves gently lapped at the shore, leaving a trail of foamy whispers. " +
                "Seabirds soared overhead, their calls merging with the soft rustle of palm leaves. " +
                "Nature's symphony played as the day gracefully bid farewell.";

            WordsCounter.TextAnalyzer textAnalyzer = new TextAnalyzer(text);

            WordInfo[] words = textAnalyzer.GetWords();

            Console.WriteLine("Слова: ");
            foreach (WordInfo wordInfo in words)
            {
                Console.WriteLine($"{wordInfo.Word} - {wordInfo.Frequency}");
            }

        }
    }
}
