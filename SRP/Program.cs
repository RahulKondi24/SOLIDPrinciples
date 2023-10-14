namespace SRP
{
    public class Membership
    {
        public void Add()
        {
            try {
                // TO DO : 
            }
            catch (Exception ex)
            {
                //FileLogger f = new FileLogger();
                //f.LogError(ex.Message);
                // OR
                // class is static
                FileLogger.LogError(ex.Message);
            }
        }
    }
    //SRP Example
    public static class FileLogger
    {
        public static void LogError(string error)
        {
            File.WriteAllText(@"c:\Error.txt", error);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}