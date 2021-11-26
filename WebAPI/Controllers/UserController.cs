using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getall")]
        public IActionResult Getall()
        {
            var result = _userService.GetAll();
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest("Herhangi bir kullanıcı bulunmamaktadır.");
        }


        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            if (user!=null)
            {
                _userService.Add(user);
                return Ok("Kullanıcı Eklendi");
            }

            return BadRequest("Girilen kullanıcı bilgilerinde ekikler vardır kontrol ediniz.");
        }


        [HttpDelete("delete")]
        public IActionResult Delete(User user)
        {
            if (user != null)
            {
                _userService.Delete(user);
                return Ok("Kullanıcı Silindi");
            }

            return BadRequest("Girilen kullanıcı id'sine ait bir kayıt bulunmamaktadır. Silinemedi...");
        }

        [HttpPut("update")]
        public IActionResult Update(User user)
        {
            if (user != null)
            {
                _userService.Update(user);
                return Ok("Kullanıcı güncellendi");
            }

            return BadRequest("Girilen kullanıcı id'sine ait bir kayıt bulunmamaktadır. Güncellenemedi...");
        }







    }
}
