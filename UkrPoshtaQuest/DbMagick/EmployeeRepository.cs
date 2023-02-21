using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using UkrPoshtaQuest.DbMagick.DbHelper;
using UkrPoshtaQuest.Models;

namespace UkrPoshtaQuest.DbMagick
{
    public class EmployeeRepository<T> : IRepository<T> where T : Employee
    {
        public int Count => new SQLManager().Count(nameof(Employee));
        public EmployeeRepository()
        {
            TryCreateEmployeeTable();
        }
        private void TryCreateEmployeeTable()
        {
            if (!new SQLManager().IsExist(nameof(Employee)))
            {
                new SQLManager().UpdateDatabase(
                    $"CREATE TABLE {nameof(Employee)} (" +
                    "    Id INT PRIMARY KEY IDENTITY(1, 1)," +
                    "    FullName NVARCHAR(100) NOT NULL," +
                    "    DateOfBirth DATE NOT NULL," +
                    "    AddressId INT NOT NULL," +
                    "    PhoneNumber NVARCHAR(20) NOT NULL," +
                    "    HireDate DATE NOT NULL," +
                    "    Salary DECIMAL(18, 8) NOT NULL," +
                    "    DepartmentId INT NOT NULL," +
                    "    PositionId INT NOT NULL," +
                    "    CONSTRAINT FK_Employee_Address FOREIGN KEY(AddressId) REFERENCES Address(Id)," +
                    "    CONSTRAINT FK_Employee_Department FOREIGN KEY(DepartmentId) REFERENCES Department(Id)," +
                    "    CONSTRAINT FK_Employee_Position FOREIGN KEY(PositionId) REFERENCES Position(Id)" +
                    "); ");

            }
        }
        public void Add(T entity)
        {
            //Обов'язкові перевірки:
            //CheckAddressID
            //CheckPositionID
            //CheckDepartmentID
            if (new AddressRespository<Address>().GetById(entity.AddressId) == null)
            {
                throw new Exception("Даний AddressID не існує, введіть реальний AddressID");
            }
            if (new PositionRepository<Position>().GetById(entity.PositionId) == null)
            {
                throw new Exception("Даний PositionId не існує, введіть реальний PositionId");
            }
            if (new DepartmentRepository<Department>().GetById(entity.DepartmentId) == null)
            {
                throw new Exception("Даний DepartmentID не існує, введіть реальний DepartmentID");
            }
            var query = $"INSERT INTO {nameof(Employee)} " +
                "(FullName, DateOfBirth, AddressId, PhoneNumber, HireDate, Salary, DepartmentId, PositionId)" +
                $"VALUES('{entity.FullName}', '{entity.DateOfBirth.ToString("yyyy-MM-dd HH:mm:ss")}', {entity.AddressId}, '{entity.PhoneNumber}', '{entity.HireDate.ToString("yyyy-MM-dd HH:mm:ss")}', {entity.Salary}, {entity.DepartmentId}, {entity.PositionId});";
            new SQLManager().UpdateDatabase(query);
        }

        public void Clear()
        {
            var sQLManager = new SQLManager();
            foreach (var employee in GetAll())
            {
                sQLManager.UpdateDatabase($"DELETE FROM {nameof(Address)} WHERE [Id]={employee.AddressId}");
            }
            new SQLManager().UpdateDatabase("TRUNCATE TABLE " + nameof(Employee));
        }

        public void Delete(int id)
        {
            var employee = GetById(id);
            {
                new SQLManager().UpdateDatabase($"DELETE FROM {nameof(Address)} WHERE [Id]={employee.AddressId}");
            }
            new SQLManager().UpdateDatabase($"DELETE FROM {nameof(Employee)} WHERE [Id]={id}");
        }

        public List<T> GetAll()
        {

            var list = new SQLManager().GetValuesFromDatabase($"SELECT * FROM {nameof(Employee)}");
            var employees = new List<Employee>();
            foreach (dynamic item in list)
            {
                employees.Add(new Employee()
                {
                    Id = item[0],
                    FullName = item[1],
                    DateOfBirth = item[2],
                    AddressId = item[3],
                    PhoneNumber = item[4],
                    HireDate = item[5],
                    Salary = item[6],
                    DepartmentId = item[7],
                    PositionId = item[8]
                });
            }
            return employees as List<T>;
        }

        public T GetById(int id)
        {
            var list = new SQLManager().GetValuesFromDatabase($"SELECT * FROM {nameof(Employee)} WHERE Id={id}");
            if (list.Count == 0)
                return null;
            dynamic item = list.First();

            return new Employee()
            {

                Id = item[0],
                FullName = item[1],
                DateOfBirth = item[2],
                AddressId = item[3],
                PhoneNumber = item[4],
                HireDate = item[5],
                Salary = item[6],
                DepartmentId = item[7],
                PositionId = item[8]
            } as T;
        }

        public void Update(T entity)
        {
            if (new SQLManager().GetValuesFromDatabase($"SELECT * FROM {nameof(Employee)} WHERE Id={entity.Id}").Count == 0)
            {
                throw new Exception("За заданим ID не знайдено сутностей, оновлення не можливе");
            }

            var query = $"UPDATE {nameof(Employee)} " +
            $"SET FullName = '{entity.FullName}', " +
            $"DateOfBirth = '{entity.DateOfBirth.ToString("yyyy-MM-dd HH:mm:ss")}', " +
            $"AddressId = '{entity.AddressId}', " +
            $"PhoneNumber = '{entity.PhoneNumber}', " +
            $"HireDate = '{entity.HireDate.ToString("yyyy-MM-dd HH:mm:ss")}', " +
            $"Salary = '{entity.Salary.ToString(CultureInfo.InvariantCulture)}', " +
            $"DepartmentId = '{entity.DepartmentId}', " +
            $"PositionId = '{entity.PositionId}' " +
            $"WHERE Id = {entity.Id};";

            new SQLManager().UpdateDatabase(query);
        }
    }
}
