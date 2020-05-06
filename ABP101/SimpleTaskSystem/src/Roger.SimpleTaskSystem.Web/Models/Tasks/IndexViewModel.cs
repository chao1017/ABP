using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Roger.SimpleTaskSystem.Tasks;
using Roger.SimpleTaskSystem.Tasks.Dtos;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Roger.SimpleTaskSystem.Web.Models.Tasks
{
    public class IndexViewModel
    {
        public IReadOnlyList<TaskListDto> Tasks { get; }

        public IndexViewModel(IReadOnlyList<TaskListDto> tasks)
        {
            Tasks = tasks;
        }

        public string GetTaskLabel(TaskListDto task)
        {
            switch (task.State)
            {
                case TaskState.Open:
                    return "label-success";
                //case TaskState.Completed:
                //    break;
                default:
                    return "label-default";
            }
        }
    }
}
