using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.DTO.Request
{
    public class ImagePropertyRequestDto
    {

        public int IdProperty { get; set; }
        public string TypeFile { get; set; }
        public string File { get; set; }
        public bool Enabled { get; set; }



    }
}
