using System;
using System.Collections.Generic;
using System.Linq;
using UkrPoshtaQuest.DbMagick.DbHelper;
using UkrPoshtaQuest.Models;

namespace UkrPoshtaQuest.DbMagick
{
    public class PositionRepository<T> : IRepository<T> where T : Position
    {
        public PositionRepository()
        {
            TryCreatePositionTable();
        }

        private void TryCreatePositionTable()
        {
            if (!new SQLManager().IsExist(nameof(Position)))
            {
                new SQLManager().UpdateDatabase(
                    $"CREATE TABLE {nameof(Position)} (Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL, Name NVARCHAR(100) NOT NULL); ");
            }
        }

        public void Add(T entity)
        {
            new SQLManager().UpdateDatabase($"INSERT INTO {nameof(Position)} ([Name]) VALUES ('{entity.Name}')");
        }

        public void Clear()
        {
            new SQLManager().UpdateDatabase("TRUNCATE TABLE " + nameof(Position));
        }

        public void Delete(int id)
        {
            new SQLManager().UpdateDatabase($"DELETE FROM {nameof(Position)} WHERE [Id]={id}");
        }

        public List<T> GetAll()
        {
            var list = new SQLManager().GetValuesFromDatabase($"SELECT * FROM {nameof(Position)}");
            var positions = new List<Position>();
            foreach (dynamic item in list)
            {
                positions.Add(new Position() { Id = item[0], Name = item[1] });
            }
            return positions as List<T>;
        }

        public T GetById(int id)
        {
            var list = new SQLManager().GetValuesFromDatabase($"SELECT * FROM {nameof(Position)} WHERE Id={id}");
            if (list.Count == 0)
                return null;
            dynamic positionSQL = list.First();
            return new Position() { Id = positionSQL[0], Name = positionSQL[1] } as T;
        }


        public void Update(T entity)
        {

            if (new SQLManager().GetValuesFromDatabase($"SELECT * FROM {nameof(Position)} WHERE Id={entity.Id}").Count == 0)
            {
                throw new Exception("За заданим ID не знайдено сутностей, оновлення не можливе");
            }
            var query = $"UPDATE {nameof(Position)} SET Name='{entity.Name}' WHERE Id={entity.Id}";
            new SQLManager().UpdateDatabase(query);
        }
    }
}
