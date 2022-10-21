static class Programm
{
    struct Exam
    {
        public string Group;
        public string NameTeacher;
        public string DataExam;
        public string NameDisciplina;

        public Exam(string Group, string NameTeacher, string DataExam, string NameDisciplina)
        {
            this.Group = Group;
            this.NameTeacher = NameTeacher;
            this.DataExam = DataExam;
            this.NameDisciplina = NameDisciplina;
        }

        public void Print()
        {
            Console.WriteLine(
                $"Все экзамены {Group}:\nназвание - {NameDisciplina}\nимя преподавателя - {NameTeacher}" +
                $"\nдата проведения - {DataExam}");
        }
    }

    static void Main()
    {
        Exam[] MessageArray = new Exam[2];

        for (int i = 0; i < MessageArray.Length; i++)
        {
            string group = Console.ReadLine(), nameDisciplina = Console.ReadLine();
            string nameTeacher = Console.ReadLine(), dataExam = Console.ReadLine();    

            MessageArray[i] = new Exam(group, nameTeacher, dataExam, nameDisciplina);
        }

        Console.Write("Введите группу: ");
        string GetGroup = Console.ReadLine();

        for (int i = 0; i < MessageArray.Length; i++)
        {
            if (MessageArray[i].Group == GetGroup)
            {
                MessageArray[i].Print();
            }
        }
        Console.ReadLine();
    }
}