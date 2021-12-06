using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using dashboardTurismoPy.DTO;

namespace dashboardTurismoPy.Shared
{
    public static class RestHelper
    {
        private static readonly string baseUrl = "http://localhost:4000/api/";

        public static async Task<List<departments>> getAllDepartments()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseUrl + "departments"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            var objJson = JObject.Parse(data);
                            //Console.WriteLine(objJson["departments"]);
                            List<departments> list = new List<departments>();
                            foreach (var item in objJson["departments"])
                            {

                                list.Add(new departments(item["address"].ToString(), item["departmentDesc"].ToString(), Convert.ToInt32(item["departmentPrice"]),
                                                         item["departmentStatus"].ToString(), item["furnished"].ToString(), item["heating"].ToString(), Convert.ToInt32(item["id"]),
                                                         item["idCommune"].ToString(), item["internet"].ToString(), item["name"].ToString(), item["nameCommune"].ToString(),
                                             Convert.ToInt32(item["totalBaths"]), Convert.ToInt32(item["totalPärking"]), Convert.ToInt32(item["totalRooms"]), Convert.ToInt32(item["tv"])));

                                //Console.WriteLine();

                                //foreach(departments jToken in list)
                                //{
                                //    Console.WriteLine(jToken.Price);
                                //}

                            }
                            return list;
                        }
                    }
                }
            }
            return new List<departments>();
        }

        public static async Task<List<reservations>> getAllReserves()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseUrl + "reserve"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            var objJson = JObject.Parse(data);
                            List<reservations> list = new List<reservations>();
                            foreach (var item in objJson["reserves"])
                            {
                                list.Add(new reservations(Convert.ToInt32(item["id"]), item["planifiedCheckIn"].ToString(), item["checkIn"].ToString(), item["checkOut"].ToString(),
                                                          Convert.ToInt32(item["totalDays"]), Convert.ToInt32(item["totalAdults"]), Convert.ToInt32(item["totalKids"]), Convert.ToInt32(item["totalReserve"]),
                                                          item["statusReserve"].ToString(), Convert.ToInt32(item["departmentId"]), Convert.ToInt32(item["clientId"]), Convert.ToInt32(item["workerId"]), item["departmentName"].ToString(),
                                                          item["departmentAdress"].ToString(), Convert.ToInt32(item["totalRooms"]), Convert.ToInt32(item["totalParking"]), Convert.ToInt32(item["totalBaths"]),
                                                          Convert.ToChar(item["internet"]), Convert.ToChar(item["tv"]), Convert.ToChar(item["heating"]), Convert.ToChar(item["furnished"]), Convert.ToInt32(item["departmentPrice"]),
                                                          Convert.ToChar(item["departmentStatus"]), item["departmentDesc"].ToString(), item["idCommune"].ToString()));
                            }
                            return list;
                        }
                    }
                }
            }
            return new List<reservations>();
        }

        public static async Task<List<users>> getAllUsers()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseUrl + "users"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            var objJson = JObject.Parse(data);
                            List<users> list = new List<users>();
                            foreach (var item in objJson["users"])
                            {
                                list.Add(new users(Convert.ToInt32(item["id"]), item["rut"].ToString(), item["firstName"].ToString(),
                                                   item["lastNameP"].ToString(), item["lastNameM"].ToString(), item["dateOfBirth"].ToString(),
                                                   item["mail"].ToString(), Convert.ToInt32(item["phone"]), item["pass"].ToString(), item["idCommune"].ToString(),
                                                   item["nameCommune"].ToString(), Convert.ToInt32(item["idType"]), item["nameType"].ToString()));
                            }
                            return list;
                        }
                    }
                }
            }
            return new List<users>();
        }

        //public static async Task<List<Estadisticas>> getallStadistics()
        //{

        //}

        public static string BeautifyJson(string jsonStr)
        {
            JToken parseJson = JToken.Parse(jsonStr);
            return parseJson.ToString(Formatting.Indented);
        }

        public static string CountJson(string jsonStr)
        {
            JObject jObj = (JObject)JsonConvert.DeserializeObject(jsonStr);
            int count = jObj.Count;
            return Convert.ToString(count);
        }
    }
}
