using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_SDK_Web_API_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExtractedDataController : ControllerBase
    {
        private static List<object> dataList = new List<object>();

        /// <summary>
        /// Get the platform data.
        /// </summary>
        [HttpGet]
        public List<object> GetData()
        {
            return dataList;
        }

        /// <summary>
        /// Export the platform data.
        /// </summary>
        /// <param name="platformData">An <see cref="List<object>"/> value that represents the platform data.</param>
        /// <returns>Returns the list of platform data.</returns>
        [HttpPost]
        [Route("export", Name = "ExportData")]
        public List<object> ExportData([FromBody] List<object> platformData)
        {
            dataList = platformData;
            return dataList;
        }
    }
}
