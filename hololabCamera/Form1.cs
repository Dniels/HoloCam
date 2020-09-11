using Accord.Video.FFMPEG;
using System;
using System.Windows.Forms;

namespace hololabCamera
{
    public partial class HololabCamera : Form
    {
        VideoFileSource vfs ;
        RtspServer s ;

        public HololabCamera()
        {
            InitializeComponent();
        }

        private void btnReconect_Click(object sender, System.EventArgs e)
        {
            vsp.Stop();

            vfs = new VideoFileSource("rtsp://170.93.143.139/rtplive/470011e600ef003a004ee33696235daa");

            vsp.VideoSource = vfs;
            vsp.Start();
                      
        }

        private void HololabCamera_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if(vsp.VideoSource != null && vsp.VideoSource.BytesReceived > 0)
                vsp.Stop();
            }
            catch (System.Exception)
            {
                throw;
            }
            finally
            {
                vsp.Dispose();
            }

        }

        private void btnServidor_MouseClick(object sender, MouseEventArgs e)
        {

            //-----------------------------------

            int port = 8554;
            string username = null;// "user";      // or use NUL if there is no username
            string password = null;// "password";  // or use NUL if there is no password

            s = new RtspServer(port, username, password);
            try
            {
                s.StartListen();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: Could not start server");
                return;
            }

            // Wait for user to terminate programme
            //String msg = "Connect RTSP client to Port=" + port;
            //if (username != null && password != null)
            //{
            //    msg += " Username=" + username + " Password=" + password;
            //}
            //Console.WriteLine(msg);
            //Console.WriteLine("Press ENTER to exit");
            //String readline = null;
            //while (readline == null)
            //{
            //    readline = Console.ReadLine();

            //    // Avoid maxing out CPU on systems that instantly return null for ReadLine
            //    if (readline == null) Thread.Sleep(500);
            //}

            //s.StopListen();
            //-----------------------------------

        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            s.StopListen();
            //s.Dispose();
        }
    }
}
