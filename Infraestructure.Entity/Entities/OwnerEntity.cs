using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Entity.Entities
{

    [ExcludeFromCodeCoverage]
    [Table("Owner", Schema = "dbo")]
    public class OwnerEntity : AuditEntity
    {


        [Key]
        [Description("Owner Id ")]
        [Column("IdOwner", TypeName = "int")]
        public int IdOwner { get; set; }


        [Description("Name Owner")]
        [Column("Name", TypeName = "varchar(400)")]
        public string NameOwner { get; set; }

        [Description("Address Owner ")]
        [Column("Address", TypeName = "varchar(2000)")]
        public string AddressOwner { get; set; }


        [Description("Photo Owner ")]
        [Column("Photo", TypeName = "varchar(2000)")]
        public string Photo { get; set; }


        [Column("Birthday", TypeName = "datetime2(7)")]
        public DateTime Birthday { get; set; }


        

    }
}
