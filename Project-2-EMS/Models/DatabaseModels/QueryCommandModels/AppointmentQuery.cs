﻿using Project_2_EMS.Models.PatientModels;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Project_2_EMS.Models.DatabaseModels {
    public class AppointmentQuery<T> where T : PatientAppointment {
        private SqlCommand Command;

        public ICountQuery Count() {
            Command = new SqlCommand() {
                CommandText = "SELECT COUNT(*) FROM Appointments;"
            };

            return new CountQuery(Command);
        }

        public INonQuery DeleteBy_VisitId(int visitId) {
            Command = new SqlCommand() {
                CommandText = "DELETE FROM Appointments WHERE VisitID = @visitId;"
            };
            Command.Parameters.Add("@visitId", SqlDbType.Int).Value = visitId;

            return new NonQuery(Command);
        }

        public INonQuery Insert(PatientAppointment appointment) {
            Command = new SqlCommand() {
                CommandText = "INSERT INTO Appointments ([VisitID], [PatientID], [ApptDate], [ApptTime], [Cost], [ReceptNote], [NurseNote], [DoctorNote]) " +
                              "VALUES (@visitId,@patientId,@apptDate,@apptTime,@cost,@receptNote,@nurseNote,@doctorNote);"
            };
            Command.Parameters.Add("@visitId", SqlDbType.Int).Value = appointment.VisitId;
            Command.Parameters.Add("@patientId", SqlDbType.Int).Value = appointment.PatientId;
            Command.Parameters.Add("@apptDate", SqlDbType.Date).Value = appointment.ApptDate;
            Command.Parameters.Add("@apptTime", SqlDbType.Time).Value = appointment.ApptTime;
            Command.Parameters.Add("@cost", SqlDbType.Decimal).Value = appointment.Cost;
            Command.Parameters.Add("@receptNote", SqlDbType.Text).Value = appointment.ReceptNote;
            Command.Parameters.Add("@nurseNote", SqlDbType.Text).Value = appointment.NurseNote;
            Command.Parameters.Add("@doctorNote", SqlDbType.Text).Value = appointment.DoctorNote;

            return new NonQuery(Command);
        }

        public ISelectQuery<T> SelectBy_Date_PatientId(DateTime date, int patientId) {
            Command = new SqlCommand() {
                CommandText = "SELECT * FROM Appointments WHERE ApptDate = @apptDate AND PatientID = @patientId;"
            };
            Command.Parameters.Add("@apptDate", SqlDbType.DateTime).Value = date;
            Command.Parameters.Add("@patientID", SqlDbType.Int).Value = patientId;

            return new SelectQuery<T>(Command);
        }

        public ISelectQuery<T> SelectBy_DateRange(DateTime startDate, DateTime endDate) {
            Command = new SqlCommand() {
                CommandText = "SELECT * FROM Appointments WHERE ApptDate BETWEEN @apptStartDate AND @apptEndDate;"
            };
            Command.Parameters.Add("@ApptStartDate", SqlDbType.DateTime).Value = startDate;
            Command.Parameters.Add("@ApptEndDate", SqlDbType.DateTime).Value = endDate;

            return new SelectQuery<T>(Command);
        }

        public ISelectQuery<T> SelectBy_PatientId(int patientId) {
            Command = new SqlCommand() {
                CommandText = "SELECT * FROM Appointments WHERE PatientID = @patientId;"
            };
            Command.Parameters.Add("@patientId", SqlDbType.Int).Value = patientId;

            return new SelectQuery<T>(Command);
        }

        public ISelectQuery<T> SelectBy_VisitId(int visitId) {
            Command = new SqlCommand() {
                CommandText = "SELECT * FROM Appointments WHERE VisitID = @visitId;"
            };
            Command.Parameters.Add("@visitId", SqlDbType.Int).Value = visitId;

            return new SelectQuery<T>(Command);
        }
    }
}