using Core.Entities;
using Core.Interfaces;

namespace Core.UseCases;

public class AddExamResultUseCase
{
    private readonly IExamResultService _examResultService;

    public AddExamResultUseCase(IExamResultService examResultService)
    {
        _examResultService = examResultService;
    }

    public async Task ExecuteAsync(ExamResult examResult)
    {
        await _examResultService.AddExamResultAsync(examResult);
    }
}