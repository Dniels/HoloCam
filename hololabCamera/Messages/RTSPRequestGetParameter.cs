using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hololabCamera.Messages
{
    public class RtspRequestGetParameter : RtspRequest
    {

        // Constructor
        public RtspRequestGetParameter()
        {
            Command = "GET_PARAMETER * RTSP/1.0";
        }
    }
}
