using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project.BussinessLogic.Constant.Schema
{
    public static class DTB_FLOOR
    {
        private static string id;
        private static string name;

        static DTB_FLOOR()
        {
            id = "id";
            name = "name";
        }

        public static string Id
        {
            get { return id; }
        }

        public static string Name
        {
            get { return name; }
        }
    }
}