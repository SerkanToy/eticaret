using eticaret.Domain.Core.Entities;
using eticaret.Domain.Database.Context;
using eticaret.Domain.Repository.Interface;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace eticaret.Domain.Repository.Repositorys
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(CommerceContext context) : base(context)
        {
        }

        public List<Product> ProductJoin(Expression<Func<Product, bool>> predicate = null)
        {
            return context.Product.Where(predicate).
                Include(j => j.SubCategory).ThenInclude(g => g.Category).
                Include(j => j.ColorProduct).ThenInclude(g => g.Colors).
                Include(i => i.Images).
                Include(r => r.RatinProducts).ThenInclude(g => g.Ratin).Select(x => new Product
                {
                    Id = x.Id,
                    Name = x.Name,
                    IsDeleted = x.IsDeleted,
                    SubCategory = x.SubCategory,
                    Category = x.SubCategory.Category,
                    ColorProduct = x.ColorProduct,
                    Colors = x.ColorProduct.Select(c => new Colors
                    {
                        Id = c.Colors.Id,
                        Colorvalue = c.Colors.Colorvalue,
                    }).ToList(),
                    RatinProducts = x.RatinProducts.Select(v => new RatinProduct
                    {
                        Id = v.Id,
                        ProductId = v.ProductId,
                        RatinId = v.RatinId,
                        Ratin = new Ratin
                        {
                            Id = v.Ratin.Id,
                            Rating = v.Ratin.Rating
                        }
                    }).ToList(),
                    NewPrice = x.NewPrice,
                    OldPrice = x.OldPrice,
                    Description = x.Description,
                    Images = x.Images.Where(x => x.IsDeleted == false && x.IsShowcase == true).Select(i => new Image
                    {
                        Id = i.Id,
                        Name = i.Name,
                        IsShowcase = i.IsShowcase
                    }).ToList(),
                    RatinMax = x.RatinProducts.Count() != 0 ? x.RatinProducts.Select(v => new RatinProduct
                    {
                        Id = v.Id,
                        ProductId = v.ProductId,
                        RatinId = v.RatinId,
                        Ratin = new Ratin
                        {
                            Id = v.Ratin.Id,
                            Rating = v.Ratin.Rating
                        }
                    }).Max(f => f.Ratin.Rating) : 0,
                    Flag = x.Flag,
                    CreateDate = x.CreateDate,
                }).ToList();
        }


        public List<Product> ProductJoinTake(Expression<Func<Product, bool>> predicate = null)
        {
            return context.Product.Where(predicate).
                Include(j => j.SubCategory).ThenInclude(g => g.Category).
                Include(j => j.ColorProduct).ThenInclude(g => g.Colors).
                Include(i => i.Images).
                Include(r => r.RatinProducts).ThenInclude(g => g.Ratin).Select(x => new Product
                {
                    Id = x.Id,
                    Name = x.Name,
                    IsDeleted = x.IsDeleted,
                    SubCategory = x.SubCategory,
                    Category = x.SubCategory.Category,
                    ColorProduct = x.ColorProduct,
                    Colors = x.ColorProduct.Select(c => new Colors
                    {
                        Id = c.Colors.Id,
                        Colorvalue = c.Colors.Colorvalue,
                    }).ToList(),
                    RatinProducts = x.RatinProducts.Select(v => new RatinProduct
                    {
                        Id = v.Id,
                        ProductId = v.ProductId,
                        RatinId = v.RatinId,
                        Ratin = new Ratin
                        {
                            Id = v.Ratin.Id,
                            Rating = v.Ratin.Rating
                        }
                    }).ToList(),
                    NewPrice = x.NewPrice,
                    OldPrice = x.OldPrice,
                    Description = x.Description,
                    Images = x.Images.Where(x => x.IsDeleted == false).Select(i => new Image
                    {
                        Id = i.Id,
                        Name = i.Name,
                        IsShowcase = i.IsShowcase
                    }).ToList(),
                    RatinMax = x.RatinProducts.Count() != 0 ? x.RatinProducts.Select(v => new RatinProduct
                    {
                        Id = v.Id,
                        ProductId = v.ProductId,
                        RatinId = v.RatinId,
                        Ratin = new Ratin
                        {
                            Id = v.Ratin.Id,
                            Rating = v.Ratin.Rating
                        }
                    }).Max(f => f.Ratin.Rating) : 0,
                    Flag = x.Flag,
                    CreateDate = x.CreateDate,
                }).OrderByDescending(f => f.CreateDate).Take(8).ToList();
        }


        public List<Product> ProductJoinCategory(Expression<Func<Product, bool>> predicate = null)
        {
            return context.Product.Where(predicate).
                Include(j => j.SubCategory).ThenInclude(g => g.Category).
                Include(r => r.RatinProducts).ThenInclude(g => g.Ratin).Select(x => new Product
                {
                    Id = x.Id,
                    Name = x.Name,
                    IsDeleted = x.IsDeleted,
                    SubCategory = x.SubCategory,
                    RatinProducts = x.RatinProducts.Select(v => new RatinProduct
                    {
                        Id = v.Id,
                        ProductId = v.ProductId,
                        RatinId = v.RatinId,
                        Ratin = new Ratin
                        {
                            Id = v.Ratin.Id,
                            Rating = v.Ratin.Rating
                        }
                    }).ToList(),
                    RatinMax = x.RatinProducts.Count() != 0 ? x.RatinProducts.Select(v => new RatinProduct
                    {
                        Id = v.Id,
                        ProductId = v.ProductId,
                        RatinId = v.RatinId,
                        Ratin = new Ratin
                        {
                            Id = v.Ratin.Id,
                            Rating = v.Ratin.Rating
                        }
                    }).Max(f => f.Ratin.Rating) : 0,
                }).ToList();
        }

        public List<Product> ProductJoinSubCategory(Expression<Func<Product, bool>> predicate = null)
        {
            return context.Product.Where(predicate).
                Include(j => j.SubCategory).ThenInclude(g => g.Category).
                Include(r => r.RatinProducts).ThenInclude(g => g.Ratin).Select(x => new Product
                {
                    Id = x.Id,
                    Name = x.Name,
                    IsDeleted = x.IsDeleted,
                    RatinProducts = x.RatinProducts.Select(v => new RatinProduct
                    {
                        Id = v.Id,
                        ProductId = v.ProductId,
                        RatinId = v.RatinId,
                        Ratin = new Ratin
                        {
                            Id = v.Ratin.Id,
                            Rating = v.Ratin.Rating
                        }
                    }).ToList(),
                    RatinMax = x.RatinProducts.Count() != 0 ? x.RatinProducts.Select(v => new RatinProduct
                    {
                        Id = v.Id,
                        ProductId = v.ProductId,
                        RatinId = v.RatinId,
                        Ratin = new Ratin
                        {
                            Id = v.Ratin.Id,
                            Rating = v.Ratin.Rating
                        }
                    }).Max(f => f.Ratin.Rating) : 0,
                }).ToList();
        }

        public SelectList ProductSelect(int[] ProductId = null)
        {
            return new SelectList(context.Product.Where(x => x.IsDeleted == false).OrderBy(x => x.Name), "Id", "Name", ProductId);
        }

        public Product? ProductByFlag(Expression<Func<Product, bool>> predicate = null)
        {
            return context.Product.
                Include(j => j.SubCategory).ThenInclude(g => g.Category).
                Include(j => j.ColorProduct).ThenInclude(g => g.Colors).
                Include(i => i.Images).
                Include(r => r.RatinProducts).ThenInclude(g => g.Ratin).Select(x => new Product
                {
                    Id = x.Id,
                    Name = x.Name,
                    IsDeleted = x.IsDeleted,
                    SubCategory = x.SubCategory,
                    Category = x.SubCategory.Category,
                    ColorProduct = x.ColorProduct,
                    Colors = x.ColorProduct.Select(c => new Colors
                    {
                        Id = c.Colors.Id,
                        Colorvalue = c.Colors.Colorvalue,
                    }).ToList(),
                    RatinProducts = x.RatinProducts.Select(v => new RatinProduct
                    {
                        Id = v.Id,
                        ProductId = v.ProductId,
                        RatinId = v.RatinId,
                        Ratin = new Ratin
                        {
                            Id = v.Ratin.Id,
                            Rating = v.Ratin.Rating
                        }
                    }).ToList(),
                    RatinCount = x.RatinProducts.Count(),
                    NewPrice = x.NewPrice,
                    OldPrice = x.OldPrice,
                    Description = x.Description,
                    Images = x.Images.Where(x => x.IsDeleted == false).Select(i => new Image
                    {
                        Id = i.Id,
                        Name = i.Name,
                        IsShowcase = i.IsShowcase
                    }).ToList(),
                    RatinMax = x.RatinProducts.Count() != 0 ? x.RatinProducts.Select(v => new RatinProduct
                    {
                        Id = v.Id,
                        ProductId = v.ProductId,
                        RatinId = v.RatinId,
                        Ratin = new Ratin
                        {
                            Id = v.Ratin.Id,
                            Rating = v.Ratin.Rating
                        }
                    }).Max(f => f.Ratin.Rating) : 0,
                    Flag = x.Flag,
                    CreateDate = x.CreateDate,
                }).FirstOrDefault(predicate)?? new Product();
        }

        public async Task<List<Product>> ProductJoinBasketAsync(Expression<Func<Product, bool>> predicate = null)
        {
            var pro = await context.Product.Where(predicate).
                Include(j => j.Baskets).
                Include(f => f.Images).Select(x => new Product
                {
                    Id = x.Id,
                    Name = x.Name,
                    IsDeleted = x.IsDeleted,
                    OldPrice = x.OldPrice,
                    NewPrice = x.NewPrice,
                    Images = x.Images.Where(i => i.IsDeleted == false && i.IsShowcase == true).Select(i => new Image
                    {
                        Id = i.Id,
                        Name = i.Name,
                        IsShowcase = i.IsShowcase
                    }).ToList()
                }).ToListAsync();
            return pro ?? new List<Product>();
        }
    }
}
