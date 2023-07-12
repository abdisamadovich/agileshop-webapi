
using AgileShop.Domain.Enums;

namespace AgileShop.Domain.Entities.Orders;

public class Order:Auditable
{
    public long UserId { get; set; }

    public long DeliveryId { get; set; }

    public OrderStatus Status { get; set; }

    //The summ of order details result price
    //The monay which that user must pay for products
    public double ProductPrice { get; set; }

    public double DeliveryPrice { get; set; }

    //The payment that user must pay for sale 
    //Product Price + Delivery Price
    public double ResultPrice { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public PaymentType Payment { get; set; }

    public bool IsPaid { get; set; }

    public bool IsContracted { get; set; }

    public string Description { get; set; } = string.Empty;


}
