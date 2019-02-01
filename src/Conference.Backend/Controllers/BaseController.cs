using System.IO;
using System.Net;
using System.Text;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace Conference.Backend.Controllers
{
    public class BaseController : ApiController
    {
        protected void SendToOneSignal(string message)
        {
            var request = WebRequest.Create("https://onesignal.com/api/v1/notifications") as HttpWebRequest;

            request.KeepAlive = true;
            request.Method = "POST";
            request.ContentType = "application/json; charset=utf-8";

            request.Headers.Add("authorization", "Basic ZjdlZTE4NDQtNDhiOS00Njc2LWI4YzgtODhiZWZkNGRjYzA1");

            var serializer = new JavaScriptSerializer();
            var obj = new
            {
                app_id = "c233a844-5672-49d8-8440-88c7b8d63233",
                contents = new { en = message },
                included_segments = new string[] { "All" }
            };
            var param = serializer.Serialize(obj);
            byte[] byteArray = Encoding.UTF8.GetBytes(param);

            string responseContent = null;

            try
            {
                using (var writer = request.GetRequestStream())
                {
                    writer.Write(byteArray, 0, byteArray.Length);
                }

                using (var response = request.GetResponse() as HttpWebResponse)
                {
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        responseContent = reader.ReadToEnd();
                    }
                }
            }
            catch (WebException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(new StreamReader(ex.Response.GetResponseStream()).ReadToEnd());
            }

            System.Diagnostics.Debug.WriteLine(responseContent);
        }
    }
}
