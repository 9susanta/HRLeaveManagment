using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.DTOs.LeaveType.Validators
{
    public class CreateLeaveTypeDtoValidator:AbstractValidator<CreateLeaveTypeDto>
    {
        public CreateLeaveTypeDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("{PropertyName} is Required")
                .NotNull().MaximumLength(50).
                WithMessage("{PropertyName} must not be exceed 50 charecter");

            RuleFor(x => x.DefaultDays).NotEmpty().WithMessage("{PropertyName} is Required")
                .GreaterThan(0).WithMessage("{PropertyName} must be at least 1")
                .LessThan(100).WithMessage("{PropertyName} must be less 100");
        }
    }
}
