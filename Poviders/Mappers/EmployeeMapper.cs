using Clients.Dto;
using Poviders.Views;
using AutoMapper;

namespace Poviders.Mappers
{
    public class EmployeeMapper
    {
        private readonly MapperConfiguration _config;
        private readonly IMapper _mapper;

        public EmployeeMapper()
        {
            _config = new MapperConfiguration(cfg => cfg.CreateMap<Clients.Dto.Employee, EmployeeView>());
            _mapper = _config.CreateMapper();
        }

        public EmployeeView ToView(Clients.Dto.Employee dto, EmployeeView view)
        {
            return _mapper.Map<EmployeeView>(dto);
        }

        public Clients.Dto.Employee FromView(Clients.Dto.Employee dto, EmployeeView view)
        {
            return _mapper.Map<Clients.Dto.Employee>(view);
        }
    }
}
