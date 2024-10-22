using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace lr7.Controllers
{
    public class FileController : Controller
    {
        [HttpGet]
        public IActionResult DownloadFile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DownloadFile(string firstName, string lastName, string fileName)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(fileName))
            {
                ViewBag.Error = "Усі поля повинні бути заповнені.";
     
            }           return View();

            string fileContent = $"Ім'я: {firstName}\nПрізвище: {lastName}";
            byte[] fileBytes = Encoding.UTF8.GetBytes(fileContent);
            return File(fileBytes, "application/octet-stream", $"{fileName}.txt");
        }
    }
}
