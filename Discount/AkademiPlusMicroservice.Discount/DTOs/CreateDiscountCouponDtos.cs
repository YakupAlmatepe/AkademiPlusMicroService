namespace AkademiPlusMicroservice.Discount.DTOs
{
    public class CreateDiscountCouponDtos
    {
        public string UserId { get; set; }
        public int Rate { get; set; }
        public string Code { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}