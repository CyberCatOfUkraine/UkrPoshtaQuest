using System;
using System.Collections.Generic;
using System.Linq;
using UkrPoshtaQuest.DbMagick.DbHelper;
using UkrPoshtaQuest.Models;

namespace UkrPoshtaQuest.DbMagick
{
    public class AddressRespository<T> : IRepository<T> where T : Address
    {
        public AddressRespository()
        {
            TryCreateAddressTable();
        }

        private void TryCreateAddressTable()
        {
            if (!new SQLManager().IsExist(nameof(Address)))
            {
                new SQLManager().UpdateDatabase(
                    $"CREATE TABLE {nameof(Address)} (" +
                    $"Id INT IDENTITY (1, 1) PRIMARY KEY NOT NULL," +
                    $"Region     NVARCHAR(100) NOT NULL," +
                    $"District   NVARCHAR(100) NOT NULL," +
                    $"Settlement NVARCHAR(100) NOT NULL," +
                    $"Street     NVARCHAR(100) NOT NULL," +
                    $"House      NVARCHAR(100) NOT NULL," +
                    $"Apartment  NVARCHAR(100) NULL ); ");
            }
        }

        public void Add(T entity)
        {
            var query =
                $"INSERT INTO {nameof(Address)} " +
                $"(Region, District, Settlement, Street, House, Apartment) " +
                $"VALUES ('{entity.Region}','{entity.District}','{entity.Settlement}','{entity.Street}','{entity.House}'" +
                $",'{entity.Apartment}'" +
                $");";


            new SQLManager().UpdateDatabase(query);
        }

        public void Clear()
        {
            new SQLManager().UpdateDatabase("TRUNCATE TABLE " + nameof(Address));
        }

        public void Delete(int id)
        {
            new SQLManager().UpdateDatabase($"DELETE FROM {nameof(Address)} WHERE [Id]={id}");
        }

        public List<T> GetAll()
        {
            var list = new SQLManager().GetValuesFromDatabase($"SELECT * FROM {nameof(Address)}");
            var addresses = new List<Address>();
            foreach (dynamic item in list)
            {
                var apartment = item[6];
                if (string.IsNullOrEmpty(apartment))
                {
                    apartment = null;
                }
                addresses.Add(new Address()
                {
                    Id = item[0],
                    Region = item[1],
                    District = item[2],
                    Settlement = item[3],
                    Street = item[4],
                    House = item[5],
                    Apartment = apartment
                });
            }
            return addresses as List<T>;

        }

        public T GetById(int id)
        {
            var list = new SQLManager().GetValuesFromDatabase($"SELECT * FROM {nameof(Address)} WHERE Id={id}");
            if (list.Count == 0)
                return null;
            dynamic addressSQL = list.First();

            var apartment = addressSQL[6];
            if (string.IsNullOrEmpty(apartment))
            {
                apartment = null;
            }
            return new Address()
            {
                Id = addressSQL[0],
                Region = addressSQL[1],
                District = addressSQL[2],
                Settlement = addressSQL[3],
                Street = addressSQL[4],
                House = addressSQL[5],
                Apartment = apartment
            } as T;
        }

        public void Update(T entity)
        {
            if (new SQLManager().GetValuesFromDatabase($"SELECT * FROM {nameof(Address)} WHERE Id={entity.Id}").Count == 0)
            {
                throw new Exception("За заданим ID не знайдено сутностей, оновлення не можливе");
            }

            var query = $"UPDATE {nameof(Address)} " +
                $"SET Region = '{entity.Region}', " +
                $"District = '{entity.District}', " +
                $"Settlement = '{entity.Settlement}', " +
                $"Street = '{entity.Street}', " +
                $"House = '{entity.House}', " +
                $"Apartment = '{entity.Apartment}' " +
                $"WHERE Id = {entity.Id};";

            new SQLManager().UpdateDatabase(query);
        }
    }
}
