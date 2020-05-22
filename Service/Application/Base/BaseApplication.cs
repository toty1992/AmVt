using Service.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Application.Base
{
    public class BaseApplication
    {
        private AmericaVirtualEntities _context;
        public AmericaVirtualEntities Context
        {
            get { return _context ?? (_context = new AmericaVirtualEntities()); }
            set { _context = value; }
        }

        public static T GetInstante<T>() where T : BaseApplication, new()
        {
            return new T();
        }

    }
}
