﻿namespace RickAndMortyAPIApp.Infrastructure.DTOs;

public class PageInfoDTO
{
        public int count { get; set; }
        public int pages { get; set; }
        public string next { get; set; }
        public string prev { get; set; }
    
}