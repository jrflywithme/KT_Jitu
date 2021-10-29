using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blalogin.Data
{
    public class Dailyproduct
    {
        [Key]
        public int Sid { get; set; }
        public DateTime Date   { get; set; }
        public string Shift { get; set; }
        public int SmNo { get; set; }
        public int Code { get; set; }
        public string AgentName { get; set; }
        public string BMCM { get; set; }
        public int Cans { get; set; }
        public int Kgs { get; set; }
        public int Ltrs { get; set; }
        public int Fat { get; set; }
        public int CLR { get; set; }
        public int SNF { get; set; }
        public int FatKg { get; set; }
        public int SnfKg { get; set; }
        public string Weighment { get; set; }
        public string QcEntry { get; set; }
        public int QtyOrg { get; set; }
        public int FatOrg { get; set; }
        public int SnfOrg { get; set; }


    }
}
