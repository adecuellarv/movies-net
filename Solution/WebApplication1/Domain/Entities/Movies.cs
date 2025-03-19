﻿namespace WebApplication1.Domain.Entities
{
    public class Movies
    {
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public string? MovieDescription { get; set;}
        public int MovieRaiting { get; set;}
        public int CategoryId { get; set; }
        public int ActorId { get; set; }
    }
}
