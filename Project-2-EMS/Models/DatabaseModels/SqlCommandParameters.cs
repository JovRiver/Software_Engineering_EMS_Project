﻿using Project_2_EMS.Models.PatientModels;
using System;

namespace Project_2_EMS.Models.DatabaseModels {
    public class SqlCommandParameters {
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime FirstDate { get; }
        public DateTime SecondDate { get; }
        public decimal Cost { get; }

        public Patient Patient { get; }
        public PatientAppointment Appointment { get; }
        public PatientPrescription Prescription { get; }

        public SqlCommandParameters() { }

        public SqlCommandParameters(string firstName, string lastName)
            : this(firstName, lastName, DateTime.MinValue, DateTime.MinValue, decimal.Zero, null, null, null) { }

        public SqlCommandParameters(DateTime appointmentDate) 
            : this("", "", appointmentDate, DateTime.MinValue, decimal.Zero, null, null, null) { }

        public SqlCommandParameters(DateTime startDate, DateTime endDate) 
            : this("", "", startDate, endDate, decimal.Zero, null, null, null) { }

        public SqlCommandParameters(PatientAppointment appointment) 
            : this("", "", DateTime.MinValue, DateTime.MinValue, decimal.Zero, appointment, null, null) { }

        public SqlCommandParameters(PatientAppointment appointment, decimal cost)
            : this("", "", DateTime.MinValue, DateTime.MinValue, cost, appointment, null, null) { }

        public SqlCommandParameters(Patient patient) 
            : this("", "", DateTime.MinValue, DateTime.MinValue, decimal.Zero, null, patient, null) { }

        public SqlCommandParameters(Patient patient, DateTime appointmentDate)
            : this("", "", appointmentDate, DateTime.MinValue, decimal.Zero, null, patient, null) { }

        public SqlCommandParameters(PatientPrescription prescription) 
            : this("", "", DateTime.MinValue, DateTime.MinValue, decimal.Zero, null, null, prescription) { }

        public SqlCommandParameters(string firstName, string lastName, DateTime startDate, DateTime endDate, decimal cost, PatientAppointment appointment, Patient patient, PatientPrescription prescription) {
            FirstName = firstName;
            LastName = lastName;
            FirstDate = startDate;
            SecondDate = endDate;
            Cost = cost;
            Appointment = appointment;
            Patient = patient;
            Prescription = prescription;
        }
    }
}
