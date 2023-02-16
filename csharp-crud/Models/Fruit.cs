using System;
namespace csharp_crud.Models;

public class Fruit
{

    public int Id { get; set; } // get permet de récupérer la valeur de l'attribut, set permet de modifier la valeur de l'attribut

    [StringLength (50, MinimumLength = 3)] // permet de limiter la taille de la chaine de caractère
    [Required] // permet de rendre l'attribut obligatoire
    [Display (Name = "Nom")] // permet de changer le nom de l'attribut dans le formulaire
    public string Name { get; set; }

    public string? Description { get; set; } // ? permet de rendre l'attribut facultatif

    public virtual Image Image { get; set; }

    [Column (TypeName = "decimal(3, 2)")] // permet de préciser que lon veut une colonne de type decimal avec 3 chiffres avant la virgule et 2 chiffres après la virgule
    [DataType (DataType.Currency)] // permet d'informer le formulaire que l'attribut est un prix
    [Range (0, 100)] // permet de limiter la valeur de l'attribut
    [Required]
    [Display (Name = "Prix")]
    public decimal Price { get; set; }

}
