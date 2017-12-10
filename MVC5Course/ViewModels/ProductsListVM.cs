using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace MVC5Course.ViewModels
{
    public class ProductsListVM
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "請輸入商品名稱")]
        public string ProductName { get; set; }

        [Required]
        [Range(0, 999, ErrorMessage = "商品金額只能0 ~ 999")]
        public Nullable<decimal> Price { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:#}")]
        public Nullable<decimal> Stock { get; set; }
    }
}