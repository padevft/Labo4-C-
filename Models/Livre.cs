using System;
using System.Collections.Generic;

namespace Labo4.Models;

public partial class Livre
{
    public int Id { get; set; }

    public string Titre { get; set; } = null!;

    public int IdAuteur { get; set; }

    public int Annee { get; set; }

    public int Pages { get; set; }

    public string Categorie { get; set; } = null!;
}
