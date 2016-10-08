using System.Runtime.CompilerServices;

namespace SimpleJudge
{
    using System.IO;

    public static class SessionData
    {
        private static string currentPath = Directory.GetCurrentDirectory();

        public static string CurrentPath 
        {
            get
            {
                return currentPath;
                
            }
            set
            {
                value = currentPath;
            }
        }
    }
}