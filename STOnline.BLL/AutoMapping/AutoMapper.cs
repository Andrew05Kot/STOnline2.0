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
            CreateMap<ClientDTO, Client>();
            CreateMap<OrderDTO, Order>();
            CreateMap<RepairDTO, Repair>();
            CreateMap<WorkerDTO, Worker>();
            CreateMap<WorkerCategoryDTO, WorkerCategory>();

            CreateMap<Category, CategoryDTO>();
            CreateMap<Client, ClientDTO>();
            CreateMap<Order, OrderDTO>();
            CreateMap<Repair, RepairDTO>();
            CreateMap<Worker, WorkerDTO>();
            CreateMap<WorkerCategory, WorkerCategoryDTO>();
        }
    }
}
