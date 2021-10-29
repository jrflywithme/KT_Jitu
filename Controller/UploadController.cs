using blalogin.Data;
using ExcelDataReader;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace blalogin.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        private readonly IWebHostEnvironment environment;
        public UploadController(IWebHostEnvironment environment)
        {
            this.environment = environment;
        }


        [HttpPost]
        public async Task Post()
        {
            if (HttpContext.Request.Form.Files.Any())
            {
                foreach (var file in HttpContext.Request.Form.Files)
                {
                    var path = Path.Combine(environment.ContentRootPath, "uploads", file.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
            }
        }

       
        // [HttpPost]
        public void ReadExcelFile(string fileName)
        {
            List<Route> routs = new List<Route>();
            //var fileName = "./Users.xlsx";
            // For .net core, the next line requires the NuGet package, 
            // System.Text.Encoding.CodePages
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using (var stream = System.IO.File.Open(fileName, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {

                    while (reader.Read()) //Each row of the file
                    {
                        routs.Add(new Route
                        {
                            Id = Convert.ToInt32(reader.GetValue(0)),
                            Routename = reader.GetValue(1).ToString(),
                            Supervisorname = reader.GetValue(2).ToString(),
                            Billdays = Convert.ToInt32(reader.GetValue(3)),
                            Code = Convert.ToInt32(reader.GetValue(4))
                        });
                    }
                }
            }
            //return View(users);
        }
    }
}
