using CoreDemo.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents
{
    public class BookComponent:ViewComponent
    {
        protected IHomeService bookobj;
        public BookComponent(IHomeService bookobj)
        {
            this.bookobj = bookobj;
        }

        public async Task<IViewComponentResult> InvokeAsync(int count)
        {
            var book =await bookobj.GetTopBook(count);
            return View(book);
        }
    }
}
