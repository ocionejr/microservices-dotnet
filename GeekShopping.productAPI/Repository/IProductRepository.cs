using GeekShopping.productAPI.Data.ValueObjects;

namespace GeekShopping.productAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductVO>> FindAll();

        Task<ProductVO> FindById(int id);

        Task<ProductVO> Create(ProductVO vo);

        Task<ProductVO> Update(ProductVO vo);

        Task<bool> Delete(int id);
    }
}
