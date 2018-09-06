using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEBAPI.REST.Models
{
    public class Estabelecimento
    {
        /// <summary>
        /// Adiciona um número para IDentificação do estabelecimento no banco de dados
        /// </summary>
        public int IdEstabelecimento { get; set; }
        /// <summary>
        /// Nome do estabelecimento
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Bairro onde o estabelecimento se encontra
        /// </summary>
        public string Bairro { get; set; }
        /// <summary>
        /// Região onde o estabelecimento se encontra
        /// </summary>
        public string Regiao { get; set; }
    }
}