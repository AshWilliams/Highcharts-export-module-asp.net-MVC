using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tek4.Highcharts.Exporting;

namespace Exporting_MVC_Demo.Controllers
{
    public class ChartController : Controller
    {
        [HttpPost, ValidateInput(false)]
        public ActionResult Export(string filename, string type, string svg, int width = 0)
        {
            if (filename != null && type != null && svg != null)
            {
                // Create a new chart export object using form variables.
                Exporter export = new Exporter(filename, type, width, svg, "Segoe UI");

                // Write the exported chart to the HTTP Response object.
                export.WriteToHttpResponse(HttpContext.Response);

                // Finish request
                Response.OutputStream.Flush();
                HttpContext.ApplicationInstance.CompleteRequest();
            }
            return new EmptyResult();
        }

    }
}
