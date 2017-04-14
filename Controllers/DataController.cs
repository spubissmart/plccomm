using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using Newtonsoft.Json;
using ActUtlTypeLib;
using System.Web.UI.HtmlControls;

namespace PLCReadApp.Controllers
{
    public class PLCReadController : ApiController
    {
        plcData plcData = new plcData();

        [HttpGet]
        public int[] readPLC(string address, int len, int station)
        {
            var plc = new ActUtlType();

            var plcaddr = address;
            plc.ActLogicalStationNumber = station;

            var iReturnCode = plc.Open();

            var data = new int[960];

            plc.ReadDeviceBlock(address, 960, out data[0]);

            plc.Close();

            return data;

        }
    }
}