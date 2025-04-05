using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using factopia_backend.DAL.Database;
using factopia_backend.DAL.Repositories.Interfaces;
using factopia_backend.Domain.CustomEnums;
using factopia_backend.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace factopia_backend.DAL.Repositories;

public class QuestionRepository : BaseRepository<Question>, IQuestionRepository
{

    public QuestionRepository(DataContext dataContext) : base(dataContext) { }


    public override async Task<IEnumerable<Question>> GetAllAsync()
    {
        return await _context.Questions
            .Include(q => q.Answers)
            .Include(q => q.Resources)
            .Include(q => q.GameType)
            .AsNoTracking()
            .ToListAsync();
    }






}
