using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18
{
    public abstract class BaseClass
    {
        protected int Id;

        public BaseClass(int id)
        {
            Id = id;
        }
        public abstract BaseClass Clone();

        public abstract void GetId();
    }
}
