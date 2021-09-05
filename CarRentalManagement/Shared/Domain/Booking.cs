using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRentalManagement.Shared.Domain
{
    public class Booking:BaseDomainModel, IValidatableObject
    {
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime? DateIn { get; set; }
        public virtual Customer Customer { get; set; }
        public int CustomerId { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (DateIn!=null)
            {
                if (DateIn <= DateOut)
                {
                    yield return new ValidationResult("Date in must be greater than Date Out");
                }
            }
        }
    }
}