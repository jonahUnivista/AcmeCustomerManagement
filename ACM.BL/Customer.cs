using System;
using ACM.Common;

namespace ACM.BL
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public OperationsResult ValidateEmail()
        {
            OperationsResult operationsResult = new OperationsResult();

            if (string.IsNullOrWhiteSpace(this.EmailAddress))
            {
                operationsResult.Success = false;
                operationsResult.AddMessage("Email address is null");
            }

            if (operationsResult.Success)
            {
                var isValidFormat = true;
                // Code here that validates the format of the email
                // using regular expressions.
                if (!isValidFormat)
                {
                    operationsResult.Success = false;
                    operationsResult.AddMessage("Email address is not in a correct format");
                } 
            }


            if (operationsResult.Success)
            {
                var isRealDomain = true;
                if (!isRealDomain)
                {
                    operationsResult.Success = false;
                    operationsResult.AddMessage("Email addres does not include a valid domain");
                } 
            }

            return operationsResult;
        }

        public decimal CalculatePercentOfGoalSteps(string goalSteps, string actualSteps)
        {
            if (string.IsNullOrWhiteSpace(goalSteps)) throw new ArgumentException("Goal must be enterd", "goalSteps");
            if (string.IsNullOrWhiteSpace(actualSteps)) throw new ArgumentException("Actual steps count must be entered", "actualSteps");

            // try 3
            decimal goalStepCount;
            if (!decimal.TryParse(goalSteps, out goalStepCount)) throw new ArgumentException("Goal must be numeric");

            decimal actualStepCount;
            if (!decimal.TryParse(actualSteps, out actualStepCount)) throw new ArgumentException("Actual steps must be numeric", "actualSteps");

            return CalculatePercentOfGoalSteps(goalStepCount, actualStepCount);
        }
        public decimal CalculatePercentOfGoalSteps(decimal goalStepCount, decimal actualStepCount)
        {
            if (goalStepCount <= 0) throw new ArgumentException("Goal must be greater than 0", "goalSteps");

            return Math.Round(((actualStepCount / goalStepCount) * 100), 2);
        }

    }
}
