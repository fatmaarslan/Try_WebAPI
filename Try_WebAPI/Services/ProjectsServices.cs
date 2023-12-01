using Try_WebAPI.Models;


namespace Try_WebAPI.Services
{
    public class ProjectsServices
    {
        private readonly List<Project> _projects = new List<Project>();

        public void AddProject(Project project)
        {
            _projects.Add(project);
        }

        public Project GetProjectById(int projectId)
        {
            return _projects?.FirstOrDefault(p => p.Id == projectId);
        }

        public void DeleteProjectById(int projectId)
        {
            _projects.RemoveAll(p => p.Id == projectId);
        }
    }
}
