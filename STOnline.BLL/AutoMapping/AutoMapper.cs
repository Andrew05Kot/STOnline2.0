using AutoMapper;
using STOnline.BLL.DTOs;
using STOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace STOnline.BLL.AutoMapping
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<CategoryDTO, Category>();
            CreateMap<OrderDTO, Order>();
            CreateMap<WorkerDTO, Worker>();
            CreateMap<WorkerCategoryDTO, WorkerCategory>();

            CreateMap<Category, CategoryDTO>();
            CreateMap<Order, OrderDTO>();
            CreateMap<Worker, WorkerDTO>();
            CreateMap<WorkerCategory, WorkerCategoryDTO>();
        }
    }
}
