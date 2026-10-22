using System;
using System.Collections.Generic;
using System.Text;

namespace Day18_AsyncAwait;

public class EmployeeDashboardService
{
    public async Task<List<Employee>> GetEmployeesAsync( CancellationToken cancellationToken)
    {

        await Task.Delay(2000, cancellationToken);

        return
           [
             new Employee
             {
                Id = 1,
                Name = "Pradip",
                Department = "IT"
             },
             new Employee
             {
                Id = 2,
                Name = "Rahul",
                Department = "IT"
             },
            ];
    }

    public async Task<List<Project>> GetProjectsAsync(CancellationToken cancellationToken)
    {

        await Task.Delay(3000, cancellationToken);
        return
           [
             new Project
             {
                Id = 1,
                Name = "WorkSphere"
             },
             new Project
             {
                Id = 2,
                Name = "TaskFlow"
             },
            ];
    }

    public async Task<List<TaskItem>> GetTasksAsync(CancellationToken cancellationToken)
    {
        await Task.Delay(1000, cancellationToken);
        return
           [
             new TaskItem
             {
                Id = 1,
                Title = "Implement Login",
                IsCompleted = true
             },
             new TaskItem
             {
                Id = 2,
                Title = "Implement Registration",
                IsCompleted = false
             },
            ];
    }

    public async Task<EmployeeDashboard> LoadDashboardAsync(CancellationToken cancellationToken)
    {
        var employeesTask = GetEmployeesAsync(cancellationToken);
        var projectsTask = GetProjectsAsync(cancellationToken);
        var tasksTask = GetTasksAsync(cancellationToken);
        await Task.WhenAll(employeesTask, projectsTask, tasksTask);
        return new EmployeeDashboard
        {
            Employees = await employeesTask,
            Projects = await projectsTask,
            Tasks = await tasksTask
        };
    }
}
