using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BulkyBookweb.Models
{
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [key]
        
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage ="Display Order can be between 1 to 100 only!!")]
        public int DisplayOrder { get; set; }

        public DateTime  CreatedDateTime { get; set; } = DateTime.Now;
    }
}
