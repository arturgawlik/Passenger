using System;

namespace Passenger.Core.Domain
{
    public class User
    {
        public Guid Id { get; protected set; }
        public string Email 
        { 
            get
            {
                return Email;
            }
            protected set
            {
                if(!value.Contains("@") || value.Length <= 5 || string.IsNullOrEmpty(value))
                    throw new Exception("Email is incorrect!");
                    
                Email = value;
            }
        }
        public string Password 
        { 
            get
            {
                return Password;
            } 
            protected set
            {
                if(value.Length <= 5 || String.IsNullOrEmpty(value))
                    throw new Exception("Password is incorrect!");

                Password = value;
            }
         }
        public string Salt { get; protected set; }
        public string Username 
        { 
            get
            {
                return Username;
            } 
            protected set
            {
                if(string.IsNullOrEmpty(value))
                    throw new Exception("Username is incorrect!");
                
                Username = value;
            } 
        }
        public string FullName 
        { 
            get
            {
                return FullName;
            }
            protected set
            {
                if(string.IsNullOrEmpty(value))
                    throw new Exception("Full Name is incorrect!");
            }
         }
        public DateTime CreatedAt { get; protected set; }
        
        protected User()
        {
        }

        public User(string email, string username, string password, string salt)
        {//ZADANIE ZROBIC WALIDACJE DLA email jest emailem, username pusty, haslo nie jest puste, dowolne znaki - wyrazenia reguralne
            Id = Guid.NewGuid();
            Email = email.ToLowerInvariant();
            Username = username;
            Password = Password;
            Salt = salt;
            CreatedAt = DateTime.UtcNow;
        }
    }
}