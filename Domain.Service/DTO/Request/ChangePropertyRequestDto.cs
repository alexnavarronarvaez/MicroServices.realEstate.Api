using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.DTO.Request
{
    public class ChangePropertyRequestDto
    {

        public int IdProperty { get; set; }

        public decimal Price { get; set; }

    }
}
