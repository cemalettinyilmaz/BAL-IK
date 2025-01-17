﻿using BAL_IK.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL_IK.Model
{
    public class MolaTur
    {
        [Key]
        public int MolaTurId { get; set; }
        [MaxLength(30)]
        public string MolaTuru { get; set; }
        public List<Mola> Molalar { get; set; }
        public double MolaSuresi { get; set; }
        public int SirketId { get; set; }
        public Sirket Sirket { get; set; }
    }
}
