using AutoMapper;
using HR.LeaveManagement.Application.DTOs;
using HR.LeaveManagement.Application.Features.LeaveType.Requests;
using HR.LeaveManagement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveType.Handlers.Queries
{
    //IRequestHandler<InputParamer Type(Where can we call from this class),Return Type(what type value we can expect back)>
    //This IRequestHandler is a interface from MediatR
    //Handle is auto implemented method from IRequestHandler
    public class GetLeaveTypeListRequestHandler : IRequestHandler<GetLeaveTypeListRequest,List<LeaveTypeDto>>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public GetLeaveTypeListRequestHandler(ILeaveTypeRepository leaveTypeRepository,IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypeListRequest request, CancellationToken cancellationToken)
        {
           var leaveTypes=await _leaveTypeRepository.GetAll();
           return _mapper.Map<List<LeaveTypeDto>>(leaveTypes);
        }
    }
}
