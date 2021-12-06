using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dashboardTurismoPy.DTO
{
    public class users
    {
        private int idUser;
        private string rut;
        private string firstName;
        private string lastNameP;
        private string lastNameM;
        private string dob;
        private string mail;
        private int phone;
        private string pass;
        private string idCommune;
        private string nameCommune;
        private int idType;
        private string nameType;

        public users() { }
        public users(int idUser, string rut, string firstName, string lastNameP, string lastNameM, string dob, string mail, int phone, string pass, string idCommune, string nameCommune, int idType, string nameType)
        {
            this.IdUser = idUser;
            this.Rut = rut;
            this.FirstName = firstName;
            this.LastNameP = lastNameP;
            this.LastNameM = lastNameM;
            this.Dob = dob;
            this.Mail = mail;
            this.Phone = phone;
            this.Pass = pass;
            this.IdCommune = idCommune;
            this.NameCommune = nameCommune;
            this.IdType = idType;
            this.NameType = nameType;
        }

        public int IdUser { get => idUser; set => idUser = value; }
        public string Rut { get => rut; set => rut = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastNameP { get => lastNameP; set => lastNameP = value; }
        public string LastNameM { get => lastNameM; set => lastNameM = value; }
        public string Dob { get => dob; set => dob = value; }
        public string Mail { get => mail; set => mail = value; }
        public int Phone { get => phone; set => phone = value; }
        public string Pass { get => pass; set => pass = value; }
        public string IdCommune { get => idCommune; set => idCommune = value; }
        public string NameCommune { get => nameCommune; set => nameCommune = value; }
        public int IdType { get => idType; set => idType = value; }
        public string NameType { get => nameType; set => nameType = value; }
    }
}
