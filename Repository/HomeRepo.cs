using CoreDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Repository
{
    public class HomeRepo : IHomeRepo
    {
       public BookContext db;
        public DbSet<Book> DbEntity;

        public HomeRepo()
        {
        }

        public HomeRepo (BookContext db)
        {
            this.db = db;
            DbEntity = db.Set<Book>();
        }


        

        public async Task<bookschoolvm> AddorEdit(int? id/*, out List<School> school*/)
        {
            //school = db.Schools.ToList();
            var watch = new System.Diagnostics.Stopwatch();
           
            if (id != null)
            {
                bookschoolvm  vm = new bookschoolvm();
                {
                    watch.Start();
                    vm.book = await db.Books.FindAsync(id);   
                    vm.school =await db.Schools.ToListAsync();
                    watch.Stop();
                }

                //Console.WriteLine($"Execution time={ watch.ElapsedMilliseconds}");
                return  vm;
            }
            bookschoolvm vmm = new bookschoolvm();
            {
                vmm.school =await db.Schools.ToListAsync();
            }
            
            return vmm;
           
        }
        
             
            public async void AddorEdit(Book book)
            {
            if (book.Id != 0)
            {
                db.Entry(book).State = EntityState.Modified;

            }
            else
            {
              await db.Books.AddAsync(book);

            }
            await db.SaveChangesAsync();
     
        }

        public async Task<List<Book>> Allbooks()
        {
            return await db.Books.ToListAsync();
        }

       

        public async Task<Book> Delete(int id)
        {
            Book book =await db.Books.FindAsync(id);
            return book;
        }

        public async void DeleteConfirmed(int id)
        {
            Book book =await db.Books.FindAsync(id);
            db.Books.Remove(book);
           await db.SaveChangesAsync();
        }

        public async Task<Book> Details(int id)
        {
            Book book =await db.Books.FindAsync(id);
            return book;
        }

        public async Task<List<Book>> GetTopBook(int count)
        {
           List<Book> book = await db.Books.Take(count).ToListAsync();
           return book;
        }
    }
}
