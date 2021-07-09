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
    [Table("PropertyTrace", Schema = "dbo")]
    public class PropertyTraceEntity : AuditEntity
    {

        [Key]
        [Description("Id Property Trace ")]
        [Column("IdPropertyTrace", TypeName = "int")]
        public int IdPropertyTrace { get; set; }



        [ForeignKey("propertyEntity")]
        [Description("Id Property ")]
        [Column("IdProperty", TypeName = "int")]
        public int IdProperty { get; set; }



        [Description("Name Property Trace")]
        [Column("Name", TypeName = "varchar(250)")]
        public string NamePropertyTrace { get; set; }


        [Description("Value Property Trace")]
        [Column("Value", TypeName = "decimal(22,4)")]
        public decimal Value { get; set; }


        [Description("Tax Property Trace")]
        [Column("Tax", TypeName = "decimal(22,4)")]
        public decimal Tax { get; set; }



        #region FK


        public PropertyEntity propertyEntity { get; set; }

        #endregion


    }
}
