namespace mutation_convention_fairybread_validation
{
    public class Query
    {
        public async Task<Author?> GetAuthor()
        {
            return new()
            {
                Name = "Test"
            };
        }
    }
}
