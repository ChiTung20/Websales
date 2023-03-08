using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;



namespace DA.Models
{
    public partial class Product
    {
        //public Product() 1233333
        //{
        //    Thumb = "~/adminassets/img/products/avater.jpg";
        //}
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ShortDesc { get; set; }
        public string Description { get; set; }
        public int? CateId { get; set; }
        public int? Price { get; set; }
        public int? Discount { get; set; }
        [DisplayName("Image")]
        public string Thumb { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public string Video { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateModified { get; set; }
        public string BestSalers { get; set; }
        public bool HomeFlag { get; set; }
        public bool Active { get; set; }
        public bool Tags { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public string MetaDesc { get; set; }
        public string MetaKey { get; set; }

        [DisplayName("Tồn Kho")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        public int? UnitslnStock { get; set; }

        public virtual ProductCategory Cate { get; set; }

    }
}