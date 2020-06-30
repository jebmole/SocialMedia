using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Api.Responses;
using SocialMedia.Core.DTOs;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Enumerations;
using SocialMedia.Core.Interfaces;

namespace SocialMedia.Api.Controllers
{
    [Authorize(Roles = nameof(RoleType.Administrator))]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityController : ControllerBase
    {
        private readonly ISecurityService _securityService;
        private readonly IMapper _mapper;

        public SecurityController(ISecurityService securityService, IMapper mapper)
        {
            _securityService = securityService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Post(SecurityDto securityDto)
        {
            var security = _mapper.Map<Security>(securityDto);

            await _securityService.RegisterUser(security);

            securityDto = _mapper.Map<SecurityDto>(security);
            var response = new ApiResponse<SecurityDto>(securityDto);
            return Ok(response);
        }

    }
}