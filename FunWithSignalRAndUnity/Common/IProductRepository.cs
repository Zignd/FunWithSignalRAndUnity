using FunWithSignalRAndUnity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FunWithSignalRAndUnity.Common
{
    public interface IProductRepository
    {
        void Add(Product product);
        Product GetById(int id);
    }
}