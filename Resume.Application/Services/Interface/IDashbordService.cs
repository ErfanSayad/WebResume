
using Resume.Application.DTOs.SiteSide.Home_index;

namespace Resume.Application.Services.Interface;

public interface IDashbordService
{
    Task<HomeIndexModel> FillDashbordModel();
}
