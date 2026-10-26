using System.ComponentModel.DataAnnotations;

namespace DMQ_MyAppMVC.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Display(Name = "Họ tên")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Họ tên phải từ 4 đến 100 ký tự.")]
        [Required(ErrorMessage = "Họ tên là bắt buộc.")]
        public string? Name { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email bắt buộc nhập.")]
        [RegularExpression(@"^[A-Za-z0-9._%+-]+@gmail\.com$", ErrorMessage = "Địa chỉ email phải có đuôi gmail.com.")]
        public string? Email { get; set; }

        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu là bắt buộc.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",
            ErrorMessage = "Mật khẩu từ 8 ký tự trở lên, có ký tự viết hoa, viết thường, chữ số và ký tự đặc biệt.")]
        public string? Password { get; set; }

        [Display(Name = "Ngành")]
        [Required(ErrorMessage = "Vui lòng chọn ngành.")]
        public Branch? Branch { get; set; }

        [Display(Name = "Giới tính")]
        [Required(ErrorMessage = "Vui lòng chọn giới tính.")]
        public Gender? Gender { get; set; }

        [Display(Name = "Hệ chính quy")]
        public bool IsRegular { get; set; }

        [Display(Name = "Địa chỉ")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Địa chỉ là bắt buộc.")]
        public string? Address { get; set; }

        [Display(Name = "Ngày sinh")]
        [Range(typeof(DateTime), "1963-01-01", "2005-12-31", ErrorMessage = "Ngày sinh phải nằm trong khoảng từ năm 1963 đến 2005.")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Ngày sinh là bắt buộc.")]
        public DateTime? DateOfBorth { get; set; }

        [Display(Name = "Điểm")]
        [Required(ErrorMessage = "Điểm bắt buộc nhập.")]
        [Range(0.0, 10.0, ErrorMessage = "Điểm phải là số thực từ 0.0 đến 10.0.")]
        public float? Score { get; set; }
    }
}