using AutoMapper;
using Tailor.DTO.DTOs.BlogDtos;
using Tailor.DTO.DTOs.CategoryDtos;
using Tailor.DTO.DTOs.AddressDtos;
using Tailor.DTO.DTOs.BannerDtos;
using Tailor.DTO.DTOs.BlogCategoryDtos;
using Tailor.DTO.DTOs.BlogDtos;
using Tailor.DTO.DTOs.ContactMessageDtos;
using Tailor.DTO.DTOs.OrderDtos;
using Tailor.DTO.DTOs.OrderItemDtos;
using Tailor.DTO.DTOs.ProductDtos;
using Tailor.DTO.DTOs.ProductPropertyDtos;
using Tailor.DTO.DTOs.ShoppingCartItem;
using Tailor.DTO.DTOs.SupportTicketDtos;
using Tailor.Entity.Entities;
using Tailor.DTO.DTOs.CustomerSocialDtos;

namespace Tailor.Business.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            // --- PRODUCT ---
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, ResultProductListDto>().ReverseMap();

            // Varyant ve Özellikler
            CreateMap<ProductVariant, CreateProductVariantDto>().ReverseMap();
            CreateMap<ProductVariant, ResultProductVariantDto>().ReverseMap();
            CreateMap<ProductProperty, CreateProductPropertyDto>().ReverseMap();
            CreateMap<ProductProperty, ResultProductPropertyDto>().ReverseMap();

            // --- CATEGORY ---
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, ResultCategoryDto>().ReverseMap();

            // --- BLOG ---
            CreateMap<Blog, CreateBlogDto>().ReverseMap();
            CreateMap<Blog, UpdateBlogDto>().ReverseMap();
            CreateMap<Blog, ResultBlogDto>().ReverseMap();
            CreateMap<Blog, ResultBlogListDto>().ReverseMap();
            CreateMap<BlogCategory, ResultBlogCategoryDto>().ReverseMap();

            // --- ORDER & CART ---
            CreateMap<Order, CreateOrderDto>().ReverseMap();
            CreateMap<Order, ResultOrderDto>().ReverseMap();
            CreateMap<Order, ResultOrderListDto>().ReverseMap();

            CreateMap<OrderItem, ResultOrderItemDto>().ReverseMap();

            CreateMap<ShoppingCartItem, AddCartItemDto>().ReverseMap();
            CreateMap<ShoppingCartItem, ResultCartItemDto>().ReverseMap();

            // --- SUPPORT & CONTACT ---
            CreateMap<ContactMessage, CreateContactMessageDto>().ReverseMap();
            CreateMap<ContactMessage, ResultContactMessageDto>().ReverseMap();

            CreateMap<SupportTicket, CreateSupportTicketDto>().ReverseMap();
            CreateMap<SupportTicket, ResultSupportTicketDto>().ReverseMap();

            // --- BANNER ---
            CreateMap<Banner, CreateBannerDto>().ReverseMap();
            CreateMap<Banner, UpdateBannerDto>().ReverseMap();
            CreateMap<Banner, ResultBannerDto>().ReverseMap();

            // --- USER & ADDRESS ---
            CreateMap<Address, CreateAddressDto>().ReverseMap();
            CreateMap<Address, UpdateAddressDto>().ReverseMap();
            CreateMap<Address, ResultAddressDto>().ReverseMap();

            CreateMap<CustomerSocial, ResultCustomerSocialDto>().ReverseMap();
            CreateMap<CustomerSocial, CreateCustomerSocialDto>().ReverseMap();
            CreateMap<CustomerSocial, UpdateCustomerSocialDto>().ReverseMap();
        }
    }
}