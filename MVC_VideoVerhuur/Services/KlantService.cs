using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_VideoVerhuur.Models;

namespace MVC_VideoVerhuur.Services
{
    public class KlantService
    {
        public Klant GetKlantByNaamAndPostCode(string naam,int postcode)
        {
            using (var db = new VideoVerhuurEntities())
            {
                var query = (from klant in db.Klanten
                            where klant.Naam == naam
                            && klant.PostCode == postcode
                            select klant).FirstOrDefault();
                return query;            
            }
        }
    }
}