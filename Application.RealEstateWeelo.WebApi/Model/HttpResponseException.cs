using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Application.RealEstate.WebApi.Model
{
    public class HttpResponseException : Exception
    {
        public HttpResponseException()
        {


        }


        public HttpResponseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {


        }


        public int Status { get; set; }
        public object Value { get; set; }

    }
}
