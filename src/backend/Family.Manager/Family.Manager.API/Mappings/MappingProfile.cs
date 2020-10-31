using AutoMapper;
using Family.Manager.API.Models;
using Family.Manager.Domain.Entities;

namespace Family.Manager.API.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Kid, GetKidResponseModel>()
                .ForMember(dest => dest.IsBaptized, opt => opt.MapFrom(src => src.KidReligionInformation.IsBaptized))
                .ForMember(dest => dest.DoingCatechesis, opt => opt.MapFrom(src => src.KidReligionInformation.DoingCatechesis))
                .ForMember(dest => dest.DoneCatechesis, opt => opt.MapFrom(src => src.KidReligionInformation.DoneCatechesis))
                .ForMember(dest => dest.DoingPerse, opt => opt.MapFrom(src => src.KidReligionInformation.DoingPerse))
                .ForMember(dest => dest.DonePerse, opt => opt.MapFrom(src => src.KidReligionInformation.DonePerse))
                .ForMember(dest => dest.DoingConfirmationSacrament, opt => opt.MapFrom(src => src.KidReligionInformation.DoingConfirmationSacrament))
                .ForMember(dest => dest.DoneConfirmationSacrament, opt => opt.MapFrom(src => src.KidReligionInformation.DoneConfirmationSacrament));

            CreateMap<Domain.Entities.Family, FamilyWithDescriptionResponse>();
            CreateMap<CreateFamily_Kinship_Request, Kinship>();
            CreateMap<EditKid_Request, Kid>();
            CreateMap<CreateFamilyRequest, Domain.Entities.Family>();
            CreateMap<UpdateFamilyRequest, Domain.Entities.Family>();
            CreateMap<EditKinship_Request, Kinship>();

            CreateMap<Kinship, FamilyWithKidsAndKinships_Kinships_Response>();
            CreateMap<Kid, FamilyWithKidsAndKinships_Kid_Response>()
                .ForMember(dest => dest.IsBaptized, opt => opt.MapFrom(src => src.KidReligionInformation.IsBaptized))
                .ForMember(dest => dest.DoingCatechesis, opt => opt.MapFrom(src => src.KidReligionInformation.DoingCatechesis))
                .ForMember(dest => dest.DoneCatechesis, opt => opt.MapFrom(src => src.KidReligionInformation.DoneCatechesis))
                .ForMember(dest => dest.DoingPerse, opt => opt.MapFrom(src => src.KidReligionInformation.DoingPerse))
                .ForMember(dest => dest.DonePerse, opt => opt.MapFrom(src => src.KidReligionInformation.DonePerse))
                .ForMember(dest => dest.DoingConfirmationSacrament, opt => opt.MapFrom(src => src.KidReligionInformation.DoingConfirmationSacrament))
                .ForMember(dest => dest.DoneConfirmationSacrament, opt => opt.MapFrom(src => src.KidReligionInformation.DoneConfirmationSacrament));
            CreateMap<Domain.Entities.Family, FamilyWithKidsAndKinshipsResponse>();
        }
    }
}
