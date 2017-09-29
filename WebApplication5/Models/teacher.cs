using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class teacher
    {
        public int id { get; set; }

        [Required]

        [StringLength(200)]
        [Display(Name ="姓名")]
        public string strname { get; set; }
        [Required]
        [StringLength(200)]
        [Display(Name ="电话")]
        public string tel { get; set; }
        [Display(Name ="创建时间")]
        public DateTime creattime { get; set; }
    }
}