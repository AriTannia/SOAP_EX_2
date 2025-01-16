using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WorldSOAPService.DataLayer.Models;

namespace WorldSOAPService.DataLayer
{
    public class DatabaseAccess
    {
        private readonly string connectionString = "Data Source=ARITANNIA;Initial Catalog=world;Integrated Security=True";

        public List<Country> GetAllCountries()
        {
            List<Country> countries = new List<Country>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Country", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    countries.Add(new Country
                    {
                        Code = reader["Code"].ToString(),
                        Name = reader["Name"].ToString(),
                        Continent = reader["Continent"].ToString(),
                        Region = reader["Region"].ToString(),
                        SurfaceArea = (decimal)reader["SurfaceArea"],
                        IndepYear = reader["IndepYear"] as short?,
                        Population = (int)reader["Population"],
                        LifeExpectancy = reader["LifeExpectancy"] as decimal?,
                        GNP = reader["GNP"] as decimal?,
                        GNPOld = reader["GNPOld"] as decimal?,
                        LocalName = reader["LocalName"].ToString(),
                        GovernmentForm = reader["GovernmentForm"].ToString(),
                        HeadOfState = reader["HeadOfState"]?.ToString(),
                        Capital = reader["Capital"] as int?,
                        Code2 = reader["Code2"].ToString()
                    });
                }
            }
            return countries;
        }

        public Country GetCountryByCode(string countryCode)
        {
            Country country = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Country WHERE Code = @Code", connection);
                command.Parameters.AddWithValue("@Code", countryCode);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    country = new Country
                    {
                        Code = reader["Code"].ToString(),
                        Name = reader["Name"].ToString(),
                        Continent = reader["Continent"].ToString(),
                        Region = reader["Region"].ToString(),
                        SurfaceArea = (decimal)reader["SurfaceArea"],
                        IndepYear = reader["IndepYear"] as short?,
                        Population = (int)reader["Population"],
                        LifeExpectancy = reader["LifeExpectancy"] as decimal?,
                        GNP = reader["GNP"] as decimal?,
                        GNPOld = reader["GNPOld"] as decimal?,
                        LocalName = reader["LocalName"].ToString(),
                        GovernmentForm = reader["GovernmentForm"].ToString(),
                        HeadOfState = reader["HeadOfState"]?.ToString(),
                        Capital = reader["Capital"] as int?,
                        Code2 = reader["Code2"].ToString()
                    };
                }
            }
            return country;
        }

        public List<City> GetAllCitiesOfCountry(string countryCode)
        {
            List<City> cities = new List<City>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM City WHERE CountryCode = @CountryCode", connection);
                command.Parameters.AddWithValue("@CountryCode", countryCode);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cities.Add(new City
                    {
                        ID = (int)reader["ID"],
                        Name = reader["Name"].ToString(),
                        CountryCode = reader["CountryCode"].ToString(),
                        District = reader["District"].ToString(),
                        Population = (int)reader["Population"]
                    });
                }
            }
            return cities;
        }

        public City GetCityByName(string cityName)
        {
            City city = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM City WHERE Name = @Name", connection);
                command.Parameters.AddWithValue("@Name", cityName);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    city = new City
                    {
                        ID = (int)reader["ID"],
                        Name = reader["Name"].ToString(),
                        CountryCode = reader["CountryCode"].ToString(),
                        District = reader["District"].ToString(),
                        Population = (int)reader["Population"]
                    };
                }
            }
            return city;
        }

        public int? GetCountryPopulation(string countryCode)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=ARITANNIA;Initial Catalog=world;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT Population FROM country WHERE Code = @Code", connection);
                command.Parameters.AddWithValue("@Code", countryCode);
                object result = command.ExecuteScalar();

                return result != null ? Convert.ToInt32(result) : (int?)null;
            }
        }
    }
}