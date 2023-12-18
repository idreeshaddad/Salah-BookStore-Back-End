using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Authors
{
    public interface IAuthorAppService :
        ICrudAppService< 
            AuthorDetailsDto,
            AuthorDto,
            Guid, 
            PagedAndSortedResultRequestDto, 
            CreateUpdateAuthorDto,
            CreateUpdateAuthorDto> 
    {
    }
}
