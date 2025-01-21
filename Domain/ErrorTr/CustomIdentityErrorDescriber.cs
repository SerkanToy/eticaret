using Microsoft.AspNetCore.Identity;

namespace eticaret.Domain.ErrorTr
{
    public class CustomIdentityErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError DefaultError()
        {
            return new IdentityError
            {
                Code = nameof(DefaultError),
                Description = string.Format(ErrorMessage.DefaultError)
                //An unknown failure has occurred.
            };
        }

        public override IdentityError ConcurrencyFailure()
        {
            return new IdentityError
            {
                Code = nameof(ConcurrencyFailure),
                Description = string.Format(ErrorMessage.ConcurrencyFailure)
                //Optimistic concurrency failure, object has been modified.
            };
        }

        public override IdentityError PasswordMismatch()
        {
            return new IdentityError
            {
                Code = nameof(PasswordMismatch),
                Description = string.Format(ErrorMessage.PasswordMismatch)
                //Incorrect password.
            };
        }

        public override IdentityError InvalidToken()
        {
            return new IdentityError
            {
                Code = nameof(InvalidToken),
                Description = string.Format(ErrorMessage.InvalidToken)
                //Invalid token.
            };
        }

        public override IdentityError LoginAlreadyAssociated()
        {
            return new IdentityError
            {
                Code = nameof(LoginAlreadyAssociated),
                Description = string.Format(ErrorMessage.LoginAlreadyAssociated)
                //A user with this login already exists.
            };
        }
        public override IdentityError InvalidUserName(string userName)
        {
            return new IdentityError
            {
                Code = nameof(InvalidUserName),
                Description = string.Format(ErrorMessage.InvalidUserName, userName)
                //User name {0} is invalid, can only contain letters or digits.
            };
        }
        public override IdentityError InvalidEmail(string email)
        {
            return new IdentityError
            {
                Code = nameof(InvalidEmail),
                Description = string.Format(ErrorMessage.InvalidEmail, email)
                //Email {0} is invalid.
            };
        }
        public override IdentityError DuplicateUserName(string userName)
        {
            return new IdentityError
            {
                Code = nameof(DuplicateUserName),
                Description = string.Format(ErrorMessage.DuplicateUserName, userName)
                //User Name {0} is already taken.
            };
        }
        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError
            {
                Code = nameof(DuplicateEmail),
                Description = string.Format(ErrorMessage.DuplicateEmail, email)
                //Email {0} is already taken.
            };
        }
        public override IdentityError InvalidRoleName(string role)
        {
            return new IdentityError
            {
                Code = nameof(InvalidRoleName),
                Description = string.Format(ErrorMessage.InvalidRoleName, role)
                //Role name {0} is invalid.
            };
        }
        public override IdentityError DuplicateRoleName(string role)
        {
            return new IdentityError
            {
                Code = nameof(DuplicateRoleName),
                Description = string.Format(ErrorMessage.DuplicateRoleName, role)
                //Role name {0} is already taken.
            };
        }
        public override IdentityError UserAlreadyHasPassword()
        {
            return new IdentityError
            {
                Code = nameof(UserAlreadyHasPassword),
                Description = string.Format(ErrorMessage.UserAlreadyHasPassword)
                //User already has a password set.
            };
        }
        public override IdentityError UserLockoutNotEnabled()
        {
            return new IdentityError
            {
                Code = nameof(UserLockoutNotEnabled),
                Description = string.Format(ErrorMessage.UserLockoutNotEnabled)
                //Lockout is not enabled for this user.
            };
        }
        public override IdentityError UserAlreadyInRole(string role)
        {
            return new IdentityError
            {
                Code = nameof(UserAlreadyInRole),
                Description = string.Format(ErrorMessage.UserAlreadyInRole, role)
                //"User already in role {0}.
            };
        }
        public override IdentityError UserNotInRole(string role)
        {
            return new IdentityError
            {
                Code = nameof(UserNotInRole),
                Description = string.Format(ErrorMessage.UserNotInRole, role)
                //User is not in role {0}.
            };
        }
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Code = nameof(PasswordTooShort),
                Description = string.Format(ErrorMessage.PasswordTooShort, length)
                //Passwords must be at least {0} characters.
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresNonAlphanumeric),
                Description = string.Format(ErrorMessage.PasswordRequiresNonAlphanumeric)
                //Passwords must have at least one non alphanumeric character.
            };
        }
        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresDigit),
                Description = string.Format(ErrorMessage.PasswordRequiresDigit)
                //Passwords must have at least one digit ('0'-'9').
            };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresLower),
                Description = string.Format(ErrorMessage.PasswordRequiresLower)
                //Passwords must have at least one lowercase ('a'-'z').
            };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresUpper),
                Description = string.Format(ErrorMessage.PasswordRequiresUpper)
                //Passwords must have at least one uppercase ('A'-'Z').
            };
        }

    }
}
