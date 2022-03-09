using CoreDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Repository
{
   public interface IHomeRepo
    {
       Task<List<Book>> Allbooks();
        Task<Book> Details(int id);
        Task<bookschoolvm> AddorEdit(int? id/*, out List<School> school*/);

       void AddorEdit(Book book);

         Task<Book> Delete(int id);

        void DeleteConfirmed(int id);

        Task<List<Book>> GetTopBook(int count);

    }
}
