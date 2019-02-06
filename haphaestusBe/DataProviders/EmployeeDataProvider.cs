using haphaestusBe.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;

namespace haphaestusBe.DataProviders
{
    /// <summary>
    /// Gets, adds, and updated employee data
    /// </summary>
    public class EmployeeDataProvider : IEmployeeDataProvider
    {
        /// <summary>
        /// Gets all employees
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/> of all <see cref="Employee"/>s</returns>
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            var collection = GetEmployeesCollection();

            // TODO Refactor this to fetch via batches manually so we don't keep the connection open
            var employees = (await collection
                .FindAsync(filter => true, new FindOptions<Employee, Employee>
                {
                    Sort = Builders<Employee>.Sort
                        .Ascending(e => e.Name.LastName)
                        .Ascending(e => e.Name.FirstName)
                })).ToEnumerable();

            return employees;
        }

        /// <summary>
        /// Adds a new employee
        /// </summary>
        /// <param name="newEmployee">The new employee to add</param>
        /// <returns>Returns the added employee</returns>
        public async Task<Employee> AddEmployee(Employee newEmployee)
        {
            var collection = GetEmployeesCollection();

            newEmployee.Id = new Random().Next(1_000_000_000);

            await collection.InsertOneAsync(newEmployee);

            return newEmployee;
        }

        /// <summary>
        /// Updates an existing employee
        /// </summary>
        /// <param name="employeeToUpdate">The existing employee to update</param>
        /// <returns>Returns the updated employee</returns>
        public async Task<Employee> UpdateEmployee(Employee employeeToUpdate)
        {
            var collection = GetEmployeesCollection();

            await collection.ReplaceOneAsync(e => e.Id == employeeToUpdate.Id, employeeToUpdate);

            return employeeToUpdate;
        }

        private IMongoCollection<Employee> GetEmployeesCollection()
        {
            string connectionString = ConfigurationManager.AppSettings["MongoDBConnectionString"];
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("haphaestusdata");

            return database.GetCollection<Employee>("Employees");
        }
    }
}
