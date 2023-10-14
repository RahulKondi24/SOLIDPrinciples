namespace DIP
{
    public interface ILogger
    {
        void LogError(string error);
    }
    public class Membership
    {
        ILogger logger;
        public Membership(ILogger _logger)
        {
            logger = _logger;

            // TO Do : read from app.config
            //int config = 1;
            //if (config == 1)
            //{
            //    logger = new FileLogger();
            //}
            //else
            //{
            //    logger = new ConsoleLogger();
            //}
            //^^ this is not approch implement this dependince
        }
        public void Add()
        {
            try
            {
                // TO DO : 
            }
            catch (Exception ex)
            {
                //FileLogger f = new FileLogger();
                //f.LogError(ex.Message);
                //OR
                logger.LogError(ex.Message);
            }
        }
    }
    public class FileLogger:ILogger
    {
        public void LogError(string error)
        {
            File.WriteAllText(@"c:\Error.txt", error);
        }
    }
    public class ConsoleLogger:ILogger
    {
        public void LogError(string error)
        {
            Console.WriteLine($"Error : {error}");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            FileLogger fl = new FileLogger();
            Membership m1 = new Membership(fl);

            ConsoleLogger cl = new ConsoleLogger();
            Membership m2 = new Membership(cl);
        }
    }
}