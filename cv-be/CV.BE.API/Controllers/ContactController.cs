using CV.BE.API.Models.Requests.Contacts;
using CV.BE.API.Models.Responses;
using CV.BE.API.Models.Responses.Contacts;
using CV.BE.API.Services;
using CV.BE.API.Controllers;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace CV.BE.API.Controllers
{
    [ApiController]
    [APIRoute("[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly ILogger<ContactController> _logger;
        private readonly IContactService _contactService;

        public ContactController(ILogger<ContactController> logger, IContactService contactService)
        {
            _logger = logger;
            _contactService = contactService;
        }

        [HttpGet]
        public async Task<IActionResult> GetContactAsync()
        {
            var result = await _contactService.GetContactAsync();
            if (!result.IsSuccess)
            {
                return ResponseFactory.Fail(result.Error);
            }

            return ResponseFactory.Success(result.Data.Adapt<ContactResponse>());
        }

        [HttpPost]
        public async Task<IActionResult> CreateContactAsync(CreateContactRequest request)
        {
            var result = await _contactService.CreateContactAsync(request.ToDto());
            if (!result.IsSuccess)
            {
                return ResponseFactory.Fail(result.Error);
            }

            return ResponseFactory.Success(result.Data);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateContactAsync(Guid id, UpdateContactRequest request)
        {
            var result = await _contactService.UpdateContactAsync(id, request.ToDto());
            if (!result.IsSuccess)
            {
                return ResponseFactory.Fail(result.Error);
            }

            return ResponseFactory.Success();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteContactAsync(Guid id)
        {
            var result = await _contactService.DeleteContactAsync(id);
            if (!result.IsSuccess)
            {
                return ResponseFactory.Fail(result.Error);
            }

            return ResponseFactory.Success();
        }
    }
}
