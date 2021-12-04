namespace Task_2
{
    struct Worker
    {
        public string Name { get; set; }
        public string Post { get; set; }
        public int Year { get; set; }

        public Worker(string name, string post, int year)
        {
            Name = name;
            Post = post;
            Year = year;
        }
    }
}
