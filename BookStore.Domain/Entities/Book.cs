using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BookStore.Domain.Entities
{
    public class Book
    {
        [Key]
        [HiddenInput(DisplayValue =false)]
        public int BookId { get; set; }
        [Display(Name="Название")]
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Количество")]
        public int Quantity { get; set; }
        [Display(Name = "Автор")]
        public string Author { get; set; }
        [Display(Name = "Цена (руб)")]
        public decimal Price { get; set; }
    }
}
