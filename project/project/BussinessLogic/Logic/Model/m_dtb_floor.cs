using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.BussinessLogic.Logic.Model
{
    public class m_dtb_floor
    {
        private int? id;
        private string name;

        public m_dtb_floor(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public m_dtb_floor()
        {
            this.id = null;
            this.name = null;
        }

        public int Id
        {
            get
            {
                if (id != null) return (int) id;
                return 0;
            }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
