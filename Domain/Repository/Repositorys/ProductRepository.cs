using eticaret.Domain.Core.Entities;
using eticaret.Domain.Database.Context;
using eticaret.Domain.Repository.Interface;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace eticaret.Domain.Repository.Repositorys
{
    public class ProductRepository : Repository<Product> , IProductRepository
    {
        public ProductRepository(CommerceContext context) : base(context)
        {
        }

        public List<Product> ProductJoin(Expression<Func<Product, bool>> predicate = null)
        {
            return context.Product.Where(predicate).
                Include(j => j.CategoryProducts).ThenInclude(g => g.Category).
                Include(s => s.SubCategory).
                Include(r => r.RatinProducts).ThenInclude(g => g.Ratin).Select(x => new Product
                {
                    Id = x.Id,
                    Name = x.Name,
                    IsDeleted = x.IsDeleted,
                    CategoryProducts = x.CategoryProducts,
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

        public List<Product> ProductJoinCategory(Expression<Func<Product, bool>> predicate = null)
        {
            return context.Product.Where(predicate).
                Include(j => j.CategoryProducts).ThenInclude(g => g.Category).
                Include(r => r.RatinProducts).ThenInclude(g => g.Ratin).Select(x => new Product
                {
                    Id = x.Id,
                    Name = x.Name,
                    IsDeleted = x.IsDeleted,
                    CategoryProducts = x.CategoryProducts,
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
                                        }).Max(f => f.Ratin.Rating):0,
                }).ToList();
        }

        public List<Product> ProductJoinSubCategory(Expression<Func<Product, bool>> predicate = null)
        {
            return context.Product.Where(predicate).
                Include(j => j.CategoryProducts).ThenInclude(g => g.Category).
                Include(r => r.RatinProducts).ThenInclude(g => g.Ratin).Select(x => new Product
                {
                    Id = x.Id,
                    Name = x.Name,
                    IsDeleted = x.IsDeleted,
                    CategoryProducts = x.CategoryProducts,
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
    }
}
