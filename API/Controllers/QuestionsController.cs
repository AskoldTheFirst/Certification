using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{    
    public class QuestionsController : BaseApiController
    {
        
        private readonly CertificationContext _context;

        public QuestionsController(CertificationContext context)
        {
            _context = context;
            
        }

        [HttpGet]
        public async Task<ActionResult<List<Question>>> GetQuestions()
        {
            return await _context.Questions.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Question>> GetQuestion(int id)
        {
            var product = await _context.Questions.FindAsync(id);

            if (product == null) return NotFound();

            return product;
        }
    }
}