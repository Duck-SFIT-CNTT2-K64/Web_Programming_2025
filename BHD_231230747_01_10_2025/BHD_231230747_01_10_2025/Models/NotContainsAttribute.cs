using System.ComponentModel.DataAnnotations;

namespace BHD_231230747_01_10_2025.Models
{
    public class NotContainsAttribute : ValidationAttribute
    {
        private readonly string[] _words;
        public NotContainsAttribute(params string[] words) => _words = words ?? [];
        protected override ValidationResult? IsValid(object? value, ValidationContext ctx)
        {
            if (value is string s && !string.IsNullOrWhiteSpace(s))
            {
                foreach (var w in _words)
                {
                    if (s.Contains(w, StringComparison.OrdinalIgnoreCase))
                        return new ValidationResult(ErrorMessage ?? $"Noi dung chua tu cam!: {w}");
                }
            }
            return ValidationResult.Success;
        }
    }
}
