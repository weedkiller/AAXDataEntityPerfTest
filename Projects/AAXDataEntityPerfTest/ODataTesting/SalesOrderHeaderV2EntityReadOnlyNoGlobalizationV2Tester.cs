﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AuthenticationUtility;
using Microsoft.OData.Client;
using Microsoft.Dynamics.DataEntities;

using System.Web;
using System.Data;
using System.IO;

using System.Diagnostics;

namespace ODataTesting
{
    public class SalesOrderHeaderV2EntityReadOnlyNoGlobalizationTester : SalesOrderTester
    {
        public static string logTemplate = "";

        public static void runOneRead(Resources context, string filePath, TestType testType, TestWorkload testWorkload, string SalesOrderNumber, string DataAreaId)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            SalesOrderHeaderV2EntityReadOnlyNoGlobalization SalesOrderHeaderV2EntityReadOnlyNoGlobalization = context.SalesOrderHeadersV2EntityReadOnlyNoGlobalization.Where(x => x.SalesOrderNumber == SalesOrderNumber && x.dataAreaId == DataAreaId).First();

            sw.Stop();

            StreamWriter stream = File.AppendText(filePath);

            stream.WriteLine("SalesOrderHeaderV2EntityReadOnlyNoGlobalization," + testType + "," + testWorkload + "," + sw.Elapsed.TotalMilliseconds.ToString());
            stream.Flush();
            stream.Close();

        }

 
    }
}
