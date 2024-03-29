#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using Projet_bibliotheque.Classes;
using Projet_bibliotheque.Acces;
#endregion

namespace Projet_bibliotheque.Gestion
{
 /// <summary>
 /// Couche intermédiaire de gestion (Business Layer)
 /// </summary>
 public class G_TB_categorie : G_Base
 {
  #region Constructeurs
  public G_TB_categorie()
   : base()
  { }
  public G_TB_categorie(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string Nom, Int16 Pegi)
  { return new A_TB_categorie(ChaineConnexion).Ajouter(Nom, Pegi); }
  public int Modifier(int ID_categorie, string Nom, Int16 Pegi)
  { return new A_TB_categorie(ChaineConnexion).Modifier(ID_categorie, Nom, Pegi); }
  public List<C_TB_categorie> Lire(string Index)
  { return new A_TB_categorie(ChaineConnexion).Lire(Index); }
  public C_TB_categorie Lire_ID(int ID_categorie)
  { return new A_TB_categorie(ChaineConnexion).Lire_ID(ID_categorie); }
  public int Supprimer(int ID_categorie)
  { return new A_TB_categorie(ChaineConnexion).Supprimer(ID_categorie); }
 }
}
