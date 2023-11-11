namespace Day12_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            books.Add(new Book("aaa", "bbbb", "aaaaaaa", 2003));
            books.Add(new Book("aasdasd", "dsfdf", "aaaaaaa", 2013));
            books.Add(new Book("eeee", "ccc", "cxvxcv", 2020));

            for(int i = 0; i < books.Count; i++)
            {
                books[i].IzvaditInfo();
                Console.WriteLine("------------");
            }
        }

        private static void PetSample()
        {
            List<Pet> petLists = new List<Pet>();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ievadi Majdzivnieka vardu!");
                String name = Console.ReadLine();

                Console.WriteLine("Ievadi Majdzivnieka tipu!");
                String type = Console.ReadLine();

                Console.WriteLine("Ievadi Majdzivnieka vecumu!");
                int age = Convert.ToInt32(Console.ReadLine());

                petLists.Add(new Pet(name, type, age));
            }
        }

        private static void StudentSample()
        {
            StudentO st1 = new StudentO("Janis", "Abolins");
            st1.StudentaInfo();

            List<StudentO> studentList = new List<StudentO>();


            studentList.Add(new StudentO("Janis", "Abolins"));
            studentList.Add(new StudentO("Juris", "Ozols"));

            for (int i = 0; i < studentList.Count; i++)
            {
                studentList[i].StudentaInfo();
            }
        }

        private static void Sample1()
        {
            int[] atzimes = { 4, 2, 8 };

            StudentO student = new StudentO();
            student.vards = "Arturs";
            student.uzvards = "Abolins";
            student.PievienotAtzimesArr(atzimes);
            student.StudentaInfo();

            Console.WriteLine("------------");

            int[] atzimes2 = { 5, 2, 9 };

            StudentO student2 = new StudentO();
            student2.vards = "Janis";
            student2.uzvards = "Ozols";
            student2.PievienotAtzimesArr(atzimes2);
            student2.StudentaInfo();

            Console.WriteLine("------------");

            List<StudentO> studentList = new List<StudentO>();

            studentList.Add(student);
            studentList.Add(student2);

            for (int i = 0; i < studentList.Count; i++)
            {
                studentList[i].StudentaInfo();
            }
        }

        private static void Homework()
        {
            int[] atzimes = { 4, 2, 8 };

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(3);
            list.Add(6);

            Student.PievienotAtzimesArr(atzimes);
            Student.PievienotAtzimesList(list);

            Student.StudentaInfo();
            Console.WriteLine("------------");
            Student.IzdzestAtzimes();
            Student.StudentaInfo();
        }
    }
}