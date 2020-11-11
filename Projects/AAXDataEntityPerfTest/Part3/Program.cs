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

using ODataTesting;


namespace Part3
{
    class Program
    {
        public static string ODataEntityPath = ClientConfiguration.Default.UriString + "data";

        public static string filePath = @"c:\temp\part3.txt";

        static void Main(string[] args)
        {
            Uri oDataUri = new Uri(ODataEntityPath, UriKind.Absolute);
            var context = new Resources(oDataUri);


            context.BuildingRequest += (sender, e) =>
            {
                var uriBuilder = new UriBuilder(e.RequestUri);
                // Requires a reference to System.Web and .NET 4.6.1+
                var paramValues = HttpUtility.ParseQueryString(uriBuilder.Query);
                if (paramValues.GetValues("cross-company") == null)
                {
                    paramValues.Add("cross-company", "true");
                    uriBuilder.Query = paramValues.ToString();
                    e.RequestUri = uriBuilder.Uri;
                }
            };


            context.SendingRequest2 += new EventHandler<SendingRequest2EventArgs>(delegate (object sender, SendingRequest2EventArgs e)
            {
                var authenticationHeader = OAuthHelper.GetAuthenticationHeader(useWebAppAuthentication: true);
                e.RequestMessage.SetHeader(OAuthHelper.OAuthHeader, authenticationHeader);
            });


            StreamWriter stream = File.CreateText(filePath);
            stream.WriteLine("Entity,TestType, Workload, Duration");
            stream.Flush();
            stream.Close();

            Console.WriteLine("Starting...");

            SalesValues values;

            #region SalesOrderHeaderV2 Tests
            Console.WriteLine("Starting SalesOrderHeaderV2 Tests");
            //random read
            for (int i = 0; i < 100; i++)
            {
                values = SalesOrderHeaderV2Tester.getRandomCombination();
                SalesOrderHeaderV2Tester.runOneRead(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }

            //fixed read
            values = SalesOrderHeaderV2Tester.getRandomCombination();
            for (int i = 0; i < 100; i++)
            {
                SalesOrderHeaderV2Tester.runOneRead(context, filePath, SalesOrderTester.TestType.Repetitive, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }

            //random 10 reads
            for (int i = 0; i < 100; i++)
            {
                values = SalesOrderHeaderV2Tester.getCustomerAccountsWithMoreThan10Orders();
                SalesOrderHeaderV2Tester.runReads(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read10, values.DataAreaId, values.CustAccount, 10);
            }

            //fixed 10 read
            values = SalesOrderHeaderV2Tester.getCustomerAccountsWithMoreThan10Orders();
            for (int i = 0; i < 100; i++)
            {
                SalesOrderHeaderV2Tester.runReads(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read10, values.DataAreaId, values.CustAccount, 10);
            }
            #endregion

            #region SalesOrderheaderV2ReadOnly Tests
            Console.WriteLine("Starting SalesOrderheaderV2ReadOnly Tests");
            //random read
            for (int i = 0; i < 100; i++)
            {
                values = SalesOrderHeaderV2EntityReadOnlyTester.getRandomCombination();
                SalesOrderHeaderV2EntityReadOnlyTester.runOneRead(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }

            //fixed read
            values = SalesOrderHeaderV2EntityReadOnlyTester.getRandomCombination();
            for (int i = 0; i < 100; i++)
            {
                SalesOrderHeaderV2EntityReadOnlyTester.runOneRead(context, filePath, SalesOrderTester.TestType.Repetitive, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }

            //random 10 reads
            for (int i = 0; i < 100; i++)
            {
                values = SalesOrderHeaderV2EntityReadOnlyTester.getCustomerAccountsWithMoreThan10Orders();
                SalesOrderHeaderV2EntityReadOnlyTester.runReads(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read10, values.DataAreaId, values.CustAccount, 10);
            }

            //fixed 10 read
            values = SalesOrderHeaderV2EntityReadOnlyTester.getCustomerAccountsWithMoreThan10Orders();
            for (int i = 0; i < 100; i++)
            {
                SalesOrderHeaderV2EntityReadOnlyTester.runReads(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read10, values.DataAreaId, values.CustAccount, 10);
            }
            #endregion

            #region SalesOrderHeaderV2EntityReadOnlyNoGlobalization Tests
            Console.WriteLine("Starting SalesOrderHeaderV2EntityReadOnlyNoGlobalization Tests");
            //random read
            for (int i = 0; i < 100; i++)
            {
                values = SalesOrderHeaderV2EntityReadOnlyNoGlobalizationTester.getRandomCombination();
                SalesOrderHeaderV2EntityReadOnlyNoGlobalizationTester.runOneRead(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }

            //repetitive read
            values = SalesOrderHeaderV2EntityReadOnlyNoGlobalizationTester.getRandomCombination();
            for (int i = 0; i < 100; i++)
            {
                SalesOrderHeaderV2EntityReadOnlyNoGlobalizationTester.runOneRead(context, filePath, SalesOrderTester.TestType.Repetitive, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }

            //random 10 reads
            for (int i = 0; i < 100; i++)
            {
                values = SalesOrderHeaderV2EntityReadOnlyNoGlobalizationTester.getCustomerAccountsWithMoreThan10Orders();
                SalesOrderHeaderV2EntityReadOnlyNoGlobalizationTester.runReads(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read10, values.DataAreaId, values.CustAccount, 10);
            }

            //fixed 10 read
            values = SalesOrderHeaderV2EntityReadOnlyNoGlobalizationTester.getCustomerAccountsWithMoreThan10Orders();
            for (int i = 0; i < 100; i++)
            {
                SalesOrderHeaderV2EntityReadOnlyNoGlobalizationTester.runReads(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read10, values.DataAreaId, values.CustAccount, 10);
            }
            #endregion

            #region SalesOrderHeaderV2EntityOnlySalesTable Tests
            Console.WriteLine("Starting SalesOrderHeaderV2EntityOnlySalesTable Tests");
            //random
            for (int i = 0; i < 100; i++)
            {
                values = SalesOrderHeaderV2EntityOnlySalesTableTester.getRandomCombination();
                SalesOrderHeaderV2EntityOnlySalesTableTester.runOneRead(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }

            //repetitive
            values = SalesOrderHeaderV2EntityOnlySalesTableTester.getRandomCombination();
            for (int i = 0; i < 100; i++)
            {
                SalesOrderHeaderV2EntityOnlySalesTableTester.runOneRead(context, filePath, SalesOrderTester.TestType.Repetitive, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }

            //random 10 reads
            for (int i = 0; i < 100; i++)
            {
                values = SalesOrderHeaderV2EntityOnlySalesTableTester.getCustomerAccountsWithMoreThan10Orders();
                SalesOrderHeaderV2EntityOnlySalesTableTester.runReads(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read10, values.DataAreaId, values.CustAccount, 10);
            }

            //fixed 10 read
            values = SalesOrderHeaderV2EntityOnlySalesTableTester.getCustomerAccountsWithMoreThan10Orders();
            for (int i = 0; i < 100; i++)
            {
                SalesOrderHeaderV2EntityOnlySalesTableTester.runReads(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read10, values.DataAreaId, values.CustAccount, 10);
            }
            #endregion

            #region SalesOrderHeaderV2EntityDSReadOnly Tests
            Console.WriteLine("Starting SalesOrderHeaderV2EntityDSReadOnly Tests");
            //random
            for (int i = 0; i < 100; i++)
            {
                values = SalesOrderHeaderV2EntityDSReadOnlyTester.getRandomCombination();
                SalesOrderHeaderV2EntityDSReadOnlyTester.runOneRead(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }

            //repetitive
            values = SalesOrderHeaderV2EntityDSReadOnlyTester.getRandomCombination();
            for (int i = 0; i < 100; i++)
            {
                SalesOrderHeaderV2EntityDSReadOnlyTester.runOneRead(context, filePath, SalesOrderTester.TestType.Repetitive, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }

            //random 10 reads
            for (int i = 0; i < 100; i++)
            {
                values = SalesOrderHeaderV2EntityDSReadOnlyTester.getCustomerAccountsWithMoreThan10Orders();
                SalesOrderHeaderV2EntityDSReadOnlyTester.runReads(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read10, values.DataAreaId, values.CustAccount, 10);
            }

            //fixed 10 read
            values = SalesOrderHeaderV2EntityDSReadOnlyTester.getCustomerAccountsWithMoreThan10Orders();
            for (int i = 0; i < 100; i++)
            {
                SalesOrderHeaderV2EntityDSReadOnlyTester.runReads(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read10, values.DataAreaId, values.CustAccount, 10);
            }
            #endregion

            #region AAXSalesTable Tests
            Console.WriteLine("Starting AAXSalesTable Tests");
            //random
            for (int i = 0; i < 100; i++)
            {
                values = AAXSalesTableEntityTester.getRandomCombination();
                AAXSalesTableEntityTester.runOneRead(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }

            //repetitive
            values = AAXSalesTableEntityTester.getRandomCombination();
            for (int i = 0; i < 100; i++)
            {
                AAXSalesTableEntityTester.runOneRead(context, filePath, SalesOrderTester.TestType.Repetitive, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }
            //random 10 reads
            for (int i = 0; i < 100; i++)
            {
                values = AAXSalesTableEntityTester.getCustomerAccountsWithMoreThan10Orders();
                AAXSalesTableEntityTester.runReads(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read10, values.DataAreaId, values.CustAccount, 10);
            }

            //fixed 10 read
            values = AAXSalesTableEntityTester.getCustomerAccountsWithMoreThan10Orders();
            for (int i = 0; i < 100; i++)
            {
                AAXSalesTableEntityTester.runReads(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read10, values.DataAreaId, values.CustAccount, 10);
            }
            #endregion

            #region AAXSalesTableEntityReadOnly Tests
            Console.WriteLine("Starting AAXSalesTableEntityReadOnly Tests");
            //random
            for (int i = 0; i < 100; i++)
            {
                values = AAXSalesTableEntityReadOnlyTester.getRandomCombination();
                AAXSalesTableEntityReadOnlyTester.runOneRead(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }

            //repetitive
            values = AAXSalesTableEntityReadOnlyTester.getRandomCombination();
            for (int i = 0; i < 100; i++)
            {
                AAXSalesTableEntityReadOnlyTester.runOneRead(context, filePath, SalesOrderTester.TestType.Repetitive, SalesOrderTester.TestWorkload.Read, values.SalesId, values.DataAreaId);
            }
            //random 10 reads
            for (int i = 0; i < 100; i++)
            {
                values = AAXSalesTableEntityReadOnlyTester.getCustomerAccountsWithMoreThan10Orders();
                AAXSalesTableEntityReadOnlyTester.runReads(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read10, values.DataAreaId, values.CustAccount, 10);
            }

            //fixed 10 read
            values = AAXSalesTableEntityReadOnlyTester.getCustomerAccountsWithMoreThan10Orders();
            for (int i = 0; i < 100; i++)
            {
                AAXSalesTableEntityReadOnlyTester.runReads(context, filePath, SalesOrderTester.TestType.Random, SalesOrderTester.TestWorkload.Read10, values.DataAreaId, values.CustAccount, 10);
            }
            #endregion

            Console.WriteLine("Complete. Press enter.");
            Console.ReadLine();


        }
    }
}
