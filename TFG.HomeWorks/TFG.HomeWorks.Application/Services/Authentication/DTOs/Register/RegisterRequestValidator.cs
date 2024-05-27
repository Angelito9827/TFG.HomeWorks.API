using FluentValidation;

namespace TFG.HomeWorks.Application.Services.Authentication.DTOs.Register
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress();

            RuleFor(x => x.BirthDate)
                .NotEmpty()
                .Must(BeAValidDate)
                .WithMessage("Birth date must be a valid date");

            RuleFor(x => x.Password)
              .NotEmpty()
              .MinimumLength(6)
              .Must(BeStrongPassword)
              .WithMessage("Password must be strong (at least 6 characters including lowercase, uppercase, numeric, and special characters).");

        }
        private bool BeAValidDate(DateTime date)
        {
            return !date.Equals(default(DateTime));
        }
        private bool BeStrongPassword(string password)
        {
            // Check if the password contains at least one lowercase letter, one uppercase letter, one numeric digit, and one special character
            return !string.IsNullOrWhiteSpace(password) &&
                   password.Length >= 6 &&
                   ContainsCharacterFromSet(password, "abcdefghijklmnopqrstuvwxyz") &&
                   ContainsCharacterFromSet(password, "ABCDEFGHIJKLMNOPQRSTUVWXYZ") &&
                   ContainsCharacterFromSet(password, "0123456789") &&
                   ContainsCharacterFromSet(password, "!@#$%^&*()-_=+");
        }

        private bool ContainsCharacterFromSet(string password, string characterSet)
        {
            foreach (char c in characterSet)
            {
                if (password.Contains(c))
                {
                    return true;
                }
            }
            return false;
        }
    }

}
