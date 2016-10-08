namespace SimpleJudge
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Tester.CompareContent(
                @"D:\\R\\CSharpAdvanced\\Lab\\03. CSharp-Advanced-Files-And-Directories-Lab\\test1.txt", 
                @"D:\R\CSharpAdvanced\Lab\03. CSharp-Advanced-Files-And-Directories-Lab\\test2.txt");

            Console.WriteLine();

            Tester.CompareContent(
                @"D:\\R\\CSharpAdvanced\\Lab\\03. CSharp-Advanced-Files-And-Directories-Lab\\test2.txt",
                @"D:\R\CSharpAdvanced\Lab\03. CSharp-Advanced-Files-And-Directories-Lab\\test3.txt");
        }
    }
}
