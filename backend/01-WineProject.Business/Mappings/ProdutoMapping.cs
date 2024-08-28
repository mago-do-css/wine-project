using _01_WineProject.Business.DTOs;
using _03_WineProject.Domain.Entities;
using AutoMapper;

namespace _01_WineProject.Business.Mappings
{
    public class ProdutoMapping : Profile
    {
        public void CreeateMappings(Profile configuration)
        {  
            configuration.CreateMap<Produto, ProdutoDTO>();
            configuration.CreateMap<ProdutoDTO, Produto>();
        }
    }
}