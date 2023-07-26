using System;

namespace CourseAdoNet.Business.Exceptions
{
    public class BusinessException:Exception
    {
        public BusinessException(string exceptionMessage):base(exceptionMessage)
        {
            
        }
    }
}
