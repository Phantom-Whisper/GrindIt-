using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Manager.IManager;

namespace Manager
{
    public interface IManager
    {
        public delegate void DelegateDisplayMessage(string message);

        public event DelegateDisplayMessage MessageSended;
    }

    public class Manager : IManager
    {

        public event DelegateDisplayMessage? MessageSended;

        public Manager()
        {

        }
    }
}
