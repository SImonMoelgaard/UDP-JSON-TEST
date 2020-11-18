using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;
using UDP_Test;
using System.Xml;

namespace UDP_WPF
{
    public class GetData
    {

        private const int listenPort = 11000;
        public Movie LoadData()
        {
            bool done = false;
            UdpClient listener = new UdpClient(listenPort);
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, listenPort);
            string received_data;
            byte[] receive_byte_array;
            Movie movie1 = null;
            try
            {
                
                    receive_byte_array = listener.Receive(ref groupEP);
                    received_data = Encoding.ASCII.GetString(receive_byte_array, 0, receive_byte_array.Length);
                    movie1 = JsonConvert.DeserializeObject<Movie>(received_data);

            }
            catch (Exception e)
            {
               // return movie1 = new Movie({ Name="NaN",Year=0};
                //Console.WriteLine(e.ToString());
            }
            listener.Close();
                    return movie1;
            
        }
    } // end of class UDPListener
}
