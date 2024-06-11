using BussinessObject.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CartItemDAO
    {
        public static List<CartItem> GetCartItems()
        {
            var listCarts = new List<CartItem>();
            try
            {
                using var db = new FugoodExchangeContext();
                listCarts = db.CartItems.ToList();
            }
            catch (Exception e)
            {

            }
            return listCarts;
        }

        public static void CreateCartItem(CartItem cartItem)
        {
            try
            {
                using var context = new FugoodExchangeContext();
                context.CartItems.Add(cartItem);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void UpdateCartItem(CartItem cartItem)
        {
            try
            {
                using var context = new FugoodExchangeContext();
                context.Entry<CartItem>(cartItem).State = EntityState.Modified;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void DeleteCartItem(CartItem cartItem)
        {
            try
            {
                using var context = new FugoodExchangeContext();
                var a = context.CartItems.SingleOrDefault(c => c.CartItemId == cartItem.CartItemId);
                context.CartItems.Remove(a);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static CartItem GetCartItemsByProductId(int productId)
        {
            using var db = new FugoodExchangeContext();
            return db.CartItems.FirstOrDefault(c => c.ProductId.Equals(productId));
        }
    }
}
