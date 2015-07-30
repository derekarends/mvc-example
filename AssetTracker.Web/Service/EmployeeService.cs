using AssetTracker.Web.Models;
using AssetTracker.Web.Repository;

namespace AssetTracker.Web.Service
{
    // TODO: This is where all of our business logic should live
    public class EmployeeService
    {
        private readonly EmployeeRepository _employeeRepository;

        public EmployeeService()
        {
            _employeeRepository = new EmployeeRepository();
        }

        public Employee Find(int id)
        {
            return _employeeRepository.Find(id);
        }
    }
}