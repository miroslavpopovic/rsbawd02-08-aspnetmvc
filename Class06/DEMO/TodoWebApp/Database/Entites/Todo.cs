﻿namespace TodoWebApp.Database.Entites
{
    public class Todo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public int CategoryId { get; set; }
        public int StatusId { get; set; }
    }
}
