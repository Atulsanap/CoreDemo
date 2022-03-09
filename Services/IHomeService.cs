using CoreDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Services
{
    public interface IHomeService
    {
       Task<List<Book>> Allbooks();
        Task<Book> Details(int id);
       Task<bookschoolvm> AddorEdit(int? id);

        void AddorEdit(Book book);

       Task<Book> Delete(int id);

        void DeleteConfirmed(int id);

        Task<List<Book>> GetTopBook(int count);
    }
}
