using System.Collections.Generic;
using System.Web.Http;

namespace LearningWebApiApp.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public string Get()
        {
            return "Sample local API string Data to display in the UI";
        }       
    }
}
