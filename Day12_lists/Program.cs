namespace Day12_Lists
{
    internal class Program
    {
        static void Main(string[] args)
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

        private static void sample1()
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