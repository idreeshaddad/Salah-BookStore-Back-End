using AutoMapper;

namespace Acme.BookStore.Authors
{
    public class AuthorAutoMapperProfile : Profile
    {
        public AuthorAutoMapperProfile()
        {
            CreateMap<Author, AuthorDto>();
            CreateMap<Author, AuthorDetailsDto>();
            CreateMap<CreateUpdateAuthorDto, Author>().ReverseMap();
        }
    }
}
