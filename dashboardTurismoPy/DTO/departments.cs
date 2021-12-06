using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dashboardTurismoPy.DTO
{
    public class departments
    {
        private string address;
        private string departmentDesc;
        private int price;
        private string departmentStatus;
        private string furnished;
        private string heating;
        private int id;
        private string idCommune;
        private string internet;
        private string name;
        private string nameCommune;
        private int totalBaths;
        private int totalParking;
        private int totalRooms;
        private int tv;


        public departments() {
            JObject jObject = new JObject();
            this.Name = (string)jObject["name"];
        }

        public departments(string address, string departmentDesc, int price, string departmentStatus, string furnished, string heating, int id, string idCommune, string internet, string name, string nameCommune, int totalBaths, int totalParking, int totalRooms, int tv)
        {
            this.Address = address;
            this.DepartmentDesc = departmentDesc;
            this.Price = price;
            this.DepartmentStatus = departmentStatus;
            this.Furnished = furnished;
            this.Heating = heating;
            this.Id = id;
            this.IdCommune = idCommune;
            this.Internet = internet;
            this.Name = name;
            this.NameCommune = nameCommune;
            this.TotalBaths = totalBaths;
            this.TotalParking = totalParking;
            this.TotalRooms = totalRooms;
            this.Tv = tv;
        }

        public string Address { get => address; set => address = value; }
        public string DepartmentDesc { get => departmentDesc; set => departmentDesc = value; }
        public int Price { get => price; set => price = value; }
        public string DepartmentStatus { get => departmentStatus; set => departmentStatus = value; }
        public string Furnished { get => furnished; set => furnished = value; }
        public string Heating { get => heating; set => heating = value; }
        public int Id { get => id; set => id = value; }
        public string IdCommune { get => idCommune; set => idCommune = value; }
        public string Internet { get => internet; set => internet = value; }
        public string Name { get => name; set => name = value; }
        public string NameCommune { get => nameCommune; set => nameCommune = value; }
        public int TotalBaths { get => totalBaths; set => totalBaths = value; }
        public int TotalParking { get => totalParking; set => totalParking = value; }
        public int TotalRooms { get => totalRooms; set => totalRooms = value; }
        public int Tv { get => tv; set => tv = value; }
    }
}
