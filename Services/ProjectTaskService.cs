using Project.Ontario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Project.Ontario.Services
{
    public class ProjectTaskService
    {
        private readonly AppDBContext _appDBContext;

        public ProjectTaskService(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public async Task<List<ProjectTask>> GetAllTasksAsync()
        {
            return await _appDBContext.ProjectTasks.ToListAsync();
        }

        public async Task<ProjectTask> GetTaskByIdAsync(Guid id)
        {
            return await _appDBContext.ProjectTasks.FirstOrDefaultAsync(task => task.Id == id);
        }

        public async Task<bool> CreateTask(ProjectTask projectTask)
        {
            _appDBContext.ProjectTasks.Add(projectTask);
            await _appDBContext.SaveChangesAsync();
            return true;
        }

            public async Task EditTaskAsync(ProjectTask task)
        {
            _appDBContext.ProjectTasks.Update(task);
            await _appDBContext.SaveChangesAsync();
        }

        public async Task DeleteTaskAsync(Guid id)
        {
            var task = await _appDBContext.ProjectTasks.FirstOrDefaultAsync(task => task.Id == id);
            if (task != null)
            {
                _appDBContext.ProjectTasks.Remove(task);
                await _appDBContext.SaveChangesAsync();
            }
        }
    }
}
