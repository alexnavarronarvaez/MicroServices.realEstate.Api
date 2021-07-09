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
    [Table("PropertyImage", Schema = "dbo")]
    public class PropertyImageEntity
    {

        [Key]
        [Description("Id Property Image")]
        [Column("IdPropertyImage", TypeName = "int")]
        public int IdPropertyImage { get; set; }


        [ForeignKey("propertyEntity")]
        [Description("Id Property ")]
        [Column("IdProperty", TypeName = "int")]
        public int IdProperty { get; set; }




        [Description("Type File")]
        [Column("TypeFile", TypeName = "varchar(10)")]
        public string TypeFile { get; set; }



        [Description("File")]
        [Column("File", TypeName = "varchar(MAX)")]
        public string File { get; set; }



        [Description("Enabled")]
        [Column("Enabled", TypeName = "bit")]
        public bool Enabled { get; set; }


        #region FK


        public PropertyEntity propertyEntity { get; set; }

        #endregion


    }
}
