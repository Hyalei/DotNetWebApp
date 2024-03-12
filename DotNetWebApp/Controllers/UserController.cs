using DotNetWebApp.DataAccess;
using DotNetWebApp.Entity;
using Microsoft.AspNetCore.Mvc;

namespace DotNetWebApp.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public string Init()
        {
            using (DataContext db = new DataContext("Data.db"))
            {
                db.Database.EnsureCreated(); // 自动建库，若已存在，不做任何事情

                for (var i = 0; i < 5; i++)
                {
                    db.Add(new Student
                    {
                        Guid=Guid.NewGuid().ToString().ToUpper(),
                        Name="Test"+i.ToString(),
                        Age=10 + i * 5
                    });
                }
                db.SaveChanges();

                var students = db.Students;
                foreach (var student in students)
                {
                    Console.WriteLine(student);
                }
            }

            return "初始化成功";
        }
    }
}
