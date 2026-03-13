using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PasswordValidatorTest
{
    // Password Validator Class
    public class PasswordValidator
    {
        public bool ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                return false;

            // Minimum 8 characters
            if (password.Length < 8)
                return false;

            // At least one number
            bool hasNumber = password.Any(char.IsDigit);

            // At least one uppercase letter
            bool hasUpper = password.Any(char.IsUpper);

            return hasNumber && hasUpper;
        }
    }

    // MSTest Test Class
    [TestClass]
    public class PasswordValidatorTests
    {
        PasswordValidator validator = new PasswordValidator();

        // Test Case 1: Valid Password
        [TestMethod]
        public void ValidatePassword_ValidPassword_ReturnsTrue()
        {
            bool result = validator.ValidatePassword("Password1");

            Assert.IsTrue(result);
        }

        // Test Case 2: Missing Number
        [TestMethod]
        public void ValidatePassword_MissingNumber_ReturnsFalse()
        {
            bool result = validator.ValidatePassword("Password");

            Assert.IsFalse(result);
        }

        // Test Case 3: Missing Uppercase
        [TestMethod]
        public void ValidatePassword_MissingUppercase_ReturnsFalse()
        {
            bool result = validator.ValidatePassword("password1");

            Assert.IsFalse(result);
        }

        // Test Case 4: Too Short
        [TestMethod]
        public void ValidatePassword_TooShort_ReturnsFalse()
        {
            bool result = validator.ValidatePassword("Pas1");

            Assert.IsFalse(result);
        }
    }
}