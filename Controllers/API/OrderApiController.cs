﻿using J6.BL.Servises;
using J6.DAL.Database;
using J6.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace J6.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderApiController : Controller
    {
        private readonly IOrderServices _orderServices;
        private readonly DbContainer _context;

        public OrderApiController(IOrderServices orderServices, DbContainer context)
        {
            _orderServices = orderServices;
            _context = context;
        }

        [HttpPost]
        [Route("approveOrder")]
        public async Task approveOrder(int CustomerId)
        {
            await _orderServices.approveOrder(CustomerId);
        }

        [HttpGet]
        [Route("getAllOrders")]
        public async Task<ICollection<Order>> getAllOrders()
        {
            return await _orderServices.getAllOrders();
        }

        [HttpPost]
        [Route("HandleAdminStatus")]
        public void HandleAdminStatus(int OrderId, OrderStatus status)
        {
            _orderServices.HandleAdminStatus(OrderId, status);
        }

        [HttpGet]
        [Route("SwitchCartToOrder/{CustomerId}")]
        public async Task SwitchCartToOrder(int CustomerId)
        {
            await _orderServices.SwitchCartToOrder(CustomerId);
        }
    }
}