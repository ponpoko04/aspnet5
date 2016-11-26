using Microsoft.AspNet.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IdentityWebApplication.Models
{
    public class User : IUser<string>
    {
        public string Id { get; set; }

        [DisplayName("ユーザー名")]
        [Required]
        public string UserName { get; set; }

        [DisplayName("パスワード")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("メモ")]
        public string Memo { get; set; }
    }
}