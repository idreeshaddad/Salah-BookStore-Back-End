using System;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Authors
{
    public class CreateUpdateAuthorDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ShortBio { get; set; }
    }
}
