using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exporting_Demo.Controllers
{
    public class GraphController : Controller
    {
        public ActionResult Export()
        {
            ExportChart.ProcessExportRequest(context);
        }
    }
}