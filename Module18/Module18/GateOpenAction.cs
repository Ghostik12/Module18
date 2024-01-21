using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18
{
    public class GateOpenAction : IAction
    {
        Gate _gate;

        public GateOpenAction(Gate gate)
        {
            _gate = gate;
        }

        public void Start()
        {
            _gate.Open();
        }

        public void Stop()
        {
            _gate.Close();
        }
    }
}
