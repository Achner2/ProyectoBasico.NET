using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.SignalR;

namespace WebApplication1.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int id { get; init;}
        [Required (ErrorMessage = "El nombre es obligatorio")]
        private string name { get; set; }
        [EmailAddress (ErrorMessage = "Asegurate de que sea una direccion de Email")]
        private string email { get; set; }
        [PasswordPropertyText(true)]
        private string password { get; set; }
        [Phone (ErrorMessage = "El mensaje es incorrecto vuelve a digitar el numero de telefono")]
        private string phone { get; set; }
    }
}
