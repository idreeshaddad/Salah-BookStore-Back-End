using Acme.BookStore.Permissions;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Authors
{
    public class AuthorAppService : 
        CrudAppService<
            Author,
            AuthorDetailsDto,
            AuthorDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateAuthorDto, 
            CreateUpdateAuthorDto
            >, IAuthorAppService
    {
        public AuthorAppService(IRepository<Author, Guid> repository) 
            : base(repository)
        {
            GetPolicyName = BookStorePermissions.Books.Default;
            GetListPolicyName = BookStorePermissions.Books.Default;
            CreatePolicyName = BookStorePermissions.Books.Create;
            UpdatePolicyName = BookStorePermissions.Books.Edit;
            DeletePolicyName = BookStorePermissions.Books.Delete;
        }
    }
}
