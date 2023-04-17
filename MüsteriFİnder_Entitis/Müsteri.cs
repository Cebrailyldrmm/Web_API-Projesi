using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MüsteriFİnder_Entitis
{
    public class Müsteri
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int İd { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Soyad { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Ürün { get; set; }


    }
}