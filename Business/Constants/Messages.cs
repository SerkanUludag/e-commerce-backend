using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added successfully";

        public static string ProductNameInvalid = "Product name is invalid";

        public static string MaintenanceTime = "Maintenance time!";

        public static string ProductsListed = "Products listed successfully";

        public static string ProductCountOfCategoryError = "No more than 10 products in one category";

        public static string ProductNameAlreadyExists = "Product name already exists";

        public static string CategoryLimitExceded = "There can't be more than 15 categories";

        public static string AuthorizationDenied = "No authorized to do this operation";
        public static string UserRegistered = "User registered";
        public static string UserNotFound = "User not found";
        public static string PasswordError = "Password Error";
        public static string SuccessfulLogin = "Succesfully logged in";
        public static string UserAlreadyExists = "User already exist";
        public static string AccessTokenCreated = "Token created";
    }
}
