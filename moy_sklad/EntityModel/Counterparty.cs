using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moy_sklad.EntityModel
{
    public class Counterparty
    {
        public Meta meta { get; set; }
        public string id { get; set; }
        public string accountId { get; set; }
        public Owner owner { get; set; }
        public bool shared { get; set; }
        public Group group { get; set; }
        public int version { get; set; }
        public string updated { get; set; }
        public string name { get; set; }
        public string externalCode { get; set; }
        public bool archived { get; set; }
        public string created { get; set; }
        public string companyType { get; set; }
        public string legalTitle { get; set; }
        public string legalAddress { get; set; }
        public string inn { get; set; }
        public string kpp { get; set; }
        public Accounts accounts { get; set; }
        public string[] tags { get; set; }
        public Contactpersons contactpersons { get; set; }
        public string description { get; set; }
        public string code { get; set; }
        public string actualAddress { get; set; }
        public string ogrn { get; set; }
        public string okpo { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public string discountCardNumber { get; set; }
        public State state { get; set; }
    }
}
