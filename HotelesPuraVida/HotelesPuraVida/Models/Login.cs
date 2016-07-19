using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelesPuraVida.Models
{
    public class Login
    {
        [Key]
        public int UserID { get; set; }
        [Required(ErrorMessage="Ingrese el Nombre")]
        public string Name { get; set; }
        [Required(ErrorMessage="Ingrese el Email")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",ErrorMessage="Error al ingresar el Email")]
        public string Email { get; set; }

        [Required(ErrorMessage="Ingrese numero de Telefono")]
        public int Phone { get; set; }
        [Required(ErrorMessage="Ingrese la Contraseña")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Por favor verifique su Contraseña")]
        [DataType(DataType.Password)]
        public string ConfirmPasword { get; set; }

        
    }
}