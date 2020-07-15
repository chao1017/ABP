﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Roger.SimpleTaskSystem.Web.Models.People
{
    public class CreateTaskViewModel
    {
        public List<SelectListItem> People { get; set; }

        public CreateTaskViewModel(List<SelectListItem> people)
        {
            People = people;
        }
    }
}
