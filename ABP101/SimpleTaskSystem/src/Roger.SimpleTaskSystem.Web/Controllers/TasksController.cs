using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Roger.SimpleTaskSystem.Common;
using Roger.SimpleTaskSystem.Tasks;
using Roger.SimpleTaskSystem.Tasks.Dtos;
using Roger.SimpleTaskSystem.Web.Models.Tasks;

namespace Roger.SimpleTaskSystem.Web.Controllers
{
    public class TasksController : SimpleTaskSystemControllerBase
    {
        private readonly ITaskAppService _taskAppService;
        private readonly ILookupAppService _lookupAppService;

        public TasksController(ITaskAppService taskAppService)
        {
            _taskAppService = taskAppService;
        }

        public async Task<ActionResult> Index(GetAllTasksInput input)
        {
            var output = await _taskAppService.GetAll(input);
            var model = new IndexViewModel(output.Items) {
                SelectedTaskState = input.State
            };

            return View(model);
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}