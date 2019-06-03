using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Portfoilio19.Models
{
    public class DataClasses
    {
        public int Id { get; set; }
       
        public String FileName { get; set; }
        public byte[] FileContent { get; set; }
    }
}