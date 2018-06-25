using System;

namespace _2_Factory_Method_Desing_Pattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new LoggerFactory());
            customerManager.Save();
            Console.ReadLine();
        }
    }

    //En temel olay bizim bir fabrikamız olmasıdır.
    /*
     Burada en temel olay LoggerFactory classıdır.
     */

    /// <summary>
    /// Fabrika 1
    /// </summary>
    public class LoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            // Burada bir iş geliştirilir ve iş sonucnudna o fabrikanın nasıl bir log üreteceğine karar veririz.
            //Business to decide factory
            return new EdLogger();
        }
    }

    public class LoggerFactory2 : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            //Bu fabrikada farklı bir mantıkta çalışıyor olabilir.
            //Business to decide factory
            return new Log4NetLogger();
        }
    }

    /// <summary>
    /// Fabrika 2
    /// </summary>
    public interface ILoggerFactory
    {
        ILogger CreateLogger();
    }

    public interface ILogger
    {
        void Log();
    }

    public class EdLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with EdLogger");
        }
    }

    public class Log4NetLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with Log4NetLogger");
        }
    }

    public class CustomerManager
    {
        private ILoggerFactory _loggerFactory;

        public CustomerManager(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }

        public void Save()

        {
            Console.WriteLine("Saved!");
            // ILogger logger = new LoggerFactory().CreateLogger();
            ILogger logger = _loggerFactory.CreateLogger();

            logger.Log();
        }
    }
}