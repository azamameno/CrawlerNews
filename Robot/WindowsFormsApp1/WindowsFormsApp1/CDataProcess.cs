using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class CDataProcess
    {
        static public bool ProcessData(string sHttp)
        {
            bool ret = false;
            try
            {
                WebClient client = new WebClient();
                string downloadedString = client.DownloadString(sHttp);

                ret = true;
            }
            catch(Exception ex)
            { }
            return ret;
        }
    }
}
