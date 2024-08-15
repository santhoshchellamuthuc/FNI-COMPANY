using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNI_Libray
{
  public   class FNImodel
    {
        [Key]
        [Display(Name ="Userid:")]
        public long userid { get; set; }
        [Required]
        [Display(Name ="UserName:")]
        public string username { get; set; }
        [Required]
        [Display(Name ="Joining Date:")]
        [DisplayFormat(DataFormatString = "{0:dd:mm:yyyy}", ApplyFormatInEditMode = true)]
        public DateTime joindate { get; set; }
        [Required]
        [Display(Name="Year Of Experience:")]
        public int experience { get; set; }
        [Required]
        [Display(Name = "Current Location")]
        public string address { get; set; }
    }
}
