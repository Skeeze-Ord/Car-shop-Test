using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop2.Data.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }

        [Display(Name = "Введите имя")]
        [StringLength(25)]
        [Required(ErrorMessage = "Некорректный ввод имени")]
        public string Name { get; set; }

        [Display(Name = "Введите фамилию")]
        [StringLength(25)]
        [Required(ErrorMessage = "Некорректный ввод фамилии")]
        public string Surname { get; set; }

        [Display(Name = "Введите адрес")]
        [StringLength(35)]
        [Required(ErrorMessage = "Некорректный ввод адреса")]
        public string Adress { get; set; }

        [Display(Name = "Введите номер телефона")]
        [StringLength(11)]
        [Required(ErrorMessage = "Некорректный ввод номера. Недостаточно символов")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Display(Name = "Введите адрес электронной почты")]
        [StringLength(35)]
        [Required(ErrorMessage = "Некорректный ввод почты")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

    }
}
