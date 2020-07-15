using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Roger.SimpleTaskSystem.Common;
using Roger.SimpleTaskSystem.Tasks;
using Roger.SimpleTaskSystem.Tasks.Dtos;
using Roger.SimpleTaskSystem.Web.Models.People;
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

        public async Task<ActionResult> Create()
        {
            var peopleSelectListItems = (await _lookupAppService.GetPeopleComboboxItems()).Items
                .Select(p => p.ToSelectListItem())
                .ToList();

            peopleSelectListItems.Insert(0, new SelectListItem { Value = string.Empty, Text = L("Unassigned"), Selected = true });

            return View(new CreateTaskViewModel(peopleSelectListItems));
        }
    }
}