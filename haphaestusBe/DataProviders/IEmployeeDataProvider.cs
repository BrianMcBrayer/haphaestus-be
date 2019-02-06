using System.Collections.Generic;
using System.Threading.Tasks;
using haphaestusBe.Models;

namespace haphaestusBe.DataProviders
{
    /// <summary>
    /// Gets, adds, and updated employee data
    /// </summary>
    public interface IEmployeeDataProvider
    {
        /// <summary>
        /// Gets all employees
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/> of all <see cref="Employee"/>s</returns>
        Task<Employee> AddEmployee(Employee newEmployee);

        /// <summary>
        /// Adds a new employee
        /// </summary>
        /// <param name="newEmployee">The new employee to add</param>
        /// <returns>Returns the added employee</returns>
        Task<IEnumerable<Employee>> GetEmployees();

        /// <summary>
        /// Updates an existing employee
        /// </summary>
        /// <param name="employeeToUpdate">The existing employee to update</param>
        /// <returns>Returns the updated employee</returns>
        Task<Employee> UpdateEmployee(Employee employeeToUpdate);
    }
}