﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MinhaDieta.Models.Entidades
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Senha { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        public string Genero { get; set; }

        [Required]
        public string Email { get; set; }
    }   
}