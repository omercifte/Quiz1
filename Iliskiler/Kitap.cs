﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GRSYKitapEvi_Model.Models
{
    [Table("tb_Kitap")]
    public class Kitap
    {
        [Key]
        public int Kitap_Id { get; set; }
        [Required]
        public string KitapAdi { get; set; }
        [Required]
        public double Fiyat { get; set; }
        [Required]
        [MaxLength(13)]
        public string ISBN { get; set; }
        [ForeignKey("Kategori")]
        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }
        [ForeignKey("KitapDetay")]
        public int KitapDetay_Id { get; set; }
        public KitapDetay KitapDetay { get; set; }
    }
}