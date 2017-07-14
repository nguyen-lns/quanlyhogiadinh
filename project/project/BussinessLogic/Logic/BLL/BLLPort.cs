using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project.BussinessLogic.Logic.BLL
{
    public static class BLLPort
    {
        public static BLL_dtb_floor GetBllDtbFloor()
        {
            return new BLL_dtb_floor();
        }
    }
}