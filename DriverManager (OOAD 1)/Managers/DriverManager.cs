using DriverManager__OOAD_1_.Enums;
using DriverManager__OOAD_1_.Transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DriverManager__OOAD_1_
{
    public class DriverManager
    {
        private static DriverManager instance;

        private DriverManager() { }
        public static DriverManager GetInstance()
        {
            if (instance == null)
            {
                instance = new DriverManager();
            }
            return instance;
        }

        // Приватные коллекции для транспорта и водителей
        private List<AbstractTransport> transports = new List<AbstractTransport>();
        private List<Driver> drivers = new List<Driver>();

        // Словари для хранения пар "Водитель → Транспорт" и "Транспорт → Водитель"
        private Dictionary<Driver, AbstractTransport> driverToTransport = new Dictionary<Driver, AbstractTransport>();
        private Dictionary<AbstractTransport, Driver> transportToDriver = new Dictionary<AbstractTransport, Driver>();

        // Публичные свойства для доступа к коллекциям (только для чтения)
        public IReadOnlyList<AbstractTransport> Transports => transports.AsReadOnly();
        public IReadOnlyList<Driver> Drivers => drivers.AsReadOnly();

        // Метод для добавления транспорта
        public void AddTransport(AbstractTransport transport)
        {
            transports.Add(transport);
        }

        // Метод для добавления водителя
        public void AddDriver(Driver driver)
        {
            drivers.Add(driver);
        }

        // Метод для связывания транспорта и водителя
        public void AssignTransportToDriver(Driver driver, AbstractTransport transport)
        {
            if (driver == null || transport == null)
            {
                MessageBox.Show("Водитель или транспорт не выбраны!");
                return;
            }

            // Проверяем, что водитель и транспорт существуют в коллекциях
            if (!drivers.Contains(driver) || !transports.Contains(transport))
            {
                MessageBox.Show("Водитель или транспорт не найдены в системе!");
                return;
            }

            // Проверяем, что транспорт не занят
            if (transportToDriver.ContainsKey(transport))
            {
                MessageBox.Show("Транспорт уже занят другим водителем!");
                return;
            }

            // Проверяем, что водитель не занят другим транспортом
            if (driverToTransport.ContainsKey(driver))
            {
                MessageBox.Show("Водитель уже управляет другим транспортом!");
                return;
            }

            // Связываем транспорт и водителя
            driverToTransport[driver] = transport;
            transportToDriver[transport] = driver;

            // Обновляем статусы
            transport.isBusy = true;
            driver.isBusy = true;
        }

        // Метод для получения транспорта по водителю
        public AbstractTransport GetTransportByDriver(Driver driver)
        {
            return driverToTransport.ContainsKey(driver) ? driverToTransport[driver] : null;
        }

        // Метод для получения водителя по транспорту
        public Driver GetDriverByTransport(AbstractTransport transport)
        {
            return transportToDriver.ContainsKey(transport) ? transportToDriver[transport] : null;
        }

        // Метод для отмены связи между водителем и транспортом
        public void UnassignTransportFromDriver(Driver driver)
        {
            if (driverToTransport.ContainsKey(driver))
            {
                var transport = driverToTransport[driver];
                driverToTransport.Remove(driver);
                transportToDriver.Remove(transport);

                // Обновляем статусы
                transport.isBusy = false;
                driver.isBusy = false;
            }
        }

        // Метод для обновления listViewPairs
        public void UpdatePairsListView(ListView listViewPairs)
        {
            listViewPairs.Items.Clear();

            foreach (var pair in driverToTransport)
            {
                var driver = pair.Key;
                var transport = pair.Value;

                listViewPairs.Items.Add(new ListViewItem(new[] { driver.Name, transport.Name }));
            }
        }

        public void AutoAssignDriversToTransports()
        {
            foreach (var driver in drivers)
            {
                if (driver.isBusy) continue; // Пропускаем занятых водителей

                foreach (var transport in transports)
                {
                    if (transport.isBusy) continue; // Пропускаем занятый транспорт

                    // Проверяем соответствие категорий прав и типа транспорта
                    if ((driver.RequiredLicenses.Contains(LicenseType.B) && transport is Car ||
                        (driver.RequiredLicenses.Contains(LicenseType.D) && transport is Bus ||
                        (driver.RequiredLicenses.Contains(LicenseType.T) && (transport is Tram || transport is Trolleybus)))))
                    {
                        AssignTransportToDriver(driver, transport);
                        break; // Переходим к следующему водителю
                    }
                }
            }
        }
    }
}
