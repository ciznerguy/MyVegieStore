using System;

namespace MyVegieStore.Services
{
    public class UserIdService
    {
        private int? _userId;
        private string _fullName;
        private string _userType;
        private int? _orderId; // New field for OrderId

        public int? UserId
        {
            get => _userId;
            set
            {
                if (value is > 0)
                {
                    _userId = value;
                }
                else
                {
                    throw new ArgumentException("Invalid UserId");
                }
            }
        }

        public string FullName
        {
            get => _fullName;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _fullName = value;
                }
                else
                {
                    throw new ArgumentException("Full name cannot be empty");
                }
            }
        }

        public string UserType
        {
            get => _userType;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _userType = value;
                }
                else
                {
                    throw new ArgumentException("User type cannot be empty");
                }
            }
        }

        public int? OrderId
        {
            get => _orderId;
            set
            {
                if (value is > 0)
                {
                    _orderId = value;
                }
                else
                {
                    throw new ArgumentException("Invalid OrderId");
                }
            }
        }

        public bool IsLoggedIn => _userId.HasValue;

        public void Logout()
        {
            _userId = null;
            _fullName = null;
            _userType = null;
            _orderId = null; // Reset OrderId on logout
        }
    }
}
