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
    [Table("Property", Schema = "dbo")]
    public class PropertyEntity : AuditEntity
    {

        [Key]
        [Description("Id Property ")]
        [Column("IdProperty", TypeName = "int")]
        public int IdProperty { get; set; }


        [Description("Name Property")]
        [Column("Name", TypeName = "varchar(250)")]
        public string NameProperty { get; set; }

        [Description("Address Property")]
        [Column("Address", TypeName = "varchar(2000)")]
        public string AddressProperty { get; set; }


        [Description("Price Property")]
        [Column("Price", TypeName = "decimal(22,4)")]
        public decimal Price { get; set; }


        [Description("Code International")]
        [Column("CodeInternational", TypeName = "varchar(100)")]
        public string CodeInternational { get; set; }

        [Description("Year")]
        [Column("Year", TypeName = "int")]
        public int Year { get; set; }


        [ForeignKey("ownerEntity")]
        [Description("Owner Id ")]
        [Column("IdOwner", TypeName = "int")]
        public int IdOwner { get; set; }

        #region FK


        public OwnerEntity ownerEntity { get; set; }

        #endregion


    }
}
