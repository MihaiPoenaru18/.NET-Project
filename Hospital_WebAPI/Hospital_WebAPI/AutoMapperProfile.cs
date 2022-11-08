using AutoMapper;
using Hospital_WebAPI.Models;

public class AutoMapperProfile : Profile
{
	public AutoMapperProfile()
	{
		CreateMap<Patients, PatientsDto>();
	}
}
