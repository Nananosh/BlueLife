using AutoMapper;
using BlueLife.ViewModels.Mappings;

namespace BlueLife.App_Start
{
    public class AutoMapperConfig
    {
        public static void RegisterMappers()
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile<UserMappingProfile>();
            });

            mapperConfig.AssertConfigurationIsValid();
        }
    }
}
