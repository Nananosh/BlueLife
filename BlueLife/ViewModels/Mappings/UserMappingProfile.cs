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
                .ForMember(dest => dest.CatalogMedicines,
                    opt => opt.MapFrom
                        (src => src.CatalogMedicine))
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
                .ForMember(dest => dest.Manufacturer,
                    opt => opt.MapFrom
                        (src => src.Manufacturer))
                .ForMember(dest => dest.Medicine,
                    opt => opt.MapFrom
                        (src => src.Medicine))
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
            
            CreateMap<PharmacyWarehouseViewModel, PharmacyWarehouse>()
                .ForMember(dest => dest.Id,
                    opt => opt.MapFrom
                        (src => src.Id))
                .ForMember(dest => dest.ReleaseMedicine,
                    opt => opt.MapFrom
                        (src => src.ReleaseMedicine))
                .ForMember(dest => dest.ReleaseMedicineId,
                    opt => opt.MapFrom
                        (src => src.ReleaseMedicineId))
                .ForMember(dest => dest.Price,
                    opt => opt.MapFrom
                        (src => src.Price))
                .ForMember(dest => dest.Quantity,
                    opt => opt.MapFrom
                        (src => src.Quantity))
                .ForMember(dest => dest.Orders,
                    opt => opt.Ignore())
                .ForMember(dest => dest.Baskets,
                    opt => opt.Ignore()).ReverseMap();
        }
    }
}