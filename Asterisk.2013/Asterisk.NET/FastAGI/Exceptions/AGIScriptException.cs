using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsterNET.FastAGI.Exceptions
{
    public class AGIScriptException : Exception
    {
        public AGIRequest Request { get; private set; }
        public AGIChannel Channel { get; private set; }

        public AGIScriptException(Exception e, AGIRequest request, AGIChannel channel) : base("AGI Script Threw Unhandled Exception", e)
        {
            Request = request;
            Channel = channel;
        }
    }
}
