using CoreDemo.Models;
using CoreDemo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Services
{
    public class HomeService : IHomeService
    {
        protected IHomeRepo homeobj;

        public HomeService(IHomeRepo homeobj)
        {
            this.homeobj = homeobj;
        }
        public async Task<bookschoolvm> AddorEdit(int? id)
        {
            return await homeobj.AddorEdit(id);
        }

        public void AddorEdit(Book book)
        {
           homeobj.AddorEdit(book);
        }

        public async Task<List<Book>> Allbooks()
        {
            return await homeobj.Allbooks();
        }

        public async Task<Book> Delete(int id)
        {
            return await homeobj.Delete(id);
        }

        public void DeleteConfirmed(int id)
        {
           homeobj.DeleteConfirmed(id);
        }

        public async Task<Book> Details(int id)
        {
            return await homeobj.Details(id);
        }

        public async Task<List<Book>> GetTopBook(int count)
        {
            return await homeobj.GetTopBook(count);
        }
    }
}
