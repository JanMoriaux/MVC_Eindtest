using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_VideoVerhuur.Models;

namespace MVC_VideoVerhuur.Services
{
    public class VideoService
    {
        public List<Genre> GenreLijst()
        {
            using (var db = new VideoVerhuurEntities())
            {
                return db.Genres.ToList();
            }
        }
        public Genre GetGenreById(int id)
        {
            using (var db = new VideoVerhuurEntities())
            {
                return db.Genres.Find(id);
            }
        }
        public List<Film> GetFilmsByGenreId(int id)
        {
            using (var db = new VideoVerhuurEntities())
            {
                var query = from film in db.Genres.Find(id).Films
                            orderby film.Titel
                            select film;
                return query.ToList();
            }
        }
        public Film GetFilmById(int id)
        {
            using (var db = new VideoVerhuurEntities())
            {
                return db.Films.Find(id);
            }
        }
        public void RentMovie(int filmId,int klantId)
        {            
            using (var db = new VideoVerhuurEntities())
            {
                var verhuur = new Verhuur();
                var film = db.Films.Find(filmId);
                film.InVoorraad -= 1;
                film.TotaalVerhuurd += 1;                
                verhuur.Film = film;
                verhuur.KlantNr = klantId;
                verhuur.VerhuurDatum = DateTime.Today;

                db.Verhuur.Add(verhuur);                   
                db.SaveChanges();          
            }
        }
    }
}