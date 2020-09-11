using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hololabCamera.Messages
{
    public class RtspRequestAnnounce : RtspRequest
    {
        // constructor

        public RtspRequestAnnounce()
        {
            Command = "ANNOUNCE * RTSP/1.0";
        }
    }
}