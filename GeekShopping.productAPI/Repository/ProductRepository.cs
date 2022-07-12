using AutoMapper;
using GeekShopping.productAPI.Data.ValueObjects;
using GeekShopping.productAPI.Model;
using GeekShopping.productAPI.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.productAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly MySQLContext _context;
        private IMapper _mapper;

        public ProductRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<ProductVO> Create(ProductVO vo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductVO>> FindAll()
        {
            List<Product> products = await _context.Products.ToListAsync();
            return _mapper.Map<List<ProductVO>>(products);
        }

        public async Task<ProductVO> FindById(int id)
        {
            Product product = await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync()
            return _mapper.Map<ProductVO>(product);
        }

        public Task<ProductVO> Update(ProductVO vo)
        {
            throw new NotImplementedException();
        }
    }
}
