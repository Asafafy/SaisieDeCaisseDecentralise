﻿using System.Collections.Generic;

namespace SoftCaisse.Repositories
{
    public interface IRepository<T>
    {
        T GetById(int id);
        List<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);

    }
}
