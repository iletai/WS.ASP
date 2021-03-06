﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flower.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        public int PostID { set; get; }

        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(256)]
        [Required]
        public string TagID { set; get; }

       [ForeignKey("ProductID")]
       public virtual Product Product { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { set; get; }
    }
}