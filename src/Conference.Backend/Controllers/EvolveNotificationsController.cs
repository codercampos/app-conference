using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Azure.Mobile.Server.Config;
using System.Configuration;

namespace Conference.Backend.Controllers
{
    [MobileAppController]
    public class ConferenceNotificationsController : BaseController
    {
        // TODO may need some improve here
        public HttpResponseMessage Post(string pns, string password, [FromBody]string message)
        {
            HttpStatusCode ret = HttpStatusCode.InternalServerError;

            if (string.IsNullOrWhiteSpace(message) || password != ConfigurationManager.AppSettings["NotificationsPassword"])
                return Request.CreateResponse(ret);

            SendToOneSignal(message);

            ret = HttpStatusCode.OK;

            return Request.CreateResponse(ret);
        }
    }
}
