using Microsoft.AspNetCore.Mvc;
using System.IO;

public class FileController : Controller
{
    public IActionResult DownloadCV()
    {
        var filePath = Path.Combine(Directory.GetCurrentDirectory(),
                                    "wwwroot/files/cv.pdf");

        var fileBytes = System.IO.File.ReadAllBytes(filePath);

        return File(fileBytes, "application/pdf", "Tufan_Eser_CV.pdf");
    }
}
