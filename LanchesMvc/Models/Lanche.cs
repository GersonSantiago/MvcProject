using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMvc.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage ="O nome do lanche deve ser informado!")]
        [Display(Name ="Nome do lanche")]
        [MaxLength(80, ErrorMessage ="O nome deve ter no máximo 80 caracteres!")]
        [MinLength(10, ErrorMessage = "O nome deve ter no mínimo 10 caracteres!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição do lanche deve ser informada!")]
        [Display(Name = "Descrição do lanche")]
        [MaxLength(200, ErrorMessage = "A descrição deve ter no máximo 200 caracteres!")]
        [MinLength(20, ErrorMessage = "A descrição deve ter no mínimo 20 caracteres!")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "A descrição do lanche deve ser informada!")]
        [Display(Name = "Descrição detalhada do lanche")]
        [MaxLength(200, ErrorMessage = "A descrição deve ter no máximo 200 caracteres!")]
        [MinLength(20, ErrorMessage = "A descrição deve ter no mínimo 20 caracteres!")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage ="Informe o preço do lanche")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1,999.99,ErrorMessage ="O preço deve estar entre 1 e 999,99")]
        public decimal Preco { get; set; }

        [Display(Name ="Caminho Imagem Normal")]
        [MaxLength(200, ErrorMessage = "O caminho da imagem deve ter no máximo 200 caracteres!")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho Imagem Miniatura")]
        [MaxLength(200, ErrorMessage = "O caminho da imagem deve ter no máximo 200 caracteres!")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name ="Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name ="Estoque")]
        public bool EmEstoque { get; set; }


        public int CategoriId { get; set; }
        public virtual Categoria Categoria { get; set; }


    }
}
