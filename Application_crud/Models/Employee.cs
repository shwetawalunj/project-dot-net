using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;


namespace Application_crud.Models
{
    public class Employee
    {
        [Key]
        [Required]
        [DisplayName("EMP ID")]
        public int Id { get; set; }
        [Required]
        [DisplayName("ProductName")]
        public string ProductName { get; set; }
        [Required]
        [DisplayName("ProductId")]
        public int ProductId { get; set; }
        [Required]
        [DisplayName("CategoryId")]
        public int CategoryId { get; set; }
        [Required]
        [DisplayName("CategoryName")]
        public string CategoryName { get; set; }
        
        }
}