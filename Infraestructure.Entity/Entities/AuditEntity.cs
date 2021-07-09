using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Entity.Entities
{

    [ExcludeFromCodeCoverage]
    public class AuditEntity
    {

        [Column("CreationDate", TypeName = "datetime2(7)")]
        public DateTime CreationDate { get; set; }

        public string CreationUser { get; set; }

        [Column("ModificationDate", TypeName = "datetime2(7)")]
        public DateTime? ModificationDate { get; set; }

        public string ModificationUser { get; set; }



    }
}
