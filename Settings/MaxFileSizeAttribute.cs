<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations;

namespace GameZone.Attributes;

public class MaxFileSizeAttribute : ValidationAttribute
{
    private readonly int _maxFileSize;

    public MaxFileSizeAttribute(int maxFileSize)
    {
        _maxFileSize = maxFileSize;
    }

    protected override ValidationResult? IsValid
        (object? value, ValidationContext validationContext)
    {
        var file = value as IFormFile;

        if (file is not null)
        {
            if (file.Length > _maxFileSize)
            {
                return new ValidationResult($"Maximum allowed size is {_maxFileSize} bytes");
            }
        }

        return ValidationResult.Success;
    }
=======
﻿using System.ComponentModel.DataAnnotations;

namespace GameZone.Attributes;

public class MaxFileSizeAttribute : ValidationAttribute
{
    private readonly int _maxFileSize;

    public MaxFileSizeAttribute(int maxFileSize)
    {
        _maxFileSize = maxFileSize;
    }

    protected override ValidationResult? IsValid
        (object? value, ValidationContext validationContext)
    {
        var file = value as IFormFile;

        if (file is not null)
        {
            if (file.Length > _maxFileSize)
            {
                return new ValidationResult($"Maximum allowed size is {_maxFileSize} bytes");
            }
        }

        return ValidationResult.Success;
    }
>>>>>>> b905b14e014d082ee4d3e4a1db7d5c994c74a9c2
}