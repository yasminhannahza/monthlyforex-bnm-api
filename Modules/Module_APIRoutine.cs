using monthlyforex_bnm_api.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using monthlyforex_bnm_api.Models;
using monthlyforex_bnm_api.Modules;

namespace monthlyforex_bnm_api
{
    partial class frmTestAPI
    {
        List<Rate> listRates;

        HttpClient client = new HttpClient()
        {
            Timeout = new TimeSpan(0, 0, 30)
        };

        private async Task HitBNMAPI_Routine(DateTime theDate, string theCurrency)
        {
            int theMonth = theDate.Month;
            int theYear = theDate.Year;

            string theURL = API.ForexAPI
                .Replace("*month", theMonth.ToString())
                .Replace("*currency", theCurrency)
                .Replace("*year", theYear.ToString());

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Remove("Accept");
            client.DefaultRequestHeaders.Add("Accept", @"application/vnd.BNM.API.v1+json");

            await UpdateConsole($"Hitting the BNM API to retrieve for the currency : {theCurrency} for {theDate.ToString("MMMM yyyy")}");

            listRates = new List<Rate>();

            try
            {
                HttpResponseMessage response = await client.GetAsync(theURL);

                string responseString = await response.Content.ReadAsStringAsync();


                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    ForexModel theForexResponse = JsonConvert.DeserializeObject<ForexModel>(responseString);

                    listRates = theForexResponse.data.rate;

                    responseString = JsonConvert.SerializeObject(theForexResponse, Formatting.Indented);

                    await UpdateConsole($"The received response from BNM:\r\n" +
                        $"{responseString}");
                }
                else
                {
                    await UpdateConsole($"The received response from BNM:\r\n" +
                        $"{responseString}");
                }

                await InternModules.SaveFile(responseString, $"{theCurrency} - {DateTime.Now.ToString("yyyyMMdd-HHmmssfff")}.txt");
            }
            catch (Exception ex)
            {
                await UpdateConsole("The HTTP Request to BNM has timed out!", ex);
            }

        }
    }
}
