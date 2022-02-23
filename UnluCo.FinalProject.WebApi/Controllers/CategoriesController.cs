﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.FinalProject.WebApi.Application.Abstract;
using UnluCo.FinalProject.WebApi.Application.ViewModels.CategoriesViewModel;
using UnluCo.FinalProject.WebApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UnluCo.FinalProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private ICategoryService _categoryService;
      
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
          
        }
        // GET: api/<CategoriesController>
        [HttpGet]
        public IActionResult Get()
        {
            var categories = _categoryService.GetAll().Result;
            return Ok(JsonConvert.SerializeObject(categories, Formatting.Indented, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            }));
        }

        // GET api/<CategoriesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
           var category= _categoryService.GetById(id).Result;

            return Ok(JsonConvert.SerializeObject(category, Formatting.Indented, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            }));
        }

        // POST api/<CategoriesController>
        [HttpPost]
        public IActionResult Post([FromBody] CreateCategoryViewModel createCategoryViewModel)
        {
            _categoryService.Add(createCategoryViewModel);
            return Ok();
        }

        // PUT api/<CategoriesController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] CreateCategoryViewModel updateCategoryViewModel)
        {
            _categoryService.Update(id,updateCategoryViewModel);
            return Ok();
        }

        // DELETE api/<CategoriesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            DeleteCategoryViewModel deleteCategory = new DeleteCategoryViewModel() { Id=id};  
            _categoryService.Delete(deleteCategory);
            return Ok();
        }
    }
}
