namespace _1_assignment
{
    internal class Program
    {
        public class Logger
        {
            private static Logger instance { get; set; }=default!; // added private static field to our class for storing the instance
            private string Name { get; set; }


            private Logger() // we created private constructor, so now constructor cannot be called outside of the class (with new key)
            {      
            }

            public static Logger getInstance() // created a public static method to create/then get instance
            {
                if (Logger.instance == null) // for the first call it creates new instance, then returns firstly-created instance
                {
                    Logger.instance = new Logger();
                }
                return Logger.instance;
            }
           
            public void Log(string message) // public method that gets string message as an argument and print it
            {
                Console.WriteLine(message);
            }
        }
        static void Main(string[] args)
        {
            var logger = Logger.getInstance();
            logger.Log("Hello World");
            

            var logger2 = Logger.getInstance();            
            logger2.Log("Hello World 2");

            Console.WriteLine("Does logger and logger2 refer to the same (only one) object: {0}",Object.ReferenceEquals(logger, logger2));
        }
    }
}