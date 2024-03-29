﻿using BookStore.Application.Contracts;
using BookStore.Context;
using BookStore.DTOs;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookStore.Infrastructure.Repositories
{
    public class CartItemRepository : Repository<CartItem, int>, ICartItemRepository
    {
        BookStoreContext context;
        public CartItemRepository(BookStoreContext _bookStoreContext) : base(_bookStoreContext)
        {
            context = _bookStoreContext;
        }

        public bool ChangeQuantity(int cartItemId, int quantity)
        {


            // Retrieve the associated book
            var item = context.cartItems.FirstOrDefault(i => i.Id == cartItemId);

            if (item == null)
                return false;

            if (quantity == 0)
                Delete(item);
            else
            {
                item.Quantity = quantity;
                Update(item);
            }

            context.SaveChanges();

            return true;
        }
        public IQueryable<BookCart> GetCustomerCart(int customerId)
        {
            return from item in context.cartItems
                   where item.CustomerID == customerId
                   join book in context.books
                   on item.BookID equals book.Id
                   select new BookCart
                   {
                       BookId = book.Id,
                       CartItemId = item.Id,
                       Title = book.Name,
                       Price = book.Price,
                       Quantity = item.Quantity,
                       Stock = book.Stock,
                       Image = book.BookImg
                   };
        }
        public void PlaceOrder(Order order)
        {
            //Create Order

            context.orders.Add(order);
            context.SaveChanges();

            //Add Cart items into Order items
            //Get All Customer Catr items
            var cartItems = context.cartItems.Where(c => c.CustomerID == order.CustomerID);

            foreach (var item in cartItems)
            {
                //Create Order item
                OrderItem orderItem = new OrderItem();
                orderItem.OrderID = order.Id;
                orderItem.Quantity = item.Quantity;
                orderItem.BookID = item.BookID;
                context.orderItems.Add(orderItem);

                //Remove CartItems
                context.cartItems.Remove(item);
            }
            context.SaveChanges();


        }

    }
}
