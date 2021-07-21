﻿using System.Data;
using System.Data.SqlClient;

namespace Project_2_EMS.Models.DatabaseModels {
    public class UpdateBalanceBy_Cost_PatientId : INonQuery {
        private readonly int _Cost;
        private readonly int _PatientId;

        public UpdateBalanceBy_Cost_PatientId(int cost, int patientId) {
            _Cost = cost;
            _PatientId = patientId;
        }

        public void ExecuteQuery(SqlConnection connection, SqlCommand command) {
            command.Connection = connection;
            command.CommandText = "UPDATE PatientInfo SET Balance = Balance + @cost FROM PatientInfo WHERE PatientID = @patientId;";
            command.Parameters.Add("@cost", SqlDbType.Decimal).Value = _Cost;
            command.Parameters.Add("@patientId", SqlDbType.Int).Value = _PatientId;

            _ = command.ExecuteNonQuery();
        }
    }
}