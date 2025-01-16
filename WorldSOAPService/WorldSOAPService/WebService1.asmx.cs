using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using WorldSOAPService.DataLayer;
using WorldSOAPService.DataLayer.Models;

namespace WorldSOAPService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        private readonly DatabaseAccess _dataAccess = new DatabaseAccess();

        [WebMethod]
        public List<Country> GetAllCountries()
        {
            return _dataAccess.GetAllCountries();
        }

        [WebMethod]
        public Country GetCountryByCode(string countryCode)
        {
            return _dataAccess.GetCountryByCode(countryCode);
        }

        [WebMethod]
        public List<City> GetAllCitiesOfCountry(string countryCode)
        {
            return _dataAccess.GetAllCitiesOfCountry(countryCode);
        }

        [WebMethod]
        public City GetCityByName(string cityName)
        {
            return _dataAccess.GetCityByName(cityName);
        }

        [WebMethod]
        public int? GetCountryPopulation(string countryCode)
        {
            return _dataAccess.GetCountryPopulation(countryCode);
        }
    }
}
