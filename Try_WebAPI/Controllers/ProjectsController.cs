using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Try_WebAPI.Models;
using Try_WebAPI.Services;
using System.Security.Principal;
using System.Xml.Linq;

namespace Try_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly ProjectsServices _projectsService;
        private readonly UsersServices _usersService;

        public ProjectsController(ProjectsServices projectsService, UsersServices usersService)
        {
            _projectsService = projectsService;
            _usersService = usersService;
        }

    
        [HttpPost("{projectId}/users")]
        public IActionResult AddUserToProject(int projectId, [FromBody] User user)
        {
            try
            {
                var project = _projectsService.GetProjectById(projectId);

                if (project == null)
                {
                    return NotFound();
                }

                _usersService.AddUser(user);

                return StatusCode(201);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return StatusCode(500, "Internal Server Error");
            }
        }


        [HttpGet("{projectId}/users")]
        public IActionResult GetUsersByProjectId(int projectId)
        {
            var project = _projectsService.GetProjectById(projectId);

            if (project == null)
            {
                return NotFound();
            }

            var users = _usersService.GetUsersByProjectId(projectId);
            return Ok(users);
        }

        [HttpDelete("{projectId}")]
        public IActionResult DeleteProject(int projectId)
        {
            var project = _projectsService.GetProjectById(projectId);

            if (project == null)
            {
                return NotFound();
            }

            _usersService.DeleteUsersByProjectId(projectId);
            _projectsService.DeleteProjectById(projectId);

            return NoContent();
        }



        private  List<Project> projects = new List<Project>()
        {

            new Project
            {
              Id= 5,
              Name="test name",
              IsAvailable=true,
              AddedDate=1573843210


            },
        };


        private  List<User> users = new List<User>()
        {
            new User
            {

                Id=5,
                Name="test user name",
                ProjectId=5,
                AddedDate=1573843210

            }
         };
    }
}
