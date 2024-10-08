<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 84f9ff5d8f56ef279a027ce172551f645af7c764
﻿using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Final.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Final.ViewModels
{
    public class CreateDoctorsFormViewModel :Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Experince { get; set; }
        public string Qualifications { get; set; }
        public string Img { get; set; }
        public string Address { get; set; }
        public float? TotalRate { get; set; }

        public int? Price { get; set; }
        public string? PhoneNumber { get; set; }

        public List<WorkingTime>? WorkingTime { get; set; }
        public List<Appointment>? Appointments { get; set; }
        [ForeignKey("Specialization")]
        public int? SpecializationId { get; set; }
        public IEnumerable<SelectListItem> SpecializationsList { get; set; } = Enumerable.Empty<SelectListItem>();
        public Specialization? Specializations { get; set; }
        
        public List<Review>? Reviews { get; set; }
    }
}
<<<<<<< HEAD
=======
=======
﻿using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Final.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Final.ViewModels
{
    public class CreateDoctorsFormViewModel :Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Experince { get; set; }
        public string Qualifications { get; set; }
        public string Img { get; set; }
        public string Address { get; set; }
        public float? TotalRate { get; set; }

        public int? Price { get; set; }
        public string? PhoneNumber { get; set; }

        public List<WorkingTime>? WorkingTime { get; set; }
        public List<Appointment>? Appointments { get; set; }
        [ForeignKey("Specialization")]
        public int? SpecializationId { get; set; }
        public IEnumerable<SelectListItem> SpecializationsList { get; set; } = Enumerable.Empty<SelectListItem>();
        public Specialization? Specializations { get; set; }
        
        public List<Review>? Reviews { get; set; }
    }
}
>>>>>>> b905b14e014d082ee4d3e4a1db7d5c994c74a9c2
>>>>>>> 84f9ff5d8f56ef279a027ce172551f645af7c764
