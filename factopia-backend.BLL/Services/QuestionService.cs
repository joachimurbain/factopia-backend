using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using factopia_backend.BLL.Services.Interfaces;
using factopia_backend.DAL.Database;
using factopia_backend.DAL.Repositories.Interfaces;
using factopia_backend.Domain.Models;

namespace factopia_backend.BLL.Services
{
    public class QuestionService:BaseService<Question>, IQuestionService
    {
        public QuestionService(IQuestionRepository questionRepository) : base(questionRepository) { }
    }
}
