using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GenerateQRCode.Models
{
    public class GenerateQRCodeModel
    {
        [Display(Name = "Enter QR Code Text")]
        public string QRCodeText
        {
            get;
            set;
        }
    }
}
