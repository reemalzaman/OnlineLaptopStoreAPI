using AutoMapper;
using OnlineStore.Model;

namespace OnlineStore.Profile
{
    internal class ApplicationProfile : AutoMapper.Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Product, Product>()
                    .ReverseMap();

        }
    }
}