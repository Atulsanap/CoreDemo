using CoreDemo.Helper;
using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class WebController : Controller
    {
       

        public IActionResult Index()
        {  
            HttpResponseMessage response = GlobalVariable.WebApiClient.GetAsync("Home").Result;
             var result = response.Content.ReadAsStringAsync().Result;
            List<Book> Booklist = JsonConvert.DeserializeObject<List<Book>>(result);
            return View(Booklist);
           
        }

        public IActionResult Details(int id)
        {
            var book = new Book();
            HttpResponseMessage response = GlobalVariable.WebApiClient.GetAsync("Home?id =" + id).Result;
            var displaybookresult = response.Content.ReadAsStringAsync().Result;
            book = JsonConvert.DeserializeObject<Book>(displaybookresult);
            return View(book);
        }


        public IActionResult Create()
        {
            return View(new Book());
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
            //this mycontent and data line are used to convert book model object into httpcontent object. 
            //otherwise it gives error that cannot convert book model to httpcontent. 
            var myContent = JsonConvert.SerializeObject(book);
            var data = new StringContent(myContent, Encoding.UTF8, "application/json");

            //
            HttpResponseMessage response = GlobalVariable.WebApiClient.PostAsync("Home"+book, data).Result;
            var displayempresult = response.Content.ReadAsStringAsync().Result;
            book = JsonConvert.DeserializeObject<Book>(displayempresult);
            return View(book);
        }

        public IActionResult Edit(int id)
        {
            HttpResponseMessage response = GlobalVariable.WebApiClient.GetAsync("Home?id=" + id).Result;
            var displaybookresult = response.Content.ReadAsStringAsync().Result;
            Book book = JsonConvert.DeserializeObject<Book>(displaybookresult);
            return View();
        }

        public IActionResult Edit(Book book)
        {
            var myContent = JsonConvert.SerializeObject(book);
            var data = new StringContent(myContent, Encoding.UTF8, "application/json");
            HttpResponseMessage response = GlobalVariable.WebApiClient.PutAsync("Home?id=" + book.Id, data).Result;

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariable.WebApiClient.DeleteAsync("Home?id=" + id).Result;
           return RedirectToAction("Index");
        }
    }
}
