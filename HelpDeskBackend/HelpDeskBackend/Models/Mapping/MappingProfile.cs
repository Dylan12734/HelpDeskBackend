using AutoMapper;
using HelpDeskBackend.Models;
using HelpDeskBackend.Models.DTO;

internal class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<FavoritesCreationDto, Favorites>();
        CreateMap<TicketCreationDto, Ticket>();
        CreateMap<TicketUpdateDto, Ticket>();
    }
}