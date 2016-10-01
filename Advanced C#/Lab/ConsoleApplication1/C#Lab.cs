namespace BashSoft
{
    public class Launcher
    {
        public  static void Main(string[] args)
        {
            //IOManager.TraverseDirectory(@"D:\R\CSharpAdvanced");

            StudentsRepository.InitializeData();
            StudentsRepository.GetAllStudentsFromCourse("Unity");
            StudentsRepository.GetStudentScoresFromCourse("Unity", "Ivan");
        }
    }
}
