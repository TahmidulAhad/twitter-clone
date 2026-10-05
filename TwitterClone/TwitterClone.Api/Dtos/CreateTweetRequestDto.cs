namespace TwitterClone.Api.Dtos
{
    public class CreateTweetRequestDto
    {
        public required string Content { get; set; }
        public required Guid UserId { get; set; }
    }
}
