﻿using BookWebApiRepo_MSSQL_EF.Data;
using BookWebApiRepo_MSSQL_EF.Models;
using BookWebApiRepo_MSSQL_EF.Models.Dto;
using BookWebApiRepo_MSSQL_EF.Repositories.IRepository;
using BookWebApiRepo_MSSQL_EF.Services.IServices;
using Microsoft.EntityFrameworkCore;
using System.Text;


namespace BookWebApiRepo_MSSQL_EF.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly BookContext _db;
        private readonly IPasswordService _passwordService;
        private readonly IJwtService _jwtService;

        public UserRepository(BookContext db, IPasswordService passwordService, IJwtService jwtService)
        {
            _db = db;
            _passwordService = passwordService;
            _jwtService = jwtService;
        }

        /// <summary>
        /// Should return a flag indicating if a user with a specified username already exists
        /// </summary>
        /// <param name="username">Registration username</param>
        /// <returns>A flag indicating if username already exists</returns>
        public async Task<bool> IsUniqueUserAsync(string username)
        {
            var user = await _db.LocalUsers.FirstOrDefaultAsync(x => x.Username == username);
            if (user == null)
            {
                return true;
            }
            return false;
        }

        public async Task<LoginResponse> LoginAsync(LoginRequest loginRequest)
        {
            var inputPasswordBytes = Encoding.UTF8.GetBytes(loginRequest.Password);
            var user = await _db.LocalUsers.FirstOrDefaultAsync(x => x.Username.ToLower() == loginRequest.Username.ToLower());


            if (user == null || !_passwordService.VerifyPasswordHash(loginRequest.Password, user.PasswordHash, user.PasswordSalt))
            {
                return new LoginResponse
                {
                    Token = "",
                    User = null
                };
            }

            var userRole = await _db.Roles.FirstOrDefaultAsync(x => x.Id == user.RoleId);
            var userRoleName = userRole.Name;

            //var token = _jwtService.GetJwtToken(user.Id, user.RoleName);
            var token = _jwtService.GetJwtToken(user.Id, userRoleName);

            user.Role = null;

            LoginResponse loginResponse = new()
            {
                Token = token,
                User = user
            };

            loginResponse.User.PasswordHash = null;
            loginResponse.User.PasswordSalt = null;

            return loginResponse;
        }

        // Add RegistrationResponse (Should not include password)
        // Add adapter classes to map to wanted classes
        public async Task<LocalUser> RegisterAsync(RegistrationRequest registrationRequest)
        {

            _passwordService.CreatePasswordHash(registrationRequest.Password, out byte[] passwordHash, out byte[] passwordSalt);

            var userRole = await _db.Roles.FirstOrDefaultAsync(x => x.Name == registrationRequest.Role);
            var userLevel = await _db.UserLevels.FirstOrDefaultAsync(x => x.Name == "Pradinukas");
            LocalUser user = new()
            {
                Username = registrationRequest.Username,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Name = registrationRequest.Name,
                Role = userRole,
                Active = true,
                Points = 0,
                UserLevel = userLevel
            };

            _db.LocalUsers.Add(user);
            await _db.SaveChangesAsync();
            user.PasswordHash = null;
            user.PasswordSalt = null;
            return user;
        }
    }
}
