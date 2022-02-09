using System;

namespace TextbookManagement.Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public UserRole Role { get; set; }
    }

    public enum UserRole
    {
        Student,
        Teacher,
        Warehouse
    }
}