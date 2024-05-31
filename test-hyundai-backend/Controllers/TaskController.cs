using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using test_hyundai_backend.Data;
using test_hyundai_backend.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test_hyundai_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TasksController : ControllerBase
    {
        private readonly TaskContext _context;
        private readonly ILogger<TasksController> _logger;

        public TasksController(TaskContext context, ILogger<TasksController> logger)
        {
            _context = context;
            _logger = logger;
        }


        // GET: api/Tasks
        [HttpGet]
        public async Task<ActionResult<object>> GetTasks()
        {
            try
            {
                var tasks = await _context.TaskList.ToListAsync();
                if (tasks == null)
                {
                    return StatusCode(500, new { code = "error", message = "An error occurred while retrieving tasks." });
                }
                else if (tasks.Count == 0)
                {
                    return Ok(new { code = "success", message = "No Task Available" });
                }

                return Ok(new { code = "success", message = "Tasks retrieved", payload = tasks });
            }
            catch (Exception ex)
            {
                // Log the exception for debugging purposes
                _logger.LogError(ex, "An error occurred while retrieving tasks.");

                return StatusCode(500, new { code = "error", message = "An error occurred while retrieving tasks. Please try again later." });
            }
        }



        // GET: api/Tasks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TaskList>> GetTask(int id)
        {
            try
            {
                var task = await _context.TaskList.FindAsync(id);

                if (task == null)
                {
                    return NotFound(new { code = "error", message = "Task not found" });
                }

                return Ok(new { code = "success", message = "Task retrieved", payload = task });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while retrieving task with ID: {id}.");
                return StatusCode(500, new { code = "error", message = "Failed to retrieve the task. Please try again later." });
            }
        }

        // POST: api/Tasks
        [HttpPost]
        public async Task<ActionResult<TaskList>> PostTask(TaskList task)
        {
            try
            {
                _context.TaskList.Add(task);
                await _context.SaveChangesAsync();

                return Ok(new { code = "success", message = "Task created successfully" }); 
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while creating the task.");
                return StatusCode(500, new { code = "error", message = "Failed to create the task. Please try again later." });
            }
        }


        // PUT: api/Tasks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTask(int id, TaskList task)
        {
            if (id != task.Id)
            {
                return BadRequest(new { code = "error", message = "Invalid task ID" });
            }

            try
            {
                _context.Entry(task).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return Ok(new { code = "success", message = "Task updated successfully" });
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskExists(id))
                {
                    return NotFound(new { code = "error", message = "Task not found" });
                }
                else
                {
                    throw;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while updating task with ID: {id}.");
                return StatusCode(500, new { code = "error", message = "Failed to update the task. Please try again later." });
            }
        }

        // DELETE: api/Tasks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            try
            {
                var task = await _context.TaskList.FindAsync(id);
                if (task == null)
                {
                    return NotFound(new { code = "error", message = "Task not found" });
                }

                _context.TaskList.Remove(task);
                await _context.SaveChangesAsync();

                return Ok(new { code = "success", message = "Task deleted successfully" });
           
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while deleting task with ID: {id}.");
                return StatusCode(500, new { code = "error", message = "Failed to delete the task. Please try again later." });
            }
        }

        private bool TaskExists(int id)
        {
            return _context.TaskList.Any(e => e.Id == id);
        }


    }
}
