using Microsoft.AspNetCore.Mvc;

namespace Api
{
    public class ValuesController : Controller
    {

        [HttpGet]
        [Route("/back")]
        public string Back()
        {
            DateTime time = DateTime.Now;
            var res = time.ToString();
            return res;
        }

    }
}
