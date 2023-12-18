using System;
using System.Threading.Tasks;
using Acme.BookStore.Authors;
using Acme.BookStore.Books;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore
{
    public class BookStoreDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Book, Guid> _bookRepository;
        private readonly IRepository<Author, Guid> _authorRepository;

        public BookStoreDataSeederContributor(
            IRepository<Book, Guid> bookRepository,
            IRepository<Author, Guid> authorRepository)
        {
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            await SeedBooksAndAuthors();
        }

        #region Private Methods

        private async Task SeedBooksAndAuthors()
        {
            if (await _bookRepository.GetCountAsync() <= 0)
            {
                var georgeOrwell = await _authorRepository.InsertAsync(
                   new Author
                   {
                       Name = "George Orwell",
                       BirthDate = new DateTime(1903, 06, 25),
                       ShortBio = "Orwell produced literary criticism and poetry, fiction and polemical journalism; and is best known for the allegorical novella Animal Farm (1945) and the dystopian novel Nineteen Eighty-Four (1949)."
                   }
               );

                var douglasAdams = await _authorRepository.InsertAsync(
                    new Author
                    {
                        Name = "Douglas Adams",
                        BirthDate = new DateTime(1952, 03, 11),
                        ShortBio = "Douglas Adams was an English author, screenwriter, essayist, humorist, satirist and dramatist. Adams was an advocate for environmentalism and conservation, a lover of fast cars, technological innovation and the Apple Macintosh, and a self-proclaimed 'radical atheist'."
                    }
                );

                await _bookRepository.InsertAsync(
                    new Book
                    {
                        AuthorId = georgeOrwell.Id,
                        Name = "1984",
                        Type = BookType.Dystopia,
                        PublishDate = new DateTime(1949, 6, 8),
                        Price = 19.84f
                    },
                    autoSave: true
                );

                await _bookRepository.InsertAsync(
                    new Book
                    {
                        AuthorId = douglasAdams.Id,
                        Name = "The Hitchhiker's Guide to the Galaxy",
                        Type = BookType.ScienceFiction,
                        PublishDate = new DateTime(1995, 9, 27),
                        Price = 42.0f
                    },
                    autoSave: true
                );
            }
        }

        private async Task SeedAuthors()
        {
            if (await _authorRepository.GetCountAsync() <= 0)
            {
               
            }
        }

        #endregion
    }
}
