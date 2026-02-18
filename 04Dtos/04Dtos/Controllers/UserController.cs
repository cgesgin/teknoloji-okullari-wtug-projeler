using _04Dtos.Dtos;
using _04Dtos.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace _04Dtos.Controllers
{
    public class UserController : Controller
    {
        private readonly IMapper _mapper;

        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var userDtos = _mapper.Map<List<UserDto>>(_users);
            return View(userDtos);
        }

        private List<User> _users = new()
        {
            new User{ Id = 1, Username = "Alice", Password = "123", Email = "alice@mail.com"},
            new User{ Id = 2, Username = "Bob", Password = "456", Email = "bob@mail.com"},
            new User{ Id = 3, Username = "Charlie", Password = "789", Email = "charlie@mail.com"}
        };
    }
}
