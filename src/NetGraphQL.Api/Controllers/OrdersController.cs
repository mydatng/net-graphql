﻿using NetGraphQL.Services.Models.Order;

namespace NetGraphQL.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrdersController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrdersController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet]
    public async Task<IActionResult> GetOrders()
    {
        return Ok(await _orderService.GetOrders());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetOrderById(int id)
    {
        return Ok(await _orderService.GetOrderById(id));
    }

    [HttpPut("update-order/{id}")]
    public async Task<IActionResult> UpdateOrder(int id, [FromBody] Order order)
    {
        return Ok(await _orderService.UpdateOrder(id, order));
    }

    [HttpPost("create-order")]
    public async Task<IActionResult> CreateOrder([FromBody] OrderRequest request)
    {
        return Ok(await _orderService.CreateOrder(request));
    }
}