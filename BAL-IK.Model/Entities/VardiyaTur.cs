﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL_IK.Model.Entities
{
    public class VardiyaTur
    {
        [Key]
        public int VardiyaTurId { get; set; }
        [MaxLength(30)]
        public string VardiyaTuru { get; set; }
        public DateTime VardiyaBaslangicTarihi { get; set; }
        public DateTime VardiyaBitisTarihi { get; set; }
        public List<Vardiyalar> Vardiyalar { get; set; }
        public int SirketId { get; set; }
        public Sirket Sirket { get; set; }

    }
}
