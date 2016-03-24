namespace CohesionAndCoupling
{
    using System;

    public static class FileUtils
    {
        public static string GetFileExtension(string fileName)
        {
            ValidateFileName(fileName);
            
            string extension = string.Empty;
            try
            {
                int indexOfLastDot = fileName.LastIndexOf(".");
                if (indexOfLastDot >= 0 &&
                    indexOfLastDot <= fileName.Length - 1)
                {
                    extension = fileName.Substring(indexOfLastDot + 1);

                    return extension;
                }
            }
            catch (ArgumentNullException)
            {
            }
              
            return extension;
        }

        public static string GetFileNameWithoutExtension(string fileName)
        {
            ValidateFileName(fileName);

            string fileNameWithoutExtension = fileName;
            try
            {
                int indexOfLastDot = fileName.LastIndexOf(".");
                fileNameWithoutExtension = fileName.Substring(0, indexOfLastDot);

                return fileNameWithoutExtension;
            }
            catch (ArgumentNullException)
            {
            }
            catch (ArgumentOutOfRangeException)
            {
            }

            return fileNameWithoutExtension;
        }

        private static void ValidateFileName(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException(
                    nameof(fileName),
                    "File name cannot be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentNullException(
                    nameof(fileName),
                    "File name cannot be null or white space.");
            }
        }
    }
}
