using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18
{
    public class Pult
    {
        IAction _action;
        public void SetAction(IAction action)
        {
             _action= action;
        }

        public void OpenButton()
        {
            _action.Start();
        }

        public void CloseButton()
        {
            _action.Stop();
        }
    }
}
