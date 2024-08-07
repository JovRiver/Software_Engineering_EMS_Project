﻿using System;

namespace Project_2_EMS.Models.StaffModels {
    class StaffMember {
        private int Id { get; }
        private String Username { get; }
        internal String Password { get; }
        internal int AccessLevel { get; }
        internal String FirstName { get; }
        internal String LastName { get; }

        public StaffMember(int id, String username, String password, int accessLevel, String firstName, String lastName) {
            Id = id;
            Username = username;
            Password = password;
            AccessLevel = accessLevel;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
