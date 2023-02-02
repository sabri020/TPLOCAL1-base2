﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text.RegularExpressions;
using TPLOCAL1.Models;
using System.Reflection;

//L'énoncé du tp et le logo hn sont livrés dans le répertoire /ressources de la solution
//--------------------------------------------------------------------------------------
//Attention, le modèle MVC est un modèle dit de convention plutot que configuration, 
//Le controller doit donc obligatoirement se nommer avec "Controller" à la fin!!!
namespace TPLOCAL1.Controllers
{
    public class HomeController : Controller
    {

        // méthode appelée par la routeur "naturellement"
        public ActionResult Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                //renvoie vers la vue Index (voir routage dans RouteConfig.cs)
                return View();
            else
            {
                //en fonction du paramètre id, on appelle les différentes pages
                switch (id)
                {
                    case "ListeAvis":
                        //reste à faire : coder la lecture du fichier xml fourni
                        ListeAvis avisDonnes = new ListeAvis();

                        return View(id, avisDonnes.GetAvis(Server.MapPath("~/FichierXML/DataAvis.xml"))) ;
                    case "Formulaire":
                      
                        //reste à faire : appeler la vue Formulaire avec le modèle de données vide
                        return View(id);
                    default:
                        //renvoie vers Index (voir routage dans RouteConfig.cs)
                        return View();
                }
            }
        }

      
        //méthode pour envoyer les données du formulaire vers la page de validation
        [HttpPost]
        public ActionResult ValidationFormulaire(FormulaireModel modelv)
        {
            if (modelv.Sexe == "Sélectionner un sexe")
            {
                ModelState.AddModelError("", "Merci de vérifier le Sexe");
            }

            if (modelv.FormationASuivire == "Sélectionner une formation")
            {
                ModelState.AddModelError("", "Merci de vérifier le Type de Formation");
            }




            if (!ModelState.IsValid)
            {
                return View("Formulaire");
            }
            //reste à faire : tester de si les champs du modele sont bien remplis
            //s'ils ne sont pas bien remplis, afficher une erreur et rester sur la page formulaire
            //sinon, appeler la page ValidationFormulaire avec les données remplies par l'utilisateur
            return View(modelv);
        }
    }
}