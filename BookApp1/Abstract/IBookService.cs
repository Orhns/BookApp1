﻿using BookApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp1.Abstract
{
    public interface IBookService
    {
        void Add(Book book);
        void Update(Book book);
        void Delete(Book book);
    }
}
