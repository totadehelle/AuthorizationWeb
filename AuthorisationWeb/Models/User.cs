using System.Buffers.Text;
using System.ComponentModel.DataAnnotations;

namespace AuthorizationWeb.Models
{
    public class User
    {
        public long Id { get; set; }
        
        [Required(ErrorMessage ="Login cannot be empty!", AllowEmptyStrings =false)]
        public string login { get; set; }
        
        [Required(ErrorMessage ="Password was not entered!", AllowEmptyStrings =false)]
        public string password { get; set; }
        
        public string token { get; set; }
    }
}