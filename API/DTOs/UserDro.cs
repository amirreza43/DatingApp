
namespace API.DTOs
{
    public class UserDto
    {
        public string Username { get; set; }
        public string Token { get; set; } // This is the token that we will send back to the client
    }    
}