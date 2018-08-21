using BookLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksQueryDriver
{
    class BookController
    {
        BooksEntities dbContext = new BooksEntities();

        public BookController()
        {
            /*
            dbContext.Authors.OrderBy(author => author.LastName).Load();
            dbContext.Authors.Join(dbContext.Titles, author => author.LastName, title => title.Title1,
                (author, title) => new { title.Title1, author.FirstName, author.LastName }).
                OrderBy(title => title.LastName).Load();
            */
            //dbContext.Entry(author).Reference(author => author.).Load;
            //authorBindingSource.DataSource = dbContext.Authors.Local;
        }

        /*1.	 Get a list of all the titles and the authors who wrote them. Sort the results by title. */
        public IEnumerable QueryFirstQuestion()
        {
            var titlesAuthors = from author in dbContext.Authors
                                from book in dbContext.Titles
                                orderby book.Title1
                                select new { Title = book.Title1, author.LastName, author.FirstName };

            return titlesAuthors.ToList();
        }

        /*2.	 Get a list of all the titles and the authors who wrote them. Sort the results by title.
            Each title sort the authors alphabetically by last name, then first name. */

        public IEnumerable QuerySecondQuestion()
        {
            var titlesAuthors = from author in dbContext.Authors
                                from book in dbContext.Titles
                                orderby book.Title1, author.LastName, author.FirstName
                                select new { Title = book.Title1, author.LastName, author.FirstName };
            return titlesAuthors.ToList();
        }

        /*3.	 Get a list of all the authors grouped by title, sorted by title; 
                for a given title sort the author names alphabetically by last name then first name.*/
        public IEnumerable QueryThirdQuestion()
        {
            var titlesAuthors = from book in dbContext.Titles
                                group book by book.Title1 into ab
                                from author in dbContext.Authors
                                let Title = ab.Max(t=> t.Title1)
                                orderby Title, author.LastName, author.FirstName
                                select new { author.LastName, author.FirstName, Title };
            return titlesAuthors.ToList();
        }
    }
}
