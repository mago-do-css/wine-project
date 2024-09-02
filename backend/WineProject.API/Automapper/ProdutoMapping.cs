using _01_WineProject.Business.DTOs;
using _03_WineProject.Domain.Entities;
using AutoMapper;

namespace WineProject.API.Automapper
{
    public class ProdutoMapping : Profile
    {
        public ProdutoMapping()
        {
            CreateMap<Produto, ProdutoDTO>();

            CreateMap<ProdutoDTO, Produto>();
        }
    }
}
