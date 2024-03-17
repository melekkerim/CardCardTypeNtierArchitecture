using AutoMapper;
using CardCardTypeNtierArchitecture.DTOs.CardDtos;
using CardCardTypeNtierArchitecture.DTOs.CardTypeDtos;
using CardCardTypeNtierArchitecture.Entities;

namespace CardCardTypeNtierArchitecture.Mappers
{
    public class AutomapperProfiles : Profile
    {
        
        public AutomapperProfiles()
        {
            CreateMap<CardTypeToAddDto, CardType>();
            CreateMap<CardType, CardTypeToListDto>();
            CreateMap<CardTypeToUpdateDto, CardType>();

            CreateMap<CardToAddDto, Card>();
            CreateMap<Card, CardToListDto>();
            CreateMap<CardToUpdateDto, Card>();

           

        }
    }
}
