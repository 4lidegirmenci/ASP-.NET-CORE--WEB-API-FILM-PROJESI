namespace Entities.DataTransferObject
{

    public record UserDto
    {
        public int UserId { get; init; }

        public string UserName { get; init; }

        public string Password { get; init; }

        public string Email { get; init; }

        public string Phone { get; init; }
    }

}
