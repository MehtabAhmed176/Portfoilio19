using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Portfoilio19.Models
{
   
       
  
    /// <summary>  
    /// Email notification view model class.  
    /// </summary>  
    public class EmailNotifyViewModel
    {
        #region Properties  

        /// <summary>  
        /// Gets or sets to email address.  
        /// </summary>  
        [Required]
        [Display(Name = "To (Email Address)")]
        public string ToEmail { get; set; }

        #endregion
    }
}