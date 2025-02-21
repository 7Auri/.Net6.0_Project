﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete.DTOs;
using Hangfire;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public ActionResult Login(UserForLoginDto userForLoginDto)
        {
            var userToLogin = _authService.Login(userForLoginDto);
            if (!userToLogin.Success)
            {

                return BadRequest(userToLogin.Message);
            }

            var result = _authService.CreateToken(userToLogin.Data);
            if (result.Success)
            {
               
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("register")]
        public ActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            var userExists = _authService.UserExists(userForRegisterDto.Email);
            if (!userExists.Success)
            {
                return BadRequest(userExists.Message);
            }

            var registerResult = _authService.Register(userForRegisterDto, userForRegisterDto.Password);
            var result = _authService.CreateToken(registerResult.Data);
            if (result.Success)
            {
                BackgroundJob.Schedule<IEmailService>(x => x.SendEmailAsync(userForRegisterDto.Email, userForRegisterDto.FirstName, "WELCOME TO MY BLAZOR PROJECT =)"), TimeSpan.FromSeconds(2));
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
