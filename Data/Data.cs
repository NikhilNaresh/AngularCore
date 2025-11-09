namespace AngularCore.Data
{
    public static class Data
    {
        public static List<Book> Books => allBooks;

        static List<Book> allBooks = new List<Book>
        {
            new Book()
            {
                Id = 1,
                Title = "Managing IneSelf",
                Description = "We live in an age of unprecedented opportunity",
                Author = "Peter Ducker",
                Rate = (double)4.9,
                DateStart = new DateTime(2025, 01, 20),
                DateRead = null
            },
            new Book()
            {
                Id = 2,
                Title = "Digital Strategy",
                Description = "A guide to thriving in digital business landscapes.",
                Author = "Emily Tran",
                Rate = 4.6,
                DateStart = new DateTime(2024, 11, 10),
                DateRead = new DateTime(2025, 02, 15)
            },
            new Book()
            {
                Id = 3,
                Title = "Leadership Simplified",
                Description = "Principles of effective team leadership.",
                Author = "John Maxwell",
                Rate = 4.8,
                DateStart = new DateTime(2024, 09, 05),
                DateRead = null
            },
            new Book()
            {
                Id = 4,
                Title = "Machine Learning Basics",
                Description = "Beginner's approach to machine learning.",
                Author = "Sara Kim",
                Rate = 4.5,
                DateStart = null,
                DateRead = null
            },
            new Book()
            {
                Id = 5,
                Title = "Time Management Tactics",
                Description = "Real solutions for maximizing productivity.",
                Author = "James Cruz",
                Rate = 4.3,
                DateStart = new DateTime(2025, 03, 01),
                DateRead = new DateTime(2025, 04, 10)
            },
            new Book()
            {
                Id = 6,
                Title = "Innovation Mindset",
                Description = "Changing your perspective for creativity.",
                Author = "Linda Green",
                Rate = 4.7,
                DateStart = new DateTime(2025, 02, 17),
                DateRead = null
            },
            new Book()
            {
                Id = 7,
                Title = "Organizational Behavior",
                Description = "An analysis of company cultures.",
                Author = "David Ross",
                Rate = 4.2,
                DateStart = null,
                DateRead = new DateTime(2025, 05, 25)
            },
            new Book()
            {
                Id = 8,
                Title = "Agile Management",
                Description = "Implementing agile strategies in business.",
                Author = "Priya Nair",
                Rate = 4.4,
                DateStart = new DateTime(2024, 12, 05),
                DateRead = new DateTime(2025, 01, 10)
            },
            new Book()
            {
                Id = 9,
                Title = "Effortless Networking",
                Description = "Secrets to building professional relationships.",
                Author = "Alex Warren",
                Rate = 4.1,
                DateStart = null,
                DateRead = null
            },
            new Book()
            {
                Id = 10,
                Title = "Success Habits",
                Description = "Daily actions to foster achievement.",
                Author = "Michelle Obama",
                Rate = 4.9,
                DateStart = new DateTime(2025, 06, 01),
                DateRead = null
            },
            new Book()
    {
        Id = 11,
        Title = "Financial Freedom",
        Description = "Methods and mindset to achieve wealth.",
        Author = "Robert Kiyosaki",
        Rate = 4.6,
        DateStart = new DateTime(2025, 04, 14),
        DateRead = new DateTime(2025, 04, 28)
    }
        };
    }
}