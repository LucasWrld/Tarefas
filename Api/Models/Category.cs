usyng System.ComponentModel.DataAnnotations;

namespace tarefas.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage= "Este campo deve conter entre 3 e 60 caracteres")]
        
        public string Title { get; set; }
    }
}