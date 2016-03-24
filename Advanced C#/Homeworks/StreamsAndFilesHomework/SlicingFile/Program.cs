namespace SlicingFile
{
    using System;
    using System.IO;

    public class Program
    {
        public const string SourcePath = "../../Wildlife.wmv";

        public const string DestinationPath = "../../";

        public const int Parts = 5;

        public static void Main(string[] args)
        {
            SliceFile(SourcePath, DestinationPath, Parts);
        }

        private static void SliceFile(string sourceFile, string destinationDirectory, int parts)
        {
            byte[] byteSource = File.ReadAllBytes(sourceFile);
            FileInfo fileInfoSource = new FileInfo("Wildlife.wmv");
            int partSize = (int)Math.Ceiling((double)(fileInfoSource.Length / parts));
            int fileOffset = 0;
            int sizeRemaining = (int)fileInfoSource.Length;

            for (int i = 0; i < parts; i++)
            {
                var currentPartPath = 
                    destinationDirectory + 
                    string.Format(@"Part-{0}.{1}", i, fileInfoSource.Extension);

                if (!File.Exists(currentPartPath))
                {
                    var fileStreamPart = new FileStream(currentPartPath, FileMode.CreateNew);
                    sizeRemaining = (int)fileInfoSource.Length - (i * partSize);
                    if (sizeRemaining < partSize)
                    {
                        partSize = sizeRemaining;
                    }
                    
                    fileStreamPart.Write(byteSource, fileOffset, partSize);
                    fileStreamPart.Close();
                    fileOffset += partSize;
                }
            }
        }
    }
}
