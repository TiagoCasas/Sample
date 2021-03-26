using nanoFramework.WebServer;
using System;
using System.Diagnostics;
using System.Net;

//nanoff --update --target ESP32_WROOM_32 --serialport COM3

namespace HelloWorld
{
    /// <summary>
    /// The API controller
    /// </summary>
    [Authentication("Basic:a 1")]
    public class ApiController
    {

        [Route("helloworld")]
        public void HelloWorld(WebServerEventArgs e)
        {
            Debug.WriteLine("Hello World!");
            try
            {
                WebServer.OutPutStream(e.Context.Response, "Hello World!");
            }
            catch (Exception)
            {
                WebServer.OutputHttpCode(e.Context.Response, HttpStatusCode.BadRequest);
            }
        }

    }
}
