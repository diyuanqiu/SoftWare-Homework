using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OrderSysAPI.Entity;
using System.Linq;
namespace OrderSysAPI.Controllers;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{
    private readonly OrderContext orderSys;
    public OrderController(OrderContext context)
    {
        this.orderSys = context;
    }
    //GET: api/order?name=...
    [HttpGet]
    public ActionResult<List<Order>> GetOrders(string name)
    {
        IQueryable<Order> query = orderSys.Orders.Include(o=>o.Details).ThenInclude(details=>details.Good).Include("Client");
        if (name != null)
        {
            query = query.Where(o => o.Client.Name.Contains(name));
        }
        return query.ToList<Order>();
    }
    //GET: api/order/{id}
    [HttpGet("{id}")]
    public ActionResult<Order> GetOrderById(string id)
    {
        var order = orderSys.Orders.Include(o=>o.Details).ThenInclude(details=>details.Good).Include("Client").FirstOrDefault(o => o.Id == id);
        if (order == null)
        {
            return NotFound();
        }
        return order;
    }
    //POST: api/order
    [HttpPost]
    public ActionResult<Order> PostOrder(Order order)
    {
        try
        {
            orderSys.Orders.Add(order);
            orderSys.SaveChanges();
        }
        catch (Exception e)
        {
            return BadRequest(e.InnerException.Message);
        }
        return order;
    }
    //PUT: api/order/{id}
    [HttpPut("{id}")]
    public ActionResult<Order> UpdateOrder(string id,Order order){
        if(id!=order.Id){
            return BadRequest("Id cannot be modified!");
        }
        try{
            orderSys.Entry(order).State = EntityState.Modified;
            orderSys.SaveChanges();
        }
        catch(Exception e){
            string error = e.Message;
            if(e.InnerException != null){
                error = e.InnerException.Message;
            }
            return BadRequest(error);
        }
        return NoContent();
    }
    //DELETE: api/tode/{id}
    [HttpDelete("{id}")]
    public ActionResult<Order> DeleteOrder(string id){
        try{
            var order = orderSys.Orders.Include(o=>o.Details).ThenInclude(details=>details.Good).Include("Client").FirstOrDefault(o => o.Id == id);
            if(order != null){
                orderSys.Remove(order);
                orderSys.SaveChanges();
            }
        }
        catch(Exception e){
            string error = e.Message;
            if(e.InnerException != null){
                error = e.InnerException.Message;
            }
            return BadRequest(error);
        }
        return NoContent();
    }
}