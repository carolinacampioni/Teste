using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebSite.Models
{
    /// <summary>
    /// Classe de Modelo de Resultado
    /// </summary>
    public class ResultadoModel
    {
        /// <summary>
        /// Palavra
        /// </summary>
        [Required]
        public string Palavra { get; set; }

        /// <summary>
        /// Resultado
        /// </summary>
        public string Retorno { get; set; }

        

    }
}