﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace ShopM4_Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DisplayName("Display Order")]
        [Range(1,int.MaxValue,ErrorMessage ="Value must be more than 0")]
        public int DisplayOrder { get; set; }
    }
}
