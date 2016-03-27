using FunWithSignalRAndUnity.Common;
using FunWithSignalRAndUnity.Models;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FunWithSignalRAndUnity.Hubs
{
    public class ProductsHub : Hub
    {
        private readonly IProductRepository _productRepository;

        public ProductsHub(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public string GetProductDescription(int id)
        {
            return _productRepository.GetById(id).Description;
        }
    }
}