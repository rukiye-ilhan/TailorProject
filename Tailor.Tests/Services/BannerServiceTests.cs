using AutoMapper;
using Microsoft.AspNetCore.Http;
using Moq;
using Tailor.Business.Concrete;
using Tailor.DataAccess.Abstract;
using Tailor.DTO.DTOs.BannerDtos;
using Tailor.Entity.Entities;
using Xunit;

namespace Tailor.Tests.Services
{
    public class BannerServiceTests
    {
        private readonly Mock<IBannerDal> _mockBannerDal;
        private readonly Mock<IMapper> _mockMapper;
        private readonly BannerManager _bannerService;

        public BannerServiceTests()
        {
            _mockBannerDal = new Mock<IBannerDal>();
            _mockMapper = new Mock<IMapper>();
            _bannerService = new BannerManager(_mockBannerDal.Object, _mockMapper.Object);
        }

        [Fact]
        public void GetAllBanners_OnlyActive_ReturnsActiveOnly()
        {
            // Arrange
            var activeBanners = new List<Banner>
            {
                new Banner { BannerId = 1, Title = "Active Banner", IsActive = true },
                new Banner { BannerId = 2, Title = "Active Banner 2", IsActive = true }
            };

            var expectedDtos = new List<ResultBannerDto>
            {
                new ResultBannerDto { BannerId = 1, Title = "Active Banner", IsActive = true },
                new ResultBannerDto { BannerId = 2, Title = "Active Banner 2", IsActive = true }
            };

            _mockBannerDal.Setup(x => x.GetListByFilter(It.IsAny<System.Linq.Expressions.Expression<Func<Banner, bool>>>()))
                .Returns(activeBanners);
            _mockMapper.Setup(x => x.Map<List<ResultBannerDto>>(activeBanners))
                .Returns(expectedDtos);

            // Act
            var result = _bannerService.GetAllBanners(onlyActive: true);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.All(result, banner => Assert.True(banner.IsActive));
        }

        [Fact]
        public void GetBannerById_ValidId_ReturnsBanner()
        {
            // Arrange
            var banner = new Banner
            {
                BannerId = 1,
                Title = "Test Banner",
                Description = "Test Description",
                ImagePath = "/uploads/banners/test.jpg",
                IsActive = true
            };

            var expectedDto = new ResultBannerDto
            {
                BannerId = 1,
                Title = "Test Banner",
                Description = "Test Description",
                ImagePath = "/uploads/banners/test.jpg",
                IsActive = true
            };

            _mockBannerDal.Setup(x => x.GetById(1)).Returns(banner);
            _mockMapper.Setup(x => x.Map<ResultBannerDto>(banner)).Returns(expectedDto);

            // Act
            var result = _bannerService.GetBannerById(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Test Banner", result.Title);
            Assert.Equal(1, result.BannerId);
        }

        [Fact]
        public void GetBannerById_InvalidId_ReturnsNull()
        {
            // Arrange
            _mockBannerDal.Setup(x => x.GetById(999)).Returns((Banner)null);

            // Act
            var result = _bannerService.GetBannerById(999);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void CreateBanner_NullImageFile_ThrowsArgumentException()
        {
            // Arrange
            var createDto = new CreateBannerDto
            {
                Title = "New Banner",
                Description = "Description",
                IsActive = true
            };

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _bannerService.CreateBanner(createDto, null));
        }

        [Fact]
        public void DeleteBanner_ValidId_CallsDeleteOnce()
        {
            // Arrange
            var banner = new Banner
            {
                BannerId = 1,
                Title = "Banner to Delete",
                ImagePath = "/uploads/banners/test.jpg"
            };

            _mockBannerDal.Setup(x => x.GetById(1)).Returns(banner);
            _mockBannerDal.Setup(x => x.Delete(It.IsAny<Banner>())).Verifiable();

            // Act
            _bannerService.DeleteBanner(1);

            // Assert
            _mockBannerDal.Verify(x => x.Delete(It.IsAny<Banner>()), Times.Once);
        }

        [Fact]
        public void DeleteBanner_InvalidId_ThrowsKeyNotFoundException()
        {
            // Arrange
            _mockBannerDal.Setup(x => x.GetById(999)).Returns((Banner)null);

            // Act & Assert
            Assert.Throws<KeyNotFoundException>(() => _bannerService.DeleteBanner(999));
        }

        [Fact]
        public void GetAllBanners_WithoutFilter_ReturnsAllBanners()
        {
            // Arrange
            var allBanners = new List<Banner>
            {
                new Banner { BannerId = 1, Title = "Active Banner", IsActive = true },
                new Banner { BannerId = 2, Title = "Inactive Banner", IsActive = false }
            };

            var expectedDtos = new List<ResultBannerDto>
            {
                new ResultBannerDto { BannerId = 1, Title = "Active Banner", IsActive = true },
                new ResultBannerDto { BannerId = 2, Title = "Inactive Banner", IsActive = false }
            };

            _mockBannerDal.Setup(x => x.GetAll()).Returns(allBanners);
            _mockMapper.Setup(x => x.Map<List<ResultBannerDto>>(allBanners)).Returns(expectedDtos);

            // Act
            var result = _bannerService.GetAllBanners(onlyActive: false);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
        }
    }
}
