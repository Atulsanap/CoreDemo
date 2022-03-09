using CoreDemo.Models;
using CoreDemo.Repository;
using CoreDemo.Services;
//using iTextSharp.text.pdf;
//using iTextSharp.text.pdf.parser;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Syncfusion.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using iText.Kernel.Pdf.Canvas.Parser;

namespace CoreDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;

        private readonly IConfiguration configure;

        protected IHomeService bookobj;
        public IActionResult Index()
        {
            return View();
        }

        public HomeController(IHomeService bookobj, ILogger<HomeController> logger, IConfiguration configure)
        {
            this.bookobj = bookobj;
            this.logger = logger;
            this.configure = configure;
        }

        //public HomeController()
        //{
        //}


        public async Task<IActionResult> ShowBooks()
        {
           List<Book> book=await bookobj.Allbooks();
            return View(book);
        }

        public async Task<IActionResult> AddorEdit(int? id)
        {
            if (id != null)
            {
                bookschoolvm vm = await bookobj.AddorEdit(id);
                return View(vm);

            }
            return View(); 
        }

        
        [HttpPost]
        public IActionResult AddorEdit(Book book)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bookobj.AddorEdit(book);
                    ViewBag.message = "Success";
                }
                return RedirectToAction("ShowBooks");
            }
            catch(Exception ex)
            {
                logger.LogError("",ex);
            }
            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Book book =await bookobj.Delete(id);
                return View(book);
            }
            catch(Exception ex)
            {
                logger.LogError("", ex);
            }
            return View();
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            bookobj.DeleteConfirmed(id);
            return RedirectToAction("ShowBooks");

        }

        public async Task<IActionResult> Details(int id)
        {
          
           Book book=await bookobj.Details(id);
            return View(book);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        //public IActionResult Bookdetails()
        //{
        //   var bk = _db.Books.ToList();
        //    return View(bk);
        //}


        
        public ActionResult SearchbyName()
        {
            var newname = configure.GetSection("NewBookAlert");
            var name = configure.GetValue<bool>("DisplayNewBookAlert");
            var bookname = newname.GetValue<string>("BookName");



            var book = new NewbookAlertconfig();
            configure.Bind("NewBookAlert", book);

            bool IsDisplay = book.DisplayNewBookAlert;

            return View();
        }


        //public ActionResult pdf()
        //{
        //    iTextSharp.text.pdf.PdfDocument pdfDocument = new iTextSharp.text.pdf.PdfDocument();
        //    pdfDocument.LoadFromFile(Path);
        //    string[] words, separators = { " " }, words1;
        //    var text = "";
        //    List<PdfContentData> lstPdfContentData = new List<PdfContentData>();
        //    lstPdfContentMasterData = new List<PdfContentMasterData>();
        //    PdfContentData pdfContentData;
        //    PdfContentMasterData pdfContentMasterData;
        //    string invoiceNo = "";
        //    int BillTotAmt = 0;
        //    bool isException = false;
        //    string line, deliveryFrom = "", deliverNo = "", deliveryDate = "", invoiceDate = "", totalAmount;
        //    int i = 0;
        //    try
        //    {
        //        foreach (PdfPageBase page in pdfDocument.Pages)
        //        {
        //            text = page.ExtractText();
        //            words = text.Split('\n');
        //            OCRItemEntity oCRItemEntity = new OCRItemEntity();

        //            for (int j = 1, len = words.Length; j < len; j++)
        //            {
        //                pdfContentData = new PdfContentData();
        //                line = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(words[j]));
        //                line = Regex.Replace(line, @"\s+", " ").Trim();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;

        //    }
        //}
        //    public string ReadFile(string pdfPath)
        //    {
        //        var pageText = new StringBuilder();
        //        using (iTextSharp.text.pdf.PdfDocument pdfDocument = new iTextSharp.text.pdf.PdfDocument(new PdfReader(pdfPath)))
        //        {
        //            var pageNumbers = pdfDocument.GetNumberOfPages();
        //            for (int i = 1; i <= pageNumbers; i++)
        //            {
        //                LocationTextExtractionStrategy strategy = new LocationTextExtractionStrategy();
        //                PdfCanvasProcessor parser = new PdfCanvasProcessor(strategy);
        //                parser.ProcessPageContent(pdfDocument.GetFirstPage());
        //                pageText.Append(strategy.GetResultantText());
        //            }
        //        }
        //        return pageText.ToString();
        //    }

        [HttpGet]
        public void cal()
        {

        }
     }
}
