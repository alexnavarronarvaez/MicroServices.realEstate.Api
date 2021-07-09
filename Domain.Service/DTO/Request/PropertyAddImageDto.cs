using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.DTO.Request
{
    public class PropertyAddImageDto
    {

        public int IdProperty { get; set; }
        public string imageBase64 { get; set; }

        public string TypeFile { get; set; }

    }
}
