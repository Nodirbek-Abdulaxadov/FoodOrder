using FoodOrder.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace FoodOrder.ViewModels
{
    public class MahsulotViewModel
    {
        [Required]
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nomi { get; set; }

        public string Batafsil { get; set; }
        [Required]
        public double Narxi { get; set; }
        //[Required]
        //public byte[] Rasmi { get; set; }
        [Required]
        public Guid KategoriyaId { get; set; }
        public static explicit operator Mahsulot(MahsulotViewModel v)
        {
            return new Mahsulot()
            {
                Id = v.Id,
                Nomi = v.Nomi,
                Batafsil = v.Batafsil,
                Narxi = v.Narxi,
                KategoriyaId = v.KategoriyaId
            };
        }
    }
}
