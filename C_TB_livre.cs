#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace Projet_bibliotheque.Classes
{
 /// <summary>
 /// Classe de définition des données
 /// </summary>
 public class C_TB_livre
 {
  #region Données membres
  private int _ID_livre;
  private string _titre;
  private string _auteur;
  private int? _ID_categorie;
  private Int16 _statut;
  private int? _Ann_pub;
  #endregion
  #region Constructeurs
  public C_TB_livre()
  { }
  public C_TB_livre(string titre_, string auteur_, int? ID_categorie_, Int16 statut_, int? Ann_pub_)
  {
   titre = titre_;
   auteur = auteur_;
   ID_categorie = ID_categorie_;
   statut = statut_;
   Ann_pub = Ann_pub_;
  }
  public C_TB_livre(int ID_livre_, string titre_, string auteur_, int? ID_categorie_, Int16 statut_, int? Ann_pub_)
   : this(titre_, auteur_, ID_categorie_, statut_, Ann_pub_)
  {
   ID_livre = ID_livre_;
  }
  #endregion
  #region Accesseurs
  public int ID_livre
  {
   get { return _ID_livre; }
   set { _ID_livre = value; }
  }
  public string titre
  {
   get { return _titre; }
   set { _titre = value; }
  }
  public string auteur
  {
   get { return _auteur; }
   set { _auteur = value; }
  }
  public int? ID_categorie
  {
   get { return _ID_categorie; }
   set { _ID_categorie = value; }
  }
  public Int16 statut
  {
   get { return _statut; }
   set { _statut = value; }
  }
  public int? Ann_pub
  {
   get { return _Ann_pub; }
   set { _Ann_pub = value; }
  }
  #endregion
 }
}
