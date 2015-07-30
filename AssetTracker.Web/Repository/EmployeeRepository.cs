using AssetTracker.Web.Models;

namespace AssetTracker.Web.Repository
{

    // TODO: This is where we would hook into our database calls either Entity Framework or ADO.net
    public class EmployeeRepository
    {
        public Employee Find(int id)
        {
            return new Employee { Id = 1, Name = "Tim Moss"};
        }
    }
}