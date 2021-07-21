﻿using System.Data.SqlClient;
using System.Data;

namespace Project_2_EMS.Models.DatabaseModels {
    public class DeleteAppointmentBy_VisitId : INonQuery {
        private readonly int _VisitId;

        public DeleteAppointmentBy_VisitId(int visitId) {
            _VisitId = visitId;
        }

        public void ExecuteQuery(SqlConnection connection, SqlCommand command) {
            command.Connection = connection;
            command.CommandText = "DELETE FROM Appointments WHERE VisitID = @visitId;";
            command.Parameters.Add("@visitId", SqlDbType.Int).Value = _VisitId;

            _ = command.ExecuteNonQuery();
        }
    }
}