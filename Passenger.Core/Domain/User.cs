using System;

namespace Passenger.Core.Domain
{
    public class User
    {
        public Guid Id { get; protected set; }
        public string Email { get; protected set; }
        public string Password { get; protected set; }
        public string Salt { get; protected set; }
        public string Username {get; protected set; }
        public string FullName {get; protected set; }
        public DateTime CreatedAt {get; protected set; }

        public void SetEmail(string email)
        {
            if(string.IsNullOrWhiteSpace(email))
                throw new Exception("Email can not be empty.");

            if(email.Length <= 5 || email.Length >= 99)
                throw new Exception("Email can not be shorter than 5 and Longer than 99 charaters.");

            Email = email.ToLowerInvariant();
        }
        public void SetPassword(string password)
        {
            if(string.IsNullOrWhiteSpace(password))
                throw new Exception("Password can not be empty.");
            
            if(password.Length <= 5 || password.Length >= 99)
                throw new Exception("Password can not be shorter than 5 and Longer than 99 charaters.");

            Password = password;
        }

        public void SetUsername(string username)
        {   
            if(string.IsNullOrWhiteSpace(username))
                throw new Exception("Username can not be empty.");
            
            if(username.Length <= 5 || username.Length >= 99)
                throw new Exception("Username can not be shorter than 5 and Longer than 99 charaters.");

            Username = username;
        }
        protected User()
        {
        }

        public User(string email, string username, string password, string salt)
        {
            Id = Guid.NewGuid();
            SetEmail(email);
            SetUsername(username);
            SetPassword(password);
            Salt = salt;
            CreatedAt = DateTime.UtcNow;
        }
    }
}