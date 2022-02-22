﻿using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using UnluCo.FinalProject.WebApi.Application.Abstract;
using UnluCo.FinalProject.WebApi.Application.Validators.Brands;
using UnluCo.FinalProject.WebApi.Application.ViewModels.BrandsViewModel;
using UnluCo.FinalProject.WebApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UnluCo.FinalProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private IBrandService _brandService;
      
        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
          
        }
        // GET: api/<BrandsController>
        [HttpGet]
        public IActionResult Get()
        {
            var brands = _brandService.GetAll();
            
            return brands == null? StatusCode((int)HttpStatusCode.InternalServerError):Ok(brands);
        }

        // GET api/<BrandsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
           var brand= _brandService.GetById(id);
            return brand == null ? NoContent() : Ok(brand);
        }

        // POST api/<BrandsController>
        [HttpPost]
        public IActionResult Post([FromBody] CreateBrandViewModel createBrandViewModel)
        {
            CreateBrandViewValidator validator = new CreateBrandViewValidator();
            validator.ValidateAndThrow(createBrandViewModel);
            _brandService.Add(createBrandViewModel);
            return Ok();
        }

        // PUT api/<BrandsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateBrandViewModel updateBrandViewModel)
        {
            UpdateBrandViewValidator validator = new UpdateBrandViewValidator();
            validator.ValidateAndThrow(updateBrandViewModel);
            _brandService.Update(id,updateBrandViewModel);
            return Ok();
        }

        // DELETE api/<BrandsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            DeleteBrandViewModel deleteBrand = new DeleteBrandViewModel() { Id = id };
            DeleteBrandViewValidator validator = new DeleteBrandViewValidator();
            validator.ValidateAndThrow(deleteBrand);
            _brandService.Delete(deleteBrand);
            return Ok();
        }
    }
}
