using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class User
    {
        [DisplayName("Ten dang nhap")]
        [Required(ErrorMessage ="bat buoc nhap tendang nhap")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Ten dang nhap phai tu 3 den 50 ky tu")]
        public string UserName { get; set; }
        [DisplayName("Dia chi email")]
        [Required(ErrorMessage ="bat buoc nhap email")]
        [EmailAddress(ErrorMessage ="email khong hop le")]
        public string Email { get; set; }
        [DisplayName("mat khau")]
        [Required(ErrorMessage ="bat buoc nhap mat khau")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "mat khau phai co it nhat 6 ky tu")]
        public string Password { get; set; }
        [DisplayName("xac thuc mat khau")]
        [Required(ErrorMessage = "bat buoc nhap xac thuc mat khau")]
        [Compare("Password", ErrorMessage = "mat khau xac thuc khong khop")]
        public string ConfirmPassword { get; set; }
    }
}
