using Api.Models;
using Api.Services;
using Api.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Api.controllers;

[ApiController]
[Route("[controller]")]
public class GlicemiaController : ControllerBase 
{
  private readonly IGlicemiaService _GlicemiaService;

  public GlicemiaController(IGlicemiaService GlicemiaService) {
    _GlicemiaService = GlicemiaService ?? throw new ArgumentNullException(nameof(GlicemiaService));
  }

  [HttpPost("{id}")]
  public ActionResult<IEnumerable<Glicemia>> GetAll(int id) {
    var glicemias = _GlicemiaService.GetAll(id);
    return(glicemias);
  }

  [HttpGet("{id}")]
  public ActionResult<Glicemia> GetById(int id) {
    var glicemia = _GlicemiaService.GetById(id);
    if (glicemia == null) {
      return NotFound();
    }
    return glicemia;
  }

  [HttpPost]
  public ActionResult<Glicemia> Add(Glicemia glicemia) {
    _GlicemiaService.Add(glicemia);
    return CreatedAtAction(nameof(GetById), new { id = glicemia.id }, glicemia);
  }

  [HttpPut("{id}")]
  public IActionResult Update(int id, Glicemia glicemia) {
    if (id != glicemia.id) {
      return BadRequest();
    }
    _GlicemiaService.Update(glicemia);
    return NoContent();
  }

  [HttpDelete("{id}")]
  public IActionResult Delete(int id) {
    var glicemia = _GlicemiaService.GetById(id);
    if (glicemia == null) {
      return NotFound();
    }
    _GlicemiaService.Delete(id);
    return NoContent();
  }

}