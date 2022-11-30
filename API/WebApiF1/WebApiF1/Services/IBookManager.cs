﻿using WebApiF1.Models;

namespace WebApiF1.Services
{
    public interface IBookManager
    {
        public List<GetBookDto> Get();
        public GetBookDto? Get(int id);
        public bool Exist(int id);
        public List<GetBookDto>? Filter(FilterBookRequest filter);
        public Book? Add(CreateBookDto book);
        public Book? UpdateBook(int id, UpdateBookDto book);
        public Book? DeleteBook(int id);
    }
}