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
        public string strname { get; set; }
        [Required]
        [StringLength(200)]
        public string tel { get; set; }
        public DateTime creattime { get; set; }
    }
}