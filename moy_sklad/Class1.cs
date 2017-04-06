using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moy_sklad
{

    public class Rootobject
    {
        public Context context { get; set; }
        public Meta1 meta { get; set; }
        public Row[] rows { get; set; }
    }

    public class Context
    {
        public Employee employee { get; set; }
    }

    public class Employee
    {
        public Meta meta { get; set; }
    }

    public class Meta
    {
        public string href { get; set; }
        public string metadataHref { get; set; }
        public string type { get; set; }
        public string mediaType { get; set; }
    }

    public class Meta1
    {
        public string href { get; set; }
        public string metadataHref { get; set; }
        public string type { get; set; }
        public string mediaType { get; set; }
        public int size { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
    }

    public class Row
    {
        public Meta2 meta { get; set; }
        public string id { get; set; }
        public string accountId { get; set; }
        public Owner owner { get; set; }
        public bool shared { get; set; }
        public Group group { get; set; }
        public int version { get; set; }
        public string updated { get; set; }
        public string name { get; set; }
        public string externalCode { get; set; }
        public string moment { get; set; }
        public bool applicable { get; set; }
        public Rate rate { get; set; }
        public float sum { get; set; }
        public Store store { get; set; }
        public Agent agent { get; set; }
        public Organization organization { get; set; }
        public State state { get; set; }
        public Documents documents { get; set; }
        public string created { get; set; }
        public Positions positions { get; set; }
        public bool vatEnabled { get; set; }
        public bool vatIncluded { get; set; }
        public float vatSum { get; set; }
        public string deliveryPlannedMoment { get; set; }
        public float payedSum { get; set; }
        public float shippedSum { get; set; }
        public float invoicedSum { get; set; }
        public float reservedSum { get; set; }
    }

    public class Meta2
    {
        public string href { get; set; }
        public string metadataHref { get; set; }
        public string type { get; set; }
        public string mediaType { get; set; }
    }

    public class Owner
    {
        public Meta3 meta { get; set; }
    }

    public class Meta3
    {
        public string href { get; set; }
        public string metadataHref { get; set; }
        public string type { get; set; }
        public string mediaType { get; set; }
    }

    public class Group
    {
        public Meta4 meta { get; set; }
    }

    public class Meta4
    {
        public string href { get; set; }
        public string metadataHref { get; set; }
        public string type { get; set; }
        public string mediaType { get; set; }
    }

    public class Rate
    {
        public Currency currency { get; set; }
    }

    public class Currency
    {
        public Meta5 meta { get; set; }
    }

    public class Meta5
    {
        public string href { get; set; }
        public string metadataHref { get; set; }
        public string type { get; set; }
        public string mediaType { get; set; }
    }

    public class Store
    {
        public Meta6 meta { get; set; }
    }

    public class Meta6
    {
        public string href { get; set; }
        public string metadataHref { get; set; }
        public string type { get; set; }
        public string mediaType { get; set; }
    }

    public class Agent
    {
        public Meta7 meta { get; set; }
    }

    public class Meta7
    {
        public string href { get; set; }
        public string metadataHref { get; set; }
        public string type { get; set; }
        public string mediaType { get; set; }
    }

    public class Organization
    {
        public Meta8 meta { get; set; }
    }

    public class Meta8
    {
        public string href { get; set; }
        public string metadataHref { get; set; }
        public string type { get; set; }
        public string mediaType { get; set; }
    }

    public class State
    {
        public Meta9 meta { get; set; }
    }

    public class Meta9
    {
        public string href { get; set; }
        public string type { get; set; }
        public string mediaType { get; set; }
    }

    public class Documents
    {
        public Meta10 meta { get; set; }
    }

    public class Meta10
    {
        public string href { get; set; }
        public string mediaType { get; set; }
        public int size { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
    }

    public class Positions
    {
        public Meta11 meta { get; set; }
    }

    public class Meta11
    {
        public string href { get; set; }
        public string type { get; set; }
        public string mediaType { get; set; }
        public int size { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
    }

}
