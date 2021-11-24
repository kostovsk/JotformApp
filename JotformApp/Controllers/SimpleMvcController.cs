using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace JotformApp.Controllers
{
    public class SimpleMvcController : Controller
    {
        private readonly ILogger<SimpleMvcController> _logger;

        public SimpleMvcController(ILogger<SimpleMvcController> logger)
        {
            _logger = logger;
        }

        [Route("SimpleMvc/SaveDataToDb")]
        [HttpPost]
        [HttpGet]
        public async Task<IActionResult> SaveDataToDb()
        {
            //string theContent = string.Empty;
            //using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            //{
            //    theContent = await reader.ReadToEndAsync();
            //}

            var formData = new List<KeyValuePair<string, string>>();

            foreach (var key in Request.Form.Keys)
            {
                formData.Add(new KeyValuePair<string, string>(key, Request.Form[key]));
            }


            var putABreakPointHere = formData;

            return View("~/Views/SimpleMvc/Confirmation.cshtml");
        }
    }
}
