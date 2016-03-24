namespace CopyBinaryFile
{
    using System.IO;

    public class Program
    {
        public const string CardPath = "../../1_of_diamonds.png";

        public const string DestinationPath = "../../result.png";

        public static void Main(string[] args)
        {
            using (var source = new FileStream(CardPath, FileMode.Open))
            {
                using (var destination = new FileStream(DestinationPath, FileMode.Create))
                {
                    byte[] bufferBytes = new byte[4096];

                    while (true)
                    {
                        int readBytes = source.Read(bufferBytes, 0, bufferBytes.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }

                        destination.Write(bufferBytes, 0, readBytes);
                    }
                }
            }
        }
    }
}
