using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project.BussinessLogic.Constant.SQL.DTB_Table
{
    public static class sql_dtb_floor
    {
        private static string selectAll;

        static sql_dtb_floor()
        {
            selectAll = @"
                        SELECT * FROM DTB_FLOOR
                        ";
        }

        public static string SelectAll
        {
            get { return selectAll; }
        }
    }
}