using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace TPLOCAL1.Models
{
    public class FormulaireModel
    {
        [Display(Name = "Nom")]
        [Required(ErrorMessage = "Merci de vérifier le Nom")]
        public string Nom { get; set; }

        [Display(Name = "Prénom")]
        [Required(ErrorMessage = "Merci de vérifier le Prénom")]
        public string Prenom { get; set; }

        [Display(Name = "Sexe")]
        [Required(ErrorMessage = "Merci de vérifier le Sexe")]
        public string Sexe { get; set; }


        [Display(Name = "Adresse")]
        [Required(ErrorMessage = "Merci de vérifier l'Adresse")]
        public string Adresse { get; set; }

        [Display(Name = "Code Postal")]
        [Required(ErrorMessage = "Merci de vérifier le Code Postal")]
        [RegularExpression(@"^[0-9]{5}$", ErrorMessage = "Code Postal doit être sur 5 caractères numériques ")]
        public string Cpostal { get; set; }

        [Display(Name = "Ville")]
        [Required(ErrorMessage = "Merci de vérifier la Ville")]
        public string Ville { get; set; }

        [Display(Name = "Adresse Mail")]
        [Required(ErrorMessage = "L'adresse email n'est pas valide")]
        [RegularExpression(@"^([\w]+)@([\w]+)\.([\w]+)$")]
        public string Email { get; set; }


        [Display(Name = "Date début formation")]
        [Required(ErrorMessage = "La date doit être inférieure au  01 / 01 / 2021")]
        [Range(typeof(DateTime), "1/1/2011", "1/1/2021")]
        public string DateF { get; set; }

        [Display(Name = "Formation Suivie")]
        [Required(ErrorMessage = "Merci de vérifier le Type de Formation")]
        public string FormationASuivire { get; set; }




        [Display(Name = "Formation Cobol")]
        public string Fcobol { get; set; }

        [Display(Name = "Formation C#")]
        public string Csharp { get; set; }
    }
}