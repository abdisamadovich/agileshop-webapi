using AgileShop.DataAccess.Common.Interfaces;
using AgileShop.DataAccess.Utils;
using AgileShop.Domain.Entities.Discounts;

namespace AgileShop.DataAccess.Interfaces;

public interface IDiscountRepository : IRepository<Discount, Discount>,
    IGetAll<Discount>
{
    public Task<IList<Discount>> GetAllByDurationAsync(DateTime startAt,DateTime endAt,PaginationParams @params);
    

}
