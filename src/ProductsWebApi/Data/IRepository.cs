﻿namespace ProductsWebApi.Data
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        T Add(T entity);
        T Update(T entity);
        void Delete(int id);
    }
}
