using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEBAPI.REST.Models
{
    public class Usuario
    {
        /// <summary>
        /// Adiciona um número para IDentificação do usuário no banco de dados
        /// </summary>
        public int IdUsuario { get; set; }
        /// <summary>
        /// Nome do usuário
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// E-mail do usuário
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Senha do usuário
        /// </summary>
        public string Senha { get; set; }
        /// <summary>
        /// RA do usuário
        /// </summary>
        public string RA { get; set; }
    }
}