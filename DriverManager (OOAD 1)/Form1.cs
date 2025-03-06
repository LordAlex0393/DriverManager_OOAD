using DriverManager__OOAD_1_.Enums;
using DriverManager__OOAD_1_.Transport;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DriverManager__OOAD_1_
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();

            listViewPairs.View = View.Details;
            listViewPairs.Columns.Add("Водитель", 150);
            listViewPairs.Columns.Add("Транспорт", 150);

            foreach (LicenseType license in Enum.GetValues(typeof(LicenseType)))
            {
                checkedListBoxDriverLicenses.Items.Add(license);
            }

            foreach (TransportType transport in Enum.GetValues(typeof(TransportType)))
            {
                comboBoxTransportType.Items.Add(transport);
            }
        }

        private void buttonAddTransport_Click(object sender, EventArgs e)
        {
            // Проверка на пустые поля
            if (string.IsNullOrWhiteSpace(textBoxTransportName.Text))
            {
                MessageBox.Show("Введите название транспорта!");
                return;
            }

            if (comboBoxTransportType.SelectedItem == null)
            {
                MessageBox.Show("Выберите тип транспорта!");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text) || !int.TryParse(textBox1.Text, out int transportSize))
            {
                MessageBox.Show("Введите корректную вместимость транспорта!");
                return;
            }

            // Получаем данные из формы
            string transportName = textBoxTransportName.Text;
            string transportType = comboBoxTransportType.SelectedItem?.ToString();

            AbstractTransport transport = null;

            // Создаем объект в зависимости от типа транспорта
            switch (transportType)
            {
                case "Car":
                    transport = new Car(transportName, transportSize);
                    break;
                case "Bus":
                    transport = new Bus(transportName, transportSize);
                    break;
                case "Tram":
                    transport = new Tram(transportName, transportSize);
                    break;
                case "Trolleybus":
                    transport = new Trolleybus(transportName, transportSize);
                    break;
                default:
                    MessageBox.Show("Выберите тип транспорта!");
                    return;
            }

            // Добавляем транспорт в список (например, в ListBox)
            listBoxTransport.Items.Add($"{transport.Name} [{transportType}]");

            // Очищаем поля после добавления
            textBoxTransportName.Clear();
            comboBoxTransportType.SelectedIndex = -1;
            textBox1.Clear();

            DriverManager.GetInstance().AddTransport(transport);

            // Автоматическое распределение
            DriverManager.GetInstance().AutoAssignDriversToTransports();

            // Обновление listViewPairs
            DriverManager.GetInstance().UpdatePairsListView(listViewPairs);
        }

        private void buttonAddDriver_Click(object sender, EventArgs e)
        {
            // Проверка на пустые поля
            if (string.IsNullOrWhiteSpace(textBoxDriverName.Text))
            {
                MessageBox.Show("Введите имя водителя!");
                return;
            }

            if (checkedListBoxDriverLicenses.CheckedItems.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы одну категорию прав!");
                return;
            }

            // Получаем имя водителя
            string driverName = textBoxDriverName.Text;

            // Получаем выбранные категории прав из CheckedListBox
            List<LicenseType> selectedLicenses = new List<LicenseType>();
            foreach (var item in checkedListBoxDriverLicenses.CheckedItems)
            {
                if (Enum.TryParse(item.ToString(), out LicenseType license))
                {
                    selectedLicenses.Add(license);
                }
            }

            // Создаем объект водителя
            Driver driver = new Driver(driverName, selectedLicenses);

            // Добавляем водителя в список в формате "Имя [Категории]"
            string licensesString = string.Join(", ", selectedLicenses);
            listBoxDrivers.Items.Add($"{driver.Name} [{licensesString}]");

            // Очищаем поля после добавления
            textBoxDriverName.Clear();
            for (int i = 0; i < checkedListBoxDriverLicenses.Items.Count; i++)
            {
                checkedListBoxDriverLicenses.SetItemChecked(i, false);
            }


            DriverManager.GetInstance().AddDriver(driver);

            // Автоматическое распределение
            DriverManager.GetInstance().AutoAssignDriversToTransports();

            // Обновление listViewPairs
            DriverManager.GetInstance().UpdatePairsListView(listViewPairs);
        }
        public void AddPairToListView(Driver driver, AbstractTransport transport)
        {
            listViewPairs.Items.Add(new ListViewItem(new[] { driver.Name, transport.Name }));
        }
    }
}
