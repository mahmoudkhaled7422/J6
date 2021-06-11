﻿using J6.DAL.Database;
using J6.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace J6.BL.Servises
{
    public class UserSavedBagServices : IUserSavedBagServices
    {
        private readonly DbContainer _context;
        private readonly UserManager<AppUser> _userManager;

        public UserSavedBagServices(DbContainer context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task<ICollection<Product>> GetSavedProductsAsync(int UserId)
        {
            int BagId = await _context.SavedBag.Where(B => B.CustomerId == UserId)
                                                .Select(B => B.Id).FirstOrDefaultAsync();
            
            var products = await _context.Products.Where(p => 
                                p.ProductsBag.Any(pb => pb.ProductId == p.ProductId && pb.SaveBagId == BagId))
                                    .Include(p=>p.Promotion)
                                    .Include(p=>p.ProductImages)
                                    .ToListAsync();
            return products;
        }

        public async Task SetItemToSavedBagAsync(int UserId, int ProductId)
        {
            var Bag = await _context.SavedBag.FirstOrDefaultAsync(C => C.CustomerId == UserId);

            if(Bag == null)
            {
                Bag = new SavedBag { CustomerId = UserId };
                await _context.SavedBag.AddAsync(Bag);
                await _context.SaveChangesAsync();
                Bag = await _context.SavedBag.FirstOrDefaultAsync(C => C.CustomerId == UserId);
            }

            var ProductBag = _context.ProductsBag.FirstOrDefaultAsync(PB => PB.ProductId == ProductId && PB.SaveBagId == Bag.Id);
            if (ProductBag == null) return;

            var NewProductBag = new MiddleSavedProduct { ProductId = ProductId, SaveBagId = Bag.Id };

            await _context.ProductsBag.AddAsync(NewProductBag);
            await _context.SaveChangesAsync();
        }
    }
}
