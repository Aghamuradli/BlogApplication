using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Dtos
{
    public class CategoryUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [DisplayName("Kategoriya Adı")]
        [Required(ErrorMessage = "Kategoriya adı boş olmamalıdır.")]
        [MaxLength(70, ErrorMessage = "{0} {1} karakterdən böyük olmamalıdır.")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterdən az olmamalıdır.")]
        public string Name { get; set; }
        [DisplayName("Kategoriya Açıqlaması")]
        [MaxLength(500, ErrorMessage = "{0} {1} karakterdən böyük olmamalıdır.")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterdən olmamalıdır.")]
        public string Description { get; set; }
        [DisplayName("Kategoriya Özəl Not Yeri.")]
        [MaxLength(500, ErrorMessage = "{0} {1} karakterdən böyük olmamalıdır.")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterdən az olmamalıdır.")]
        public string Note { get; set; }
        [DisplayName("Aktivdirmi?")]
        [Required(ErrorMessage = "Kategoriya adı boş olmamalıdır.")]
        public bool IsActive { get; set; }
        [DisplayName("Silindimi?")]
        [Required(ErrorMessage = "Kategoriya adı boş olmamalıdır.")]
        public bool IsDeleted { get; set; }
    }
}
