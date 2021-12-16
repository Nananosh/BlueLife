using AutoMapper;
using BlueLife.Models;
using BlueLife.ViewModels.Admin;

namespace BlueLife.ViewModels.Mappings
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<MedicineNameViewModel, MedicineName>()
                .ForMember(dest => dest.Id,
                    opt => opt.MapFrom
                        (src => src.Id))
                .ForMember(dest => dest.Name,
                    opt => opt.MapFrom
                        (src => src.Name))
                .ForMember(dest => dest.CatalogMedicinesId,
                    opt => opt.MapFrom
                        (src => src.CatalogMedicinesId))
                .ForMember(dest => dest.Medicines,
                    opt => opt.Ignore()).ReverseMap();
            
            CreateMap<MedicineManufacturerViewModel, MedicineManufacturer>()
                .ForMember(dest => dest.Id,
                    opt => opt.MapFrom
                        (src => src.Id))
                .ForMember(dest => dest.Manufacturer,
                    opt => opt.MapFrom
                        (src => src.Manufacturer))
                .ForMember(dest => dest.ReleaseMedicines,
                    opt => opt.Ignore()).ReverseMap();
            
            CreateMap<MedicineTypeViewModel, MedicineType>()
                .ForMember(dest => dest.Id,
                    opt => opt.MapFrom
                        (src => src.Id))
                .ForMember(dest => dest.Type,
                    opt => opt.MapFrom
                        (src => src.Type))
                .ForMember(dest => dest.Medicines,
                    opt => opt.Ignore()).ReverseMap();
            
            CreateMap<MedicineUnitViewModel, MedicineUnit>()
                .ForMember(dest => dest.Id,
                    opt => opt.MapFrom
                        (src => src.Id))
                .ForMember(dest => dest.Unit,
                    opt => opt.MapFrom
                        (src => src.Unit))
                .ForMember(dest => dest.Medicines,
                    opt => opt.Ignore()).ReverseMap();
            
            CreateMap<CatalogMedicineViewModel, CatalogMedicine>()
                .ForMember(dest => dest.Id,
                    opt => opt.MapFrom
                        (src => src.Id))
                .ForMember(dest => dest.NameCatalogMedicine,
                    opt => opt.MapFrom
                        (src => src.NameCatalogMedicine))
                .ForMember(dest => dest.MedicineNames,
                    opt => opt.Ignore()).ReverseMap();
            
            CreateMap<MedicineViewModel, Medicine>()
                .ForMember(dest => dest.Id,
                    opt => opt.MapFrom
                        (src => src.Id))
                .ForMember(dest => dest.MedicineNameId,
                    opt => opt.MapFrom
                        (src => src.MedicineNameId))
                .ForMember(dest => dest.MedicineTypeId,
                    opt => opt.MapFrom
                        (src => src.MedicineTypeId))
                .ForMember(dest => dest.MedicineUnitId,
                    opt => opt.MapFrom
                        (src => src.MedicineUnitId))
                .ForMember(dest => dest.Volume,
                    opt => opt.MapFrom
                        (src => src.Volume))
                .ForMember(dest => dest.Dosage,
                    opt => opt.MapFrom
                        (src => src.Dosage))
                .ForMember(dest => dest.ReleaseMedicines,
                    opt => opt.Ignore()).ReverseMap();
            
            CreateMap<ReleaseMedicineViewModel, ReleaseMedicine>()
                .ForMember(dest => dest.Id,
                    opt => opt.MapFrom
                        (src => src.Id))
                .ForMember(dest => dest.MedicineId,
                    opt => opt.MapFrom
                        (src => src.MedicineId))
                .ForMember(dest => dest.ManufacturerId,
                    opt => opt.MapFrom
                        (src => src.ManufacturerId))
                .ForMember(dest => dest.Image,
                    opt => opt.MapFrom
                        (src => src.Image))
                .ForMember(dest => dest.Description,
                    opt => opt.MapFrom
                        (src => src.Description))
                .ForMember(dest => dest.ReleaseDate,
                    opt => opt.MapFrom
                        (src => src.ReleaseDate))
                .ForMember(dest => dest.ExpirationDate,
                    opt => opt.MapFrom
                        (src => src.ExpirationDate))
                .ForMember(dest => dest.PharmacyWarehouses,
                    opt => opt.Ignore()).ReverseMap();
        }
    }
}