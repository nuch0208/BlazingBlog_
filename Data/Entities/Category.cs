using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Blazingblog.data.entities
{
 public class Category
 {
    [Key]
    public int Id {get; set;}

    [Required, MaxLength(100), Unicode(false)]
    public string Name {get; set;}

    [Required, MaxLength(125), Unicode(false)]
    public string Slug {get; set;}
 }

}
 