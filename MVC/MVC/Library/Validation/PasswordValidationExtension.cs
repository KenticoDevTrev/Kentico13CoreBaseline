﻿using FluentValidation;
using Generic.Models;

namespace Generic.Library.Validation
{
    public static class PasswordValidationExtension
    {

        public static IRuleBuilderOptions<T, string> ValidPassword<T>(this IRuleBuilder<T, string> ruleBuilder, PasswordPolicySettings settings)
        {
            string message = !string.IsNullOrWhiteSpace(settings.ViolationMessage) ? settings.ViolationMessage : string.Empty;
            var options = ruleBuilder.NotNull();
            if (settings.UsePasswordPolicy)
            {
                if(settings.MinLength > 0)
                {
                    options.MinimumLength(settings.MinLength).WithMessage(message);
                }
                if(!string.IsNullOrWhiteSpace(settings.Regex))
                {
                    options.Matches(settings.Regex).WithMessage(message);
                }
                if(settings.NumNonAlphanumericChars > 0)
                {
                    options.Matches($"\\W{{{settings.NumNonAlphanumericChars},999}}").WithMessage(message);
                }
            }
            return options;
        }

    }
}