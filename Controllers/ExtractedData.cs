using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Electrification.ABB.SDK.Connector.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExtractedData : ControllerBase
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
