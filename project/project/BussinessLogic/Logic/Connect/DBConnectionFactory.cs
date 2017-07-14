using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using project.BussinessLogic.Constant.Connect;

namespace project.BussinessLogic.Logic.Connect
{
    public static class DbConnectionFactory
    {
        private static MySqlConnection[] _mySqlConnections;

        static DbConnectionFactory()
        {
            _mySqlConnections = new MySqlConnection[Connection.ConnectionNumber];
        }

        public static MySqlConnection GetConnection()
        {
            for (int i = 0; i < Connection.ConnectionNumber; i++)
            {
                if (_mySqlConnections[i] != null)
                {
                    if (_mySqlConnections[i].State == ConnectionState.Closed)
                    {
                        return _mySqlConnections[i];
                    }
                }
                else
                {
                    _mySqlConnections[i] = new MySqlConnection(Connection.ConnectionString);
                    return _mySqlConnections[i];
                }
            }

            return null;
        }
    }
}