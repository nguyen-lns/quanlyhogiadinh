using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project.BussinessLogic.Constant.Connect
{
    public static class Connection
    {
        private static string _connectionString;
        private static int _connectionNumber;

        static Connection()
        {
            _connectionString = @"server=localhost;user id=root;persistsecurityinfo=True;database=quanlyhogiadinh";
            _connectionNumber = 1000;
        }

        public static string ConnectionString
        {
            get { return _connectionString; }
        }

        public static int ConnectionNumber
        {
            get { return _connectionNumber; }
        }
    }
}