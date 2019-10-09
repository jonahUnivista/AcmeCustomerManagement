using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.Common
{
    public class OperationsResult
    {
        public bool Success { get; set; }

        public List<string> MessageList { get; private set; }

        public OperationsResult()
        {
            MessageList = new List<string>();
            Success = true;
        }
        public void AddMessage(string message)
        {
            MessageList.Add(message);
        }
    }
}
