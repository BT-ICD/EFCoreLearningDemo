using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreLearningDemo.Entities
{
    public class Dept
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
      
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Location is required")]
        [StringLength(20, ErrorMessage ="Location must be betweeb 5 and 20 characters", MinimumLength =5)]
        public string Loc { get; set; }

    }
}
