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
            departmentRepository.Add(new Department() { Name = "Jab3" });*/
            /*var jab = departmentRepository.GetAll();

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
            /*AddressRespository<Address> addressRespository = new AddressRespository<Address>();
            addressRespository.Add(
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

            /* foreach (var address in addressRespository.GetAll())
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
             }*/
            /*PositionRepository<Position> positionRepository = new PositionRepository<Position>();
            positionRepository.Add(new Position { Name = "Інжнер" });
            positionRepository.Add(new Position { Name = "Завхоз" });
            positionRepository.Add(new Position { Name = "Начальник" });*/

            EmployeeRepository<Employee> employeeRepository = new EmployeeRepository<Employee>();
            /*employeeRepository.Add(new Employee()
            {
                FullName = "Чювак",
                AddressId = 1,
                DateOfBirth = System.DateTime.Now.AddYears(-35),
                DepartmentId = 1,
                HireDate = System.DateTime.Now,
                PhoneNumber = "+380 324 23 32",
                PositionId = 1,
                Salary = 5000
            });
            employeeRepository.Add(new Employee()
            {
                FullName = "Чювак 2 ",
                AddressId = 1,
                DateOfBirth = System.DateTime.Now.AddYears(-25),
                DepartmentId = 1,
                HireDate = System.DateTime.Now,
                PhoneNumber = "+380 524 23 32",
                PositionId = 3,
                Salary = 5000
            });
            employeeRepository.Add(new Employee()
            {
                FullName = "Чювак 3",
                AddressId = 1,
                DateOfBirth = System.DateTime.Now.AddYears(-15),
                DepartmentId = 1,
                HireDate = System.DateTime.Now,
                PhoneNumber = "+380 364 23 32",
                PositionId = 2,
                Salary = 5000
            });*/

            //(FullName, DateOfBirth, AddressId, PhoneNumber, HireDate, Salary, DepartmentId, PositionId)

            /* var employees = employeeRepository.GetAll();
             foreach (var employee in employees)
             {
                 System.Console.WriteLine("ID: " + employee.Id);
                 System.Console.WriteLine("ПІБ: " + employee.FullName);
                 System.Console.WriteLine("Номер телефону: " + employee.PhoneNumber);
                 System.Console.WriteLine("ЗП: " + employee.Salary);
                 System.Console.WriteLine("ДР: " + employee.DateOfBirth);
                 System.Console.WriteLine("PositionId: " + employee.PositionId);
                 System.Console.WriteLine("HireDate: " + employee.HireDate);
                 System.Console.WriteLine("AddressId: " + employee.AddressId);
                 System.Console.WriteLine("DepartmentId: " + employee.DepartmentId);
                 System.Console.WriteLine(new string('-', 10));
             }
             var firstEmployee = employeeRepository.GetById(1);
             firstEmployee.FullName = "Анатолій Іванович Свирид";
             employeeRepository.Update(firstEmployee);
             System.Console.WriteLine(
             firstEmployee.FullName == "Анатолій Іванович Свирид"
                 );
 */
            CompanyRepository<Company> companyRepository = new CompanyRepository<Company>();
            companyRepository.Add(new Company { CompanyInfo = "1" });
            companyRepository.Add(new Company { CompanyInfo = "2" });
            companyRepository.Add(new Company { CompanyInfo = "3" });
            companyRepository.Add(new Company { CompanyInfo = "4" });
            companyRepository.Add(new Company { CompanyInfo = "5" });
            System.Console.WriteLine("Count is 5: " + (companyRepository.Count == 5));
            foreach (var company in companyRepository.GetAll())
            {
                System.Console.WriteLine("ID: " + company.Id);
                System.Console.WriteLine("Info: " + company.CompanyInfo);
            }
            System.Console.WriteLine("First item is " + companyRepository.GetById(1).Id + " : " + companyRepository.GetById(1).CompanyInfo);
            var first = companyRepository.GetById(1);
            first.CompanyInfo = "Abra-test-a-cadabra";
            companyRepository.Update(first);
            System.Console.WriteLine("First item is " + companyRepository.GetById(1).Id + " : " + companyRepository.GetById(1).CompanyInfo);
            companyRepository.Delete(first.Id);
            System.Console.WriteLine("Count is :" + companyRepository.Count);
            System.Console.ReadKey();
        }
    }
}
