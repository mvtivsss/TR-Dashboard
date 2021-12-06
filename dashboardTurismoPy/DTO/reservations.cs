using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dashboardTurismoPy.DTO
{
    public class reservations
    {
        private int id;
        private string planifiedCheckIn;
        private string checkIn;
        private string checkOut;
        private int totalDays;
        private int totalAdults;
        private int totalKids;
        private int totalReserve;
        private string statusReserve;
        private int departmentId;
        private int clientId;
        private int workerId;
        private string departmentName;
        private string departmentAddress;
        private int totalRooms;
        private int totalParking;
        private int totalBaths;
        private char internet;
        private char tv;
        private char heating;
        private char furnished;
        private int departmentPrice;
        private char departmentStatus;
        private string departmentDesc;
        private string idCommune;

        public reservations() { }

        public reservations(int id, string planifiedCheckIn, string checkIn, string checkOut, int totalDays, int totalAdults, int totalKids, int totalReserve, string statusReserve, int departmentId, int clientId, int workerId, string departmentName, string departmentAddress, int totalRooms, int totalParking, int totalBaths, char internet, char tv, char heating, char furnished, int departmentPrice, char departmentStatus, string departmentDesc, string idCommune)
        {
            this.Id = id;
            this.PlanifiedCheckIn = planifiedCheckIn;
            this.CheckIn = checkIn;
            this.CheckOut = checkOut;
            this.TotalDays = totalDays;
            this.TotalAdults = totalAdults;
            this.TotalKids = totalKids;
            this.TotalReserve = totalReserve;
            this.StatusReserve = statusReserve;
            this.DepartmentId = departmentId;
            this.ClientId = clientId;
            this.WorkerId = workerId;
            this.DepartmentName = departmentName;
            this.DepartmentAddress = departmentAddress;
            this.TotalRooms = totalRooms;
            this.TotalParking = totalParking;
            this.TotalBaths = totalBaths;
            this.Internet = internet;
            this.Tv = tv;
            this.Heating = heating;
            this.Furnished = furnished;
            this.DepartmentPrice = departmentPrice;
            this.DepartmentStatus = departmentStatus;
            this.DepartmentDesc = departmentDesc;
            this.IdCommune = idCommune;
        }

        public int Id { get => id; set => id = value; }
        public string PlanifiedCheckIn { get => planifiedCheckIn; set => planifiedCheckIn = value; }
        public string CheckIn { get => checkIn; set => checkIn = value; }
        public string CheckOut { get => checkOut; set => checkOut = value; }
        public int TotalDays { get => totalDays; set => totalDays = value; }
        public int TotalAdults { get => totalAdults; set => totalAdults = value; }
        public int TotalKids { get => totalKids; set => totalKids = value; }
        public int TotalReserve { get => totalReserve; set => totalReserve = value; }
        public string StatusReserve { get => statusReserve; set => statusReserve = value; }
        public int DepartmentId { get => departmentId; set => departmentId = value; }
        public int ClientId { get => clientId; set => clientId = value; }
        public int WorkerId { get => workerId; set => workerId = value; }
        public string DepartmentName { get => departmentName; set => departmentName = value; }
        public string DepartmentAddress { get => departmentAddress; set => departmentAddress = value; }
        public int TotalRooms { get => totalRooms; set => totalRooms = value; }
        public int TotalParking { get => totalParking; set => totalParking = value; }
        public int TotalBaths { get => totalBaths; set => totalBaths = value; }
        public char Internet { get => internet; set => internet = value; }
        public char Tv { get => tv; set => tv = value; }
        public char Heating { get => heating; set => heating = value; }
        public char Furnished { get => furnished; set => furnished = value; }
        public int DepartmentPrice { get => departmentPrice; set => departmentPrice = value; }
        public char DepartmentStatus { get => departmentStatus; set => departmentStatus = value; }
        public string DepartmentDesc { get => departmentDesc; set => departmentDesc = value; }
        public string IdCommune { get => idCommune; set => idCommune = value; }
    }
}
