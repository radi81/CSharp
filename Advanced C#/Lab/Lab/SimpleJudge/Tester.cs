namespace SimpleJudge
{
    using System;
    using System.IO;
    using BashSoft;

    public static class Tester
    {
        public static void CompareContent(string userOutputPath, string expectedOutputPath)
        {
            OutputWriter.WriteMessageOnNewLine("Reading files...");

            string mismatchPath = GetMismatchPath(expectedOutputPath);

            string[] actualOutputLines = File.ReadAllLines(userOutputPath);
            string[] expectedOutputLines = File.ReadAllLines(expectedOutputPath);

            bool hasMismatch;
            string[] mismatches = GetLinesWithPossibleMismatches(
                actualOutputLines,
                expectedOutputLines,
                out hasMismatch);

            PrintOutput(mismatches, hasMismatch, mismatchPath);
            OutputWriter.WriteMessageOnNewLine("File read!");
        }

        private static string GetMismatchPath(string expectedOutputPath)
        {
            int indexOf = expectedOutputPath.LastIndexOf('\\');
            string directoryPath = expectedOutputPath.Substring(0, indexOf);
            string finalPath = directoryPath + @"\Mismatcehs.txt";

            return finalPath;
        }

        private static string[] GetLinesWithPossibleMismatches(
            string[] actualOutputString, string[] expectedOutputString, out bool hasMismatch)
        {
            hasMismatch = false;
            string output = string.Empty;
            string[] mismatches = new string[actualOutputString.Length];
            OutputWriter.WriteMessageOnNewLine("Comparing files...");

            for (int index = 0; index < actualOutputString.Length; index++)
            {
                string actualLine = actualOutputString[index];
                string expectedLine = expectedOutputString[index];

                if (!actualLine.Equals(expectedLine))
                {
                    output = string.Format(
                        "mismatch at line {0} -- expected: \"{1}\", actual: \"{2}\"",
                        index, 
                        actualLine, 
                        expectedLine);
                    output += Environment.NewLine;
                    hasMismatch = true;
                }
                else
                {
                    output = actualLine;
                    output += Environment.NewLine;
                }

                mismatches[index] = output;
            }

            return mismatches;
        }

        private static void PrintOutput(string[] mismatches, bool hasMismatch, string mismatchesPath)
        {
            if (hasMismatch)
            {
                foreach (var line in mismatches)
                {
                    OutputWriter.WriteMessageOnNewLine(line);
                }

                File.WriteAllLines(mismatchesPath, mismatches);

                return;
            }

            Console.WriteLine("Files are identical. There are no mismatches.");
        }
    }
}
