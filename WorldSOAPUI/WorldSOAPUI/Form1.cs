using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldSOAPUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetAllCountries_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo một đối tượng client để gọi dịch vụ web
                localhost.WebService1 client = new localhost.WebService1();

                // Gọi phương thức GetAllCountries từ dịch vụ web
                localhost.Country[] countries = client.GetAllCountries();
                System.Diagnostics.Debug.WriteLine(countries.Length);

                // Xóa dữ liệu cũ trong DataGridView (nếu có)
                dataGridViewResults.Rows.Clear();
                dataGridViewResults.Columns.Clear();

                // Thêm các cột mới
                dataGridViewResults.Columns.Add("Code", "Code");
                dataGridViewResults.Columns.Add("Name", "Name");
                dataGridViewResults.Columns.Add("Continent", "Continent");
                dataGridViewResults.Columns.Add("Region", "Region");
                dataGridViewResults.Columns.Add("SurfaceArea", "Surface Area");
                dataGridViewResults.Columns.Add("IndepYear", "Independence Year");
                dataGridViewResults.Columns.Add("Population", "Population");
                dataGridViewResults.Columns.Add("LifeExpectancy", "Life Expectancy");
                dataGridViewResults.Columns.Add("GNP", "GNP");
                dataGridViewResults.Columns.Add("LocalName", "Local Name");
                dataGridViewResults.Columns.Add("GovernmentForm", "Government Form");
                dataGridViewResults.Columns.Add("HeadOfState", "Head of State");
                dataGridViewResults.Columns.Add("Capital", "Capital");
                dataGridViewResults.Columns.Add("Code2", "Code2");

                foreach (localhost.Country country in countries)
                {
                    // Hiển thị thông tin các trường cần thiết
                    dataGridViewResults.Rows.Add(
                        country.Code,
                        country.Name,
                        country.Continent,
                        country.Region,
                        country.SurfaceArea,
                        country.IndepYear.HasValue ? country.IndepYear.Value.ToString() : "N/A",
                        country.Population,
                        country.LifeExpectancy.HasValue ? country.LifeExpectancy.Value.ToString() : "N/A",
                        country.GNP.HasValue ? country.GNP.Value.ToString() : "N/A",
                        country.LocalName,
                        country.GovernmentForm,
                        country.HeadOfState,
                        country.Capital.HasValue ? country.Capital.Value.ToString() : "N/A",
                        country.Code2
                    );
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGetCountryByCode_Click(object sender, EventArgs e)
        {
            try
            {
                string countryCode = textBoxCountryCode.Text.Trim();
                if (string.IsNullOrWhiteSpace(countryCode))
                {
                    MessageBox.Show("Please enter a country code.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                localhost.WebService1 client = new localhost.WebService1();
                localhost.Country country = client.GetCountryByCode(countryCode);

                if (country != null)
                {
                    dataGridViewResults.Rows.Clear();
                    dataGridViewResults.Columns.Clear();

                    dataGridViewResults.Columns.Add("Code", "Code");
                    dataGridViewResults.Columns.Add("Name", "Name");
                    dataGridViewResults.Columns.Add("Continent", "Continent");
                    dataGridViewResults.Columns.Add("Population", "Population");

                    dataGridViewResults.Rows.Add(country.Code, country.Name, country.Continent, country.Population);
                }
                else
                {
                    MessageBox.Show("No country found with the given code.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGetCityByName_Click(object sender, EventArgs e)
        {
            try
            {
                string cityName = textBoxCityName.Text.Trim();
                if (string.IsNullOrWhiteSpace(cityName))
                {
                    MessageBox.Show("Please enter a city name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                localhost.WebService1 client = new localhost.WebService1();
                localhost.City city = client.GetCityByName(cityName);

                if (city != null)
                {
                    dataGridViewResults.Rows.Clear();
                    dataGridViewResults.Columns.Clear();

                    dataGridViewResults.Columns.Add("ID", "ID");
                    dataGridViewResults.Columns.Add("Name", "Name");
                    dataGridViewResults.Columns.Add("CountryCode", "Country Code");
                    dataGridViewResults.Columns.Add("District", "District");
                    dataGridViewResults.Columns.Add("Population", "Population");

                    dataGridViewResults.Rows.Add(city.ID, city.Name, city.CountryCode, city.District, city.Population);
                }
                else
                {
                    MessageBox.Show("No city found with the given name.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGetCitiesByCountry_Click(object sender, EventArgs e)
        {
            try
            {
                string countryCode = textBoxCountryCode.Text.Trim();
                if (string.IsNullOrWhiteSpace(countryCode))
                {
                    MessageBox.Show("Please enter a country code.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                localhost.WebService1 client = new localhost.WebService1();
                localhost.City[] cities = client.GetAllCitiesOfCountry(countryCode);

                if (cities != null && cities.Length > 0)
                {
                    dataGridViewResults.Rows.Clear();
                    dataGridViewResults.Columns.Clear();

                    dataGridViewResults.Columns.Add("ID", "ID");
                    dataGridViewResults.Columns.Add("Name", "Name");
                    dataGridViewResults.Columns.Add("CountryCode", "Country Code");
                    dataGridViewResults.Columns.Add("District", "District");
                    dataGridViewResults.Columns.Add("Population", "Population");

                    foreach (var city in cities)
                    {
                        dataGridViewResults.Rows.Add(city.ID, city.Name, city.CountryCode, city.District, city.Population);
                    }
                }
                else
                {
                    MessageBox.Show("No cities found for the given country code.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGetPopulationByCountryCode_Click(object sender, EventArgs e)
        {
            try
            {
                string countryCode = textBoxCountryCode.Text.Trim();
                if (string.IsNullOrWhiteSpace(countryCode))
                {
                    MessageBox.Show("Please enter a country code.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo client cho WebService1
                localhost.WebService1 client = new localhost.WebService1();

                // Gọi phương thức GetCountryPopulation để lấy dân số
                int? population = client.GetCountryPopulation(countryCode);

                if (population.HasValue)
                {
                    // Hiển thị dân số vào một MessageBox
                    MessageBox.Show($"The population of the country with code {countryCode} is {population.Value}.",
                                    "Country Population", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No population data found for the given country code.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
