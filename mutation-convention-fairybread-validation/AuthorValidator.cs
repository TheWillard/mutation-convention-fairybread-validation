using FluentValidation;

namespace mutation_convention_fairybread_validation
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Author is empty");
        }
    }
}
