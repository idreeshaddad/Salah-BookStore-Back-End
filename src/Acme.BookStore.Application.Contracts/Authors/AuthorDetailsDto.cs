using Acme.BookStore.Books;
using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Authors
{
    public class AuthorDetailsDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string ShortBio { get; set; }

        public List<BookDto> Books { get; set; } = new List<BookDto>();
    }
}
