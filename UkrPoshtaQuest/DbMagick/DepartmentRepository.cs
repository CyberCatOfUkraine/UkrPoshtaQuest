using System;
using System.Collections.Generic;
using System.Linq;
using UkrPoshtaQuest.DbMagick.DbHelper;
using UkrPoshtaQuest.Models;

namespace UkrPoshtaQuest.DbMagick
{
    public class DepartmentRepository<T> : IRepository<T> where T : Department
    {
        public DepartmentRepository()
        {
            TryCreateDepartmentTable();
        }

        private void TryCreateDepartmentTable()
        {
            if (!new SQLManager().IsExist(nameof(Department)))
            {
                new SQLManager().UpdateDatabase(
                    $"CREATE TABLE {nameof(Department)} (Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL, Name NVARCHAR(100) NOT NULL); ");
            }
        }

        public void Add(T entity)
        {
            new SQLManager().UpdateDatabase($"INSERT INTO Department ([Name]) VALUES ('{entity.Name}')");
        }

        public void Clear()
        {
            new SQLManager().UpdateDatabase("TRUNCATE TABLE " + nameof(Department));
        }

        public void Delete(int id)
        {
            new SQLManager().UpdateDatabase($"DELETE FROM {nameof(Department)} WHERE [Id]={id}");
        }

        public List<T> GetAll()
        {
            var list = new SQLManager().GetValuesFromDatabase("SELECT * FROM Department");
            var departments = new List<Department>();
            foreach (dynamic item in list)
            {
                departments.Add(new Department() { Id = item[0], Name = item[1] });
            }
            return departments as List<T>;
        }

        public T GetById(int id)
        {
            var list = new SQLManager().GetValuesFromDatabase($"SELECT * FROM Department WHERE Id={id}");
            if (list.Count == 0)
                return null;
            dynamic departmentSQL = list.First();
            return new Department() { Id = departmentSQL[0], Name = departmentSQL[1] } as T;
        }


        public void Update(T entity)
        {

            if (new SQLManager().GetValuesFromDatabase($"SELECT * FROM Department WHERE Id={entity.Id}").Count == 0)
            {
                throw new Exception("За заданим ID не знайдено сутностей, оновлення не можливе");
            }
            var query = $"UPDATE Department SET Name='{entity.Name}' WHERE Id={entity.Id}";
            new SQLManager().UpdateDatabase(query);
        }



    }
}


