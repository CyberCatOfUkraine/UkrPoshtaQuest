using UkrPoshtaQuest.DbMagick;
using UkrPoshtaQuest.Models;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*DepartmentRepository<Department> departmentRepository = new DepartmentRepository<Department>();

            departmentRepository.Add(new Department() { Name = "IT Department" });
            departmentRepository.Add(new Department() { Name = "Jab1" });
            departmentRepository.Add(new Department() { Name = "Jab2" });
            departmentRepository.Add(new Department() { Name = "Jab3" });
            var jab = departmentRepository.GetAll();

            foreach (var department in jab)
            {
                System.Console.WriteLine(department.Id + " : " + department.Name);
            }
            System.Console.WriteLine(new string('-', 10));
            int id = 1;
            var firstDepartment = departmentRepository.GetById(id);
            System.Console.WriteLine($"first is \n{firstDepartment.Id} : {firstDepartment.Name}");
            System.Console.WriteLine("UPDATING");

            firstDepartment.Name = "IT Department";
            departmentRepository.Update(firstDepartment);
            System.Console.WriteLine($"first is \n{departmentRepository.GetById(id).Id} : {departmentRepository.GetById(id).Name}");
            */
            AddressRespository<Address> addressRespository = new AddressRespository<Address>();
            /*addressRespository.Add(
                new Address
                {
                    Region = "Область1",
                    District = "Район1",
                    Settlement = "Село",
                    Street = "Вулиця1",
                    House = "Будинок"
                });
            addressRespository.Add(
                new Address
                {
                    Region = "Область2",
                    District = "Район2",
                    Settlement = "Місто",
                    Street = "Вулиця2",
                    House = "Будинок2",
                    Apartment = "Квартира"
                });
            addressRespository.Add(
                new Address
                {
                    Region = "Область3",
                    District = "Район3",
                    Settlement = "Місто",
                    Street = "Вулиця1",
                    House = "Будинок"
                });*/

            foreach (var address in addressRespository.GetAll())
            {
                System.Console.WriteLine(address.Region);
                System.Console.WriteLine(address.District);
                System.Console.WriteLine(address.Settlement);
                System.Console.WriteLine(address.Street);
                System.Console.WriteLine(address.House);
                if (address.Apartment != null)
                {
                    System.Console.WriteLine(address.Apartment);
                }
                System.Console.WriteLine(new string('-', 10));
            }
            var firstAddress = addressRespository.GetById(1);
            System.Console.WriteLine($"first is \n");
            System.Console.WriteLine(firstAddress.Region);
            System.Console.WriteLine(firstAddress.District);
            System.Console.WriteLine(firstAddress.Settlement);
            System.Console.WriteLine(firstAddress.Street);
            System.Console.WriteLine(firstAddress.House);
            if (firstAddress.Apartment != null)
            {
                System.Console.WriteLine(firstAddress.Apartment);
            }

            System.Console.ReadKey();
            System.Console.WriteLine("UPDATING");

            firstAddress.Region = "Київська";
            firstAddress.District = "Дмитрівський";
            firstAddress.Settlement = "Велика Дмитрівка";
            firstAddress.Street = "Великого Дмитра";
            firstAddress.House = "5";
            firstAddress.Apartment = "51";
            addressRespository.Update(firstAddress);
            System.Console.WriteLine($"first is \n");
            System.Console.WriteLine(firstAddress.Region);
            System.Console.WriteLine(firstAddress.District);
            System.Console.WriteLine(firstAddress.Settlement);
            System.Console.WriteLine(firstAddress.Street);
            System.Console.WriteLine(firstAddress.House);
            if (firstAddress.Apartment != null)
            {
                System.Console.WriteLine(firstAddress.Apartment);
            }

        }
    }
}
