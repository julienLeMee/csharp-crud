using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_crud.Models;

public class Image
{
	public int Id { get; set; }

	public string Name { get; set; }

	public string Path { get; set; }

	[NotMapped] // permet de ne pas créer de colonne dans la base de données
	[Display (Name = "Image")] // permet de changer le nom de l'attribut dans le formulaire
	public IFormFile File { get; set; } // permet de récupérer le fichier

	public int FruitId { get; set; }

	public virtual Fruit Fruit { get; set; }

}
