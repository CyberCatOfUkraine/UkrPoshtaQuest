using System;
using System.Collections.Generic;
using System.Linq;
using UkrPoshtaQuest.DbMagick.DbHelper;
using UkrPoshtaQuest.Models;

namespace UkrPoshtaQuest.DbMagick
{
    public class CompanyRepository<T> : IRepository<T> where T : Company
    {
        public int Count => new SQLManager().Count(nameof(Company));

        public CompanyRepository()
        {
            TryCreateCompanyTable();
        }
        private void TryCreateCompanyTable()
        {
            if (!new SQLManager().IsExist(nameof(Company)))
            {
                new SQLManager().UpdateDatabase(
                    $"CREATE TABLE {nameof(Company)} (Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL, CompanyInfo NVARCHAR(100) NOT NULL); ");
            }
        }

        public void Add(T entity)
        {
            new SQLManager().UpdateDatabase($"INSERT INTO {nameof(Company)} ([CompanyInfo]) VALUES ('{entity.CompanyInfo}')");
        }

        public void Clear()
        {
            new SQLManager().UpdateDatabase("TRUNCATE TABLE " + nameof(Company));
        }

        public void Delete(int id)
        {
            new SQLManager().UpdateDatabase($"DELETE FROM {nameof(Company)} WHERE [Id]={id}");
        }

        public List<T> GetAll()
        {
            var list = new SQLManager().GetValuesFromDatabase($"SELECT * FROM {nameof(Company)}");
            var departments = new List<Company>();
            foreach (dynamic item in list)
            {
                departments.Add(new Company() { Id = item[0], CompanyInfo = item[1] });
            }
            return departments as List<T>;
        }

        public T GetById(int id)
        {
            var list = new SQLManager().GetValuesFromDatabase($"SELECT * FROM {nameof(Company)} WHERE Id={id}");
            if (list.Count == 0)
                return null;
            dynamic companySQL = list.First();
            return new Company() { Id = companySQL[0], CompanyInfo = companySQL[1] } as T;
        }


        public void Update(T entity)
        {

            if (new SQLManager().GetValuesFromDatabase($"SELECT * FROM {nameof(Company)} WHERE Id={entity.Id}").Count == 0)
            {
                throw new Exception("За заданим ID не знайдено сутностей, оновлення не можливе");
            }
            var query = $"UPDATE {nameof(Company)} SET CompanyInfo='{entity.CompanyInfo}' WHERE Id={entity.Id}";
            new SQLManager().UpdateDatabase(query);
        }
    }
}
