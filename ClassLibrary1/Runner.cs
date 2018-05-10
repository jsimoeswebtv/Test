using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRunner
{
    public class Runner : IRunner
    {

        public string Starter()
        {
            return "hello world";
        }

        /// <summary>
        /// This method finishes the process
        /// </summary>
        /// <remarks>the implementation should connect to database and update rows</remarks>
        /// <returns>a string representing the state</returns>
        public string Finisher()
        {
            return "another";
        }
    }
}
