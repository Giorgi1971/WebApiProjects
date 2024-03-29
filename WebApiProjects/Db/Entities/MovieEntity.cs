﻿using MoviesDatabase.Api.Db.Entities;
using System.ComponentModel.DataAnnotations;

namespace WebApiProjects.Db.Entities
{

    public enum MovieStatus
    {
        Active,
        Deleted
    }


    public class MovieEntity
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public MovieStatus Status { get; set; } = MovieStatus.Active;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public List<DirectorEntity> Directors { get; set; }
        public List<GenreEntity> Genres { get; set; }


        public MovieEntity()
        {
            Directors = new List<DirectorEntity>();
        }

    }
}
