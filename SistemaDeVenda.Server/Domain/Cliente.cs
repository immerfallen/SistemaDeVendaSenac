﻿namespace SistemaDeVenda.Server.Domain
{
    using System;   
    using System.ComponentModel.DataAnnotations;


    public class Cliente
    {
        public int Id { get; set; }

        [MaxLength(255)]
        public string Nome { get; set; }

        [MaxLength(14)]
        public string CPF_CNPJ { get; set; }

        [MaxLength(45)]
        public string Email { get; set; }

        [MaxLength(10)]
        public string Senha { get; set; }
    }
}