using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using SpicyWebApi.Data;
using SpicyWebApi.Dtos;
using SpicyWebApi.Models;

namespace SpicyWebApi.Controllers
{
    [ApiController]
    [Route("api/sqlcommands")]
    public class SqlController : ControllerBase
    {
        private readonly ICommandRepo _repository;
        private readonly IMapper _mapper;

        public SqlController(ICommandRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<SqlCommands>> GetAllSqlCommand()
        {
            var sqlCommandItems = _repository.GetAllSqlCommands();

            return Ok(_mapper.Map<IEnumerable<SqlReadDto>>(sqlCommandItems));
            // return Ok(sqlCommandItems);
        }

        [HttpGet("{id}", Name = "GetOneSqlCommand")]
        public ActionResult<SqlCommands> GetOneSqlCommand(int id)
        {
            var sqlSingleItem = _repository.GetCommandById(id);
            return Ok(sqlSingleItem);
        }

        [HttpPost]
        public ActionResult<SqlReadDto> CreateCommand(SqlCreateDto sqlCreatedDto)
        {
            var sqlModel = _mapper.Map<SqlCommands>(sqlCreatedDto);
            _repository.CreateCommand(sqlModel);
            _repository.SaveChanges();

            var sqlReadDto = _mapper.Map<SqlReadDto>(sqlModel);

            return CreatedAtRoute(nameof(GetOneSqlCommand), new { Id = sqlReadDto.SqlCmdId }, sqlReadDto);
        }

        [HttpPatch("{id}")]
        public ActionResult PartialUpdate(int id, JsonPatchDocument<SqlUpdateDto> patchDoc)
        {
            var existingCmd = _repository.GetCommandById(id);

            if (existingCmd == null)
            {
                return NotFound();
            }

            var SqlToPatch = _mapper.Map<SqlUpdateDto>(existingCmd);
            patchDoc.ApplyTo(SqlToPatch, ModelState);

            if (!TryValidateModel(SqlToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(SqlToPatch, existingCmd);

            _repository.UpdateCommand(existingCmd);
            _repository.SaveChanges();

            return NoContent();
        }


        [HttpDelete("{id}")]
        public ActionResult DeleteSql(int id)
        {
            var existingCmd = _repository.GetCommandById(id);

            if (existingCmd == null)
            {
                return NotFound();
            }

            _repository.DeleteCommand(existingCmd);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}