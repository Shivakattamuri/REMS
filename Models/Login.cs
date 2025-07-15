using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace REMS.Models
{
    public class LoginViewModel : IValidatableObject
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email format.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var errors = new List<ValidationResult>();

            // Custom Email Validation
            if (!string.IsNullOrEmpty(Email) && !Email.Contains("@"))
            {
                errors.Add(new ValidationResult("Email must contain '@' symbol.", new[] { "Email" }));
            }

            // Password Validations
            if (Password.Length < 8)
            {
                errors.Add(new ValidationResult("Password must be at least 8 characters long.", new[] { "Password" }));
            }
            if (!Regex.IsMatch(Password, @"[A-Z]"))
            {
                errors.Add(new ValidationResult("Password must contain at least one uppercase letter.", new[] { "Password" }));
            }
            if (!Regex.IsMatch(Password, @"\d"))
            {
                errors.Add(new ValidationResult("Password must contain at least one number.", new[] { "Password" }));
            }
            if (!Regex.IsMatch(Password, @"[^A-Za-z0-9]"))
            {
                errors.Add(new ValidationResult("Password must contain at least one special character.", new[] { "Password" }));
            }

            return errors;
        }
    }
}


