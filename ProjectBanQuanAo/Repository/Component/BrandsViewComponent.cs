using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ProjectBanQuanAo.Repository.Component
{
    public class BrandsViewComponent : ViewComponent

    {
        private readonly DataContext _datacontext;
        public BrandsViewComponent(DataContext context)
        {
            _datacontext = context;
        }
        public async Task<IViewComponentResult> InvokeAsync() => View(await _datacontext.Brands.ToListAsync());
    }
}
