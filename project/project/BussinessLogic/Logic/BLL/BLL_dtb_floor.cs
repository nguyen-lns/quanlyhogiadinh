using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using project.BussinessLogic.Logic.DAL;
using project.BussinessLogic.Logic.Model;

namespace project.BussinessLogic.Logic.BLL
{
    public class BLL_dtb_floor : IDisposable
    {
        private DAL_dtb_floor _dalDtbFloor;

        public BLL_dtb_floor()
        {
            this._dalDtbFloor = new DAL_dtb_floor();
        }

        public IList<m_dtb_floor> GetDtbFloors()
        {
            return this._dalDtbFloor.GetDtbFloors();
        }

        public void Dispose()
        {
            if (_dalDtbFloor != null) _dalDtbFloor.Dispose();
        }
    }
}