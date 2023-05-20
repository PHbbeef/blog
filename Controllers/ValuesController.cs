using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace WebApi.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "你好世界！";
        }

        [HttpGet]
        public string Getname(string name)
        {
            return "你好" + name;
        }

        [HttpGet]
        public string Login(string user, string password)
        {
            if (user == "admin" && password == "20050211")
            {
                return "登录成功！";
            }
            else
            {
                return "密码或账户错误";
            }
        }
    }
}
