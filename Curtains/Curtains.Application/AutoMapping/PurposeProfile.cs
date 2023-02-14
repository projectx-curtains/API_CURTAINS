using AutoMapper;
using Curtains.Application.DTO;
using Curtains.Domain.Models;

namespace Curtains.Application.AutoMapping
{
	/// <summary>
	/// This class describes the behavior of automapping when working with purpose
	/// </summary>
	public class PurposeProfile : Profile
	{
		public PurposeProfile()
		{
			CreateMap<PurposeModel, PurposeDTO>().ReverseMap();
		}
	}
}
