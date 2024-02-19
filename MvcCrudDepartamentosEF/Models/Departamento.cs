using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCrudDepartamentosEF.Models
{
    [Table("DEPT")]
    public class Departamento
    {
        [Key]
        [Column("DEPT_NO")]
        public int DeptNo { get; set; }

        [Column("DNOMBRE")]
        public string Dnombre { get; set; }

        [Column("LOC")]
        public string Localidad { get; set; }
    }
}
