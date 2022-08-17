using FairyBread;
using FluentValidation;

namespace mutation_convention_fairybread_validation
{
    public class Mutation
    {
        [Error(typeof(ValidationException))]
        [UseMutationConvention()]
        public async Task<Author?> CreateAuthor([Validate(typeof(AuthorValidator))] Author author)
        {
            return new()
            {
                Name = author.Name
            };
        }

        [Error(typeof(ValidationException))]
        [UseMutationConvention()]
        public async Task<Author?> CreateAuthor2(Author author)
        {
            return new()
            {
                Name = author.Name
            };
        }

        public async Task<Author?> CreateAuthor3(Author author)
        {
            return new()
            {
                Name = author.Name
            };
        }
    }
}
