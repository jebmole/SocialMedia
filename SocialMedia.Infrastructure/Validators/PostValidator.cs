using FluentValidation;
using SocialMedia.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMedia.Infrastructure.Validators
{
    public class PostValidator : AbstractValidator<PostDto>
    {
        public PostValidator()
        {
            RuleFor(post => post.Description)
                .NotNull()
                .WithMessage("La descripcion no puede ser nula");

            RuleFor(post => post.Description)
                .Length(10, 500)
                .WithMessage("La longitud del la descripcion debe estar entre 10 y 500 caracteres");

            RuleFor(post => post.Date)
                .NotNull()
                .LessThan(DateTime.Now);

        }
    }
}
