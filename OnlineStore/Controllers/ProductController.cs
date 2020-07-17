using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Model;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineStore.Controllers
{
    public class ProductController : Controller
    {

        private readonly IMapper _mapper;


        public ProductController(IMapper mapper) {

            _mapper = mapper;

        }


    }
}
