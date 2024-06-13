using AutoMapper;
using TFG.HomeWorks.Application.Exceptions;
using TFG.HomeWorks.Application.ExternalServices;
using TFG.HomeWorks.Application.Repositories;
using TFG.HomeWorks.Application.Services.Authentication.DTOs.Register;
using TFG.HomeWorks.Application.Validations;

namespace TFG.HomeWorks.Application.Services.Authentication
{
    internal class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly IObjectValidator _validator;
        private readonly IMapper _mapper;
        private readonly IPasswordHasher _passwordHasher;
        private readonly ISaltGenerator _saltGenerator;

        public AuthService(IUserRepository userRepository,
                           IObjectValidator validator,
                           IMapper mapper,
                           IPasswordHasher passwordHasher,
                           ISaltGenerator saltGenerator)
        {
            _userRepository = userRepository;
            _validator = validator;
            _mapper = mapper;
            _passwordHasher = passwordHasher;
            _saltGenerator = saltGenerator;
        }

        public async Task<RegisterResponse> RegisterAsync(RegisterRequest request)
        {
            _validator.EnsureIsValid(request);

            if (await _userRepository.UserExist(request.Email, request.Username))
                throw CustomApplicationException.Create(CustomApplicationExceptionCode.Auth_UserExist);

            string salt = _saltGenerator.Generate();
            string hashedPassword = _passwordHasher.Generate(request.Password, salt);

            var entity = Domain.Entities.UserAggregate.User.Create(
                request.Email,
                request.Username,
                request.FirstName,
                request.LastName1,
                request.LastName2,
                request.BirthDate ?? DateTime.Now,
                request.PhoneNumber,
                hashedPassword,
                salt,
                request.Gender,
                request.ProfileImage ?? string.Empty,
                request.Role);

            await _userRepository.Add(entity);
            await _userRepository.SaveChanges();

            return new RegisterResponse(
                entity.Email,
                entity.Username,
                entity.FirstName,
                entity.LastName1 ?? string.Empty,
                entity.LastName2 ?? string.Empty,
                entity.BirthDate,
                entity.PhoneNumber,
                Domain.Entities.UserAggregate.Gender.Unknown,
                string.Empty);
        }
    }
}
