using System;

namespace PatientPortal.Models;

public class PatientIntakeModel
    {
        // Personal Information
        public required string  FirstName { get; set; }
        public required string MiddleName { get; set; }
        public required string LastName { get; set; }
        public required DateTime DateOfBirth { get; set; }
        public required string Gender { get; set; }
        public required string MaritalStatus { get; set; }

        // Contact Information
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public required string Address1 { get; set; }
        public required string Address2 { get; set; }
        public required string City { get; set; }
        public required string State { get; set; }
        public required string ZipCode { get; set; }
        public required string Country { get; set; } = "United States";
        public required string PreferredContact { get; set; }

        // Emergency Contact Information
        public required string EmergencyName { get; set; }

        public required string EmergencyRelationship { get; set; }
        public required string EmergencyPhone { get; set; }
        public required string EmergencyEmail { get; set; }

        // Insurance Information
        public required string InsuranceProvider { get; set; }
        public required string PolicyNumber { get; set; }
        public required string GroupNumber { get; set; }
        public required string PolicyHolder { get; set; }
        public required string PolicyHolderRelation { get; set; } = "Self";
        public required string InsurancePhone { get; set; }

        // Medical History
        public required string PrimaryCare { get; set; }
        public required string VisitReason { get; set; }


        public required string Allergies { get; set; }

 
        public required string AllergiesList { get; set; }
        public required string CurrentMedications { get; set; }
        public required string Hospitalized { get; set; }
        public required string HospitalizedReason { get; set; }
        public List<string> Conditions { get; set; } = new List<string>();
        public required string OtherConditions { get; set; }

        // Lifestyle Information
        public required string Smoke { get; set; }


        public required string Alcohol { get; set; }


        public required string Exercise { get; set; }

        // Family Medical History

        public List<string> FamilyHistory { get; set; } = new List<string>();
        public required string FamOtherDetails { get; set; }

        // Consent
        public bool Consent { get; set; }
        public bool PrivacyPolicy { get; set; }

        // Additional helper properties
        public string FullName
        {
            get
            {
                if (string.IsNullOrEmpty(MiddleName))
                    return $"{FirstName} {LastName}";
                else
                    return $"{FirstName} {MiddleName} {LastName}";
            }
        }
        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - DateOfBirth.Year;
                if (DateOfBirth.Date > today.AddYears(-age))
                    age--;
                return age;
            }
        }

        // Form submission timestamp
        public DateTime SubmissionDate { get; set; } = DateTime.Now;
    }
