using FoodOrder.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace FoodOrder.ViewModels
{
    public class KategoriyaViewModel
    {
        [Required]
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Nomi { get; set; }


        public static explicit operator Kategoriya(KategoriyaViewModel v)
        {
            return new Kategoriya()
            {
                Id = v.Id,
                Nomi = v.Nomi,
                Mahsulotlar = null
            };
        }
    }
}
