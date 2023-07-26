using System;

namespace CourseAdoNet.Business.Exceptions
{
    public class ValidationException:Exception
    {
        public ValidationException(string exceptionMessage):base(exceptionMessage) 
        { 
        }
    }
}
