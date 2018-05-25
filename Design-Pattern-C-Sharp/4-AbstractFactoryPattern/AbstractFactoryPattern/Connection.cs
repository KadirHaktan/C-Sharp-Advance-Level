using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public abstract class Connection
    {
        public abstract bool Connect();
        public abstract bool DisConnect();
        public abstract string State
        {
            get;
        }
    }
    public abstract class Command
    {
        public abstract void Execute(string query);
    }
    public class Db2Connection : Connection
    {
        public override bool Connect()
        {
            Console.WriteLine("Db2Connection acilacak");
            return true;
        }

        public override bool DisConnect()
        {
            Console.WriteLine("Db2Connection kapatilacak");
            return true;
        }
        public override string State
        {
            get { return "Open"; }
        }


    }
    public class InterbaseConnection : Connection
    {
        public override bool Connect()
        {
            Console.WriteLine("Interbase acilacak");
            return true;
        }

        public override bool DisConnect()
        {
            Console.WriteLine("Interbase kapatilacak");
            return true;
        }
        public override string State
        {
            get { return "Open"; }
        }


    }

    public class Db2Command : Command
    {
        public override void Execute(string query)
        {
            Console.WriteLine("DB2 Sorgusu Çalıştırılır.");
        }
    }
    public class InterbaseCommand : Command
    {
        public override void Execute(string query)
        {
            Console.WriteLine(" Interbase Sorgusu Çalıştırılır.");
        }
    }

    public abstract class DatabaseFactory
    {
        public abstract Connection CreateConnection();
        public abstract Command CreateCommand();

    }

    public class Db2Factory : DatabaseFactory
    {
        public override Command CreateCommand()
        {
            return new Db2Command();
        }

        public override Connection CreateConnection()
        {
            return new Db2Connection();
        }
    }

    public class InterbaseFactory : DatabaseFactory
    {
        public override Command CreateCommand()
        {
            return new InterbaseCommand();
        }

        public override Connection CreateConnection()
        {
            return new InterbaseConnection();
        }
    }

    public class Factory
    {
        private DatabaseFactory _databaseFactory;
        private Connection _connection;
        private Command _command;

        public Factory(DatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
            _connection = databaseFactory.CreateConnection();
            _command = databaseFactory.CreateCommand();
        }
        public void Start()
        {
            _connection.Connect();
            if (_connection.State == "Open")
                _command.Execute("Select sorgusu verilebilir burada...");

    {

            }
        }
    }

}
