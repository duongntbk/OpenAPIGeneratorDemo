using MaritimumClient.Api;
using MaritimumClient.Model;
using PecuniaClient.Api;
using System;
using System.Threading.Tasks;

namespace GeneratedClientDemo
{
    class Program
    {
        private static PortApi _portApi = new PortApi("https://localhost:5003");
        private static ShipApi _shipApi = new ShipApi("https://localhost:5003");
        private static AccountApi _accountApi = new AccountApi("https://localhost:5001");
        private static PersonApi _personApi = new PersonApi("https://localhost:5001");

        public static async Task Main(string[] args)
        {
            try
            {
                await CallMaritimumPort();
                await CallMaritimumShip();
                await CallPecuniaAccount();
                await CallPecuniaPerson();
                await ThrowApiException();
            }
            catch (CommonClient.Exceptions.ApiException ex)
            {
                LogError(ex);
            }

            Console.WriteLine("Press Enter...");
            Console.ReadLine();
        }

        private static async Task CallMaritimumPort()
        {
            var haiPhongUuid = new Guid("28153b3b-f3ac-45d1-820d-fec983a9aa56");
            var portReportRequest = new PortReportRequest("Vietnam", true);

            var portIndexTask = _portApi.PortsIndexAsync();
            var portReportTask = _portApi.PortsReportAsync(portReportRequest);
            var portShowTask = _portApi.PortsShowAsync(haiPhongUuid);

            await Task.WhenAll(portIndexTask, portReportTask, portShowTask);

            StartDemoCase(nameof(_portApi.PortsShowAsync));
            var portShowRs = await portShowTask;
            Console.WriteLine(portShowRs.ToString());

            StartDemoCase(nameof(_portApi.PortsReportAsync));
            var portReportRs = await portReportTask;
            foreach (var port in portReportRs)
            {
                Console.WriteLine(port.ToString());
            }

            StartDemoCase(nameof(_portApi.PortsIndexAsync));
            var portIndexRs = await portIndexTask;
            foreach (var port in portIndexRs)
            {
                Console.WriteLine(port.ToString());
            }
        }

        private static async Task CallMaritimumShip()
        {
            var seiraimaruUuid = new Guid("f336a003-fb63-48b3-8180-80c9f5541fc0");
            var haiPhongUuid = new Guid("28153b3b-f3ac-45d1-820d-fec983a9aa56");
            var shipReportRequest = new ShipReportRequest(haiPhongUuid, 25000, 15000);

            var shipIndexTask = _shipApi.ShipsIndexAsync();
            var shipReportTask = _shipApi.ShipsReportAsync(shipReportRequest);
            var shipShowTask = _shipApi.ShipsShowAsync(seiraimaruUuid);

            await Task.WhenAll(shipIndexTask, shipReportTask, shipShowTask);

            StartDemoCase(nameof(_shipApi.ShipsShowAsync));
            var shipShowRs = await shipShowTask;
            Console.WriteLine(shipShowRs.ToString());

            StartDemoCase(nameof(_shipApi.ShipsReportAsync));
            var shipReportRs = await shipReportTask;
            foreach (var ship in shipReportRs)
            {
                Console.WriteLine(ship.ToString());
            }

            StartDemoCase(nameof(_shipApi.ShipsIndexAsync));
            var shipIndexRs = await shipIndexTask;
            foreach (var ship in shipIndexRs)
            {
                Console.WriteLine(ship.ToString());
            }
        }

        private static async Task CallPecuniaAccount()
        {
            var sampleAccountId = new Guid("f1e6a450-04be-423d-9c73-516e196e0257");

            var accountShowTask = _accountApi.AccountsShowAsync(sampleAccountId);
            var accountIndexTask = _accountApi.AccountsIndexAsync();

            await Task.WhenAll(accountShowTask, accountIndexTask);

            StartDemoCase(nameof(_accountApi.AccountsShowAsync));
            var accountShowRs = await accountShowTask;
            Console.WriteLine(accountShowRs.ToString());

            StartDemoCase(nameof(_accountApi.AccountsIndexAsync));
            var accountIndexRs = await accountIndexTask;
            foreach (var account in accountIndexRs)
            {
                Console.WriteLine(account.ToString());
            }
        }

        private static async Task CallPecuniaPerson()
        {
            var johnUuid = new Guid("dbf2a133-b342-4e22-8ef2-aab0ec249b08");

            var peopleShowTask = _personApi.PeopleShowAsync(johnUuid);
            var peopleIndexTask = _personApi.PeopleIndexAsync();

            await Task.WhenAll(peopleShowTask, peopleIndexTask);

            StartDemoCase(nameof(_personApi.PeopleShowAsync));
            var peopleShowRs = await peopleShowTask;
            Console.WriteLine(peopleShowRs.ToString());

            StartDemoCase(nameof(_personApi.PeopleIndexAsync));
            var peopleIndexRs = await peopleIndexTask;
            foreach (var person in peopleIndexRs)
            {
                Console.WriteLine(person.ToString());
            }
        }

        private static async Task ThrowApiException()
        {
            var notExistPersonUuid = new Guid("dbf2a1e3-b34c-4e62-8ef2-aab0e9249b08");
            var notExistPortUuid = new Guid("38153b3b-f2ac-4511-822d-fec993a9aa56");

            var peopleShowTask = _personApi.PeopleShowAsync(notExistPersonUuid);
            var portShowTask = _portApi.PortsShowAsync(notExistPortUuid);

            StartDemoCase(nameof(ThrowApiException));
            await await Task.WhenAny(peopleShowTask, portShowTask); // Yes, we need 2 await keywords here
        }

        private static void LogError(CommonClient.Exceptions.ApiException exception)
        {
            Console.WriteLine($"Error code: {exception.ErrorCode}");
            Console.WriteLine($"Error content: {exception.ErrorContent}");
            Console.WriteLine($"Error message: {exception.Message}");
            Console.WriteLine(exception.StackTrace);
        }

        private static void StartDemoCase(string caseName)
        {
            Console.WriteLine("======================================================");
            Console.WriteLine($"The result of {caseName} is:");
        }
    }
}
