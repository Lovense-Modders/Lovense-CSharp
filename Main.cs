using LovenseAPI.Toys;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LovenseAPI
{
    public static class Lovense
    {
        private static string domain;
        private static HttpClient client = new();

        public static bool Request(string url, Dictionary<string, dynamic>? parameters)
        {
            string none;
            return Request(url, parameters, out none);
        }
        public static bool Request(string url, Dictionary<string, dynamic>? parameters, out string body)
        {
            bool found = Connect();

            if (found)
            {
                try
                {
                    StringBuilder sb = new("?");

                    foreach (KeyValuePair<string, dynamic> param in parameters)
                    {
                        string value = Convert.ToString(param.Value);

                        sb.Append(param.Key);
                        sb.Append("=");
                        sb.Append(value);
                        sb.Append("&");
                    }

                    HttpResponseMessage msg = client.Send(new(HttpMethod.Get, domain + url + sb.ToString()));
                    StreamReader reader = new(msg.Content.ReadAsStream());
                    body = reader.ReadToEnd();
                    
                    return true;
                }
                catch (HttpRequestException)
                {
                    body = "";
                    return false;
                }
            }
            else
            {
                body = "";
                return false;
            }
        }

        public static bool Connect()
        {
            try
            {
                // 20010 port found
                client.Send(new(HttpMethod.Get, domain != null ? domain : "http://127-0-0-1.lovense.club:20010"));
                domain = "http://127-0-0-1.lovense.club:20010/";

                return true;
            }
            catch (HttpRequestException)
            {
                try
                {
                    // 20011 port found
                    client.Send(new(HttpMethod.Get, domain != null ? domain : "http://127-0-0-1.lovense.club:20011"));
                    domain = "http://127-0-0-1.lovense.club:20011/";

                    return true;
                }
                catch (HttpRequestException)
                {
                    return false;
                }
            }
        }

        public static Toy[] GetToys()
        {
            bool found = Connect();

            if (found)
            {
                HttpRequestMessage req = new(HttpMethod.Get, domain + "GetToys");
                HttpResponseMessage msg = client.Send(req);
                StreamReader reader = new(msg.Content.ReadAsStream());

                ToysResponse resp = JsonConvert.DeserializeObject<ToysResponse>(reader.ReadToEnd());
                List<Toy> toys = new();

                foreach (Toy toy in resp.data.Values)
                {
                    switch (toy.name)
                    {
                        case "Ambi":
                            toys.Add(new Ambi());
                            break;

                        case "Diamo":
                            toys.Add(new Diamo());
                            break;

                        case "Domi":
                            toys.Add(new Domi());
                            break;

                        case "Edge":
                            toys.Add(new Edge());
                            break;

                        case "Ferri":
                            toys.Add(new Ferri());
                            break;

                        case "Hush":
                            toys.Add(new Hush());
                            break;

                        case "Lush":
                            toys.Add(new Lush());
                            break;

                        case "Max":
                            toys.Add(new Max());
                            break;

                        case "Mission":
                            toys.Add(new Mission());
                            break;

                        case "Nora":
                            toys.Add(new Nora());
                            break;

                        case "Osci":
                            toys.Add(new Osci());
                            break;

                        case "Quake":
                            toys.Add(new Quake());
                            break;

                        default:
                            toys.Add(new Toy());
                            break;
                    }
                }

                return toys.ToArray();
            } else {
                return null;
            }
        }
    }
}
