using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using project.BussinessLogic.Constant.Schema;
using project.BussinessLogic.Constant.SQL.DTB_Table;
using project.BussinessLogic.Logic.Connect;
using project.BussinessLogic.Logic.Model;

namespace project.BussinessLogic.Logic.DAL
{
    public class DAL_dtb_floor : IDisposable
    {
        private MySqlConnection _mySqlConnection;

        public DAL_dtb_floor()
        {
            this._mySqlConnection = DbConnectionFactory.GetConnection();
            if (MySqlConnection.State == ConnectionState.Closed)
            {
                MySqlConnection.Open();
            }
        }

        public MySqlConnection MySqlConnection
        {
            get { return _mySqlConnection; }
        }

        public void Dispose()
        {
            if (_mySqlConnection != null && MySqlConnection.State == ConnectionState.Open) _mySqlConnection.Close();
        }

        public IList<m_dtb_floor> GetDtbFloors()
        {
            IList<m_dtb_floor> dtbFloors = new List<m_dtb_floor>();

            MySqlCommand command = MySqlConnection.CreateCommand();
            command.CommandText = sql_dtb_floor.SelectAll;
            command.CommandType = CommandType.Text;

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                m_dtb_floor dtbFloor = new m_dtb_floor(reader.GetInt32(DTB_FLOOR.Id), reader.GetString(DTB_FLOOR.Name));
                dtbFloors.Add(dtbFloor);
            }

            return dtbFloors;
        }
    }
}