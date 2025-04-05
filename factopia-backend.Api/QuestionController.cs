using factopia_backend.Api.DTOs;
using factopia_backend.Api.Mappers;
using factopia_backend.BLL.Services.Interfaces;
using factopia_backend.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace factopia_backend.Api;

[Route("api/[controller]")]
[ApiController]
public class QuestionController : ControllerBase
{
    private readonly IQuestionService _questionService;

    public QuestionController(IQuestionService questionService)
    {
        _questionService = questionService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<QuestionDTO>>> Get()
    {
        IEnumerable<Question> questions = await _questionService.GetAllAsync();
        return Ok(questions.Select(q => q.toDetailsDTO()));
    }

    [HttpGet("gametype/{gameType}")]
    public async Task<ActionResult<IEnumerable<QuestionDTO>>> GetByGameType([FromRoute] string gameType)
    {
        IEnumerable<Question> questions = await _questionService.GetAllAsync();
        IEnumerable<QuestionDTO> questionsDTO = questions.Where(q => q.GameType.Title.Equals(gameType)).Select(q => q.toDetailsDTO());
        
        return Ok(questionsDTO);
    }


}
