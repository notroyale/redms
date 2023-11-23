using HtmlAgilityPack;
using System.Net;
using System.Xml.Linq;
namespace RealEstateDataTool.Service
{
    public class WebScraperService: IWebScraperService
    {

        public string GetData()
        {

            string targetUrl = "TestData/testAd.html";
            HttpClientHandler handler = new HttpClientHandler
            {
                UseProxy = true,
            };

            HtmlDocument doc = new HtmlDocument();
            doc.Load(Path.Combine(Directory.GetCurrentDirectory(), targetUrl));

            using (HttpClient client = new HttpClient(handler))
            {
                client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.3");
                try
                {
                    string xpathExpression = "//dt"; ;
                    HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes(xpathExpression);

                    if (nodes != null)
                    {
                        foreach (HtmlNode node in nodes)
                        {
                            string dtText = node.InnerText.Trim();
                            Console.Write($"{dtText}: ");
                            HtmlNode ddNode = node.SelectSingleNode("following-sibling::dd[1]");
                            if (ddNode != null)
                            {
                                string ddText = ddNode.InnerText.Trim();
                                Console.WriteLine(ddText);
                            }
                            else
                            {
                                Console.WriteLine("No corresponding <dd> element found.");

                            }

                        }
                    }
                    else
                    {
                        Console.WriteLine("No data found.");
                    }
                    //}
                    //else
                    //{
                    //    Console.WriteLine($"Request failed with status code: {response.StatusCode}");
                    //}
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
                return null;
            }

        }
    }
}
