﻿namespace ComputerHardwareECommerceApi.Application.Dtos.OrderDtos
{
    public class OrderUpdateDto:BaseDto
    {
        public Guid Id { get; set; }
        public string OrderStatus { get; set; }
        public int AddressId { get; set; }
    }
}
