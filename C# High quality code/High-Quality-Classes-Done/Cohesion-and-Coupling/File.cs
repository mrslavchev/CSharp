namespace CohesionAndCoupling
{
    /*Since file formatting and 3D shapes and calculations
      have nothing in common, I just splitted 'em in two separate classes.
     Replaced this "" with string.empty for better readibility, magic string "." moved to
     constant.*/
    public class File
    {
        private readonly const string Dot = ".";

        public static string GetFileExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(Dot);
            if (indexOfLastDot == -1)
            {
                return string.Empty;
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        public static string GetFileNameWithoutExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(Dot);
            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }
    }
}
