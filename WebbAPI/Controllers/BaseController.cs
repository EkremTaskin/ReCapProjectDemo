using Business.Abstract;
using Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbAPI.Concrete
{
	[Route("api/[controller]")]
	[ApiController]
	public abstract class BaseController<TService , TEntity> : ControllerBase
		where TService: class , IBaseService<TEntity>
		where TEntity: class , IEntity
	{
		TService _service;

		public BaseController(TService service)
		{
			_service = service;
		}

		[HttpPost("add")]
		public IActionResult Add(TEntity entity)
		{
			var result = _service.Add(entity);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpPost("update")]
		public IActionResult Update(TEntity entity)
		{
			var result = _service.Update(entity);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpPost("delete")]
		public IActionResult Delete(TEntity entity)
		{
			var result = _service.Delete(entity);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpGet("getbyid")]
		public IActionResult GetById(int id)
		{
			var result = _service.GetById(id);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var result = _service.GetAll();
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
	}
}
