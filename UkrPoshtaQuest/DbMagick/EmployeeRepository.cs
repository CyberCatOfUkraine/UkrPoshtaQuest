using System;
using System.Collections.Generic;
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
            var query = "INSERT INTO Employee " +
                "(FullName, DateOfBirth, AddressId, PhoneNumber, HireDate, Salary, DepartmentId, PositionId)" +
                $"VALUES('{entity.FullName}', '{entity.DateOfBirth}', {entity.AddressId}, '{entity.PhoneNumber}', '{entity.HireDate}', {entity.Salary}, {entity.DepartmentId}, {entity.PositionId});";
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
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
