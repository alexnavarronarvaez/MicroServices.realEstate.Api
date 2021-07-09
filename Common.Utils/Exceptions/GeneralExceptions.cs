using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common.Utils.Exceptions
{
    public class GeneralExceptions : Exception
    {

        public GeneralExceptions() : base()
        {


        }

        public GeneralExceptions(string message) : base(message)
        {


        }

        public GeneralExceptions(SerializationInfo info, StreamingContext context) : base(info, context)
        {


        }

    }
}
