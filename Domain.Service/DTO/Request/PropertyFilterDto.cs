using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.DTO.Request
{
    public class PropertyFilterDto
    {

        public int IdProperty { get; set; }
        public string NameProperty { get; set; }
        public string AddressProperty { get; set; }
        public decimal Price { get; set; }
        public string CodeInternational { get; set; }
        public int Year { get; set; }
        public int IdOwner { get; set; }

    }
}
