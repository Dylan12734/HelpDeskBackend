using AutoMapper;
using HelpDeskBackend.Models;
using HelpDeskBackend.Models.DTO;
using HelpDeskBackend.Services;
using Microsoft.AspNetCore.Mvc;

namespace HelpDeskBackend.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TicketController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly TicketService _ticketService;
    public TicketController(IMapper mapper, TicketService ticketService)
    {
        _mapper = mapper;
        _ticketService = ticketService;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Ticket>> GetTickets()
    {
        var tickets = _ticketService.GetAllTickets();
        return Ok(tickets);
    }
    [HttpGet("{id}", Name ="GetTicket")]
    public ActionResult<Ticket> GetTicket(int id)
    {
        var ticket = _ticketService.GetTicketById(id);
        if (ticket == null)
        {
            return NotFound();
        }
        return Ok(ticket);
    }
    [HttpPost]
    public ActionResult<Ticket> PostTicket(TicketCreationDto ticketCreateDto)
    {
        var ticket= _mapper.Map<Ticket>(ticketCreateDto);
        _ticketService.AddTicket(ticket);

        return CreatedAtRoute(nameof(GetTicket), new { id = ticket.Id }, ticket);
    }
    [HttpPut("{id}")]
    public IActionResult UpdateTicket(int id, TicketUpdateDto ticketUpdateDto) 
    {
        var ticketFromRepo = _ticketService.GetTicketById(id);
        if (ticketFromRepo == null)
        {
            return NotFound();
        }
        _mapper.Map(ticketUpdateDto, ticketFromRepo);
        _ticketService.UpdateTicket(ticketFromRepo);
        return NoContent();
    }
    [HttpDelete("{id}")]
    public IActionResult DeleteTicket(int id)
    {
        var ticket = _ticketService.GetTicketById(id);
        if(ticket == null)
        {
            return NotFound();
        }
        _ticketService.DeleteTicket(id);
        return NoContent();
    }
}
