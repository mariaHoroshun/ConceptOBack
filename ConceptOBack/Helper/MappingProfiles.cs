using AutoMapper;
using ConceptOBack.Dto;
using ConceptOBack.Models;

namespace ConceptOBack.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Character, CharacterDto>();
        }
    }
}
