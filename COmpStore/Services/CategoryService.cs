using AutoMapper;
using COmpStore.Dto;
using COmpStore.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COmpStore.Services
{
    public interface ICategoryService
    {
        IEnumerable<CategoryDto> GetAll();
    }

    public class CategoryService : ICategoryService
    {
        private StoreDbContext DbContext;
        private IMapper Mapper;

        public CategoryService(StoreDbContext dbContext, IMapper mapper)
        {
            DbContext = dbContext;
            Mapper = mapper;
        }

        public IEnumerable<CategoryDto> GetAll()
        {
            return Mapper.Map<IEnumerable<CategoryDto>>(DbContext.Categories);
        }
    }
}
