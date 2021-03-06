﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MonicaMatricula.Dominio
{
    public class Professor
    {

        public Professor()
        {
            Disciplinas = new Collection<Disciplina>();
        }
        public int ProfessorId { get; set; }

        [Required(ErrorMessage = "Nome do Professor é obrigatório.")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Habilidades do Professor é obrigatório.")]
        [Display(Name = "Habilidades")]
        public string Habilidades { get; set; }

        [Required(ErrorMessage = "Sálario do Professor é obrigatório.")]
        [Display(Name = "Salário")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Column(TypeName = "money")]
        public decimal Salario { get; set; }

        public ICollection<Disciplina> Disciplinas { get; set; }
    }
}
