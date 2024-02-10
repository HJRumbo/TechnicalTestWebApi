using AutoMapper;
using Entity.Entities;
using TechnicalTestWebApi.Dtos.PatientDtos;

namespace TechnicalTestWebApi.Utils
{
    public class GeneralProfileMapping : Profile
    {
        public GeneralProfileMapping()
        {
            #region Entities to Dtos
            CreateMap<Patient, SavePatientDto>();
            CreateMap<Patient, PatientDto>();
            #endregion

            #region Dtos to Entities
            CreateMap<SavePatientDto, Patient>();
            CreateMap<PatientDto, Patient>();
            #endregion

            AllowNullCollections = true;
        }
    }
}
