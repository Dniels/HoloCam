using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hololabCamera.Messages
{
    public class RtspRequestDescribe : RtspRequest
    {

        // constructor

        public RtspRequestDescribe()
        {
            Command = "DESCRIBE * RTSP/1.0";
        }
    }
}
