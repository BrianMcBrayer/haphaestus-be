using haphaestusBe.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;

namespace haphaestusBe.DataProviders
{
    public class EmployeeDataProvider
    {
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            var collection = GetEmployeesCollection();

            var employees = (await collection
                .FindAsync(filter => true, new FindOptions<Employee, Employee>
                {
                    Sort = Builders<Employee>.Sort
                        .Ascending(e => e.Name.LastName)
                        .Ascending(e => e.Name.FirstName)
                })).ToEnumerable();

            return employees;
        }

        public async Task<Employee> AddEmployee(Employee newEmployee)
        {
            var collection = GetEmployeesCollection();

            newEmployee.Id = new Random().Next(1_000_000_000);

            await collection.InsertOneAsync(newEmployee);

            return newEmployee;
        }

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
