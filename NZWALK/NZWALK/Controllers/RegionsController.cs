using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NZWALK.Models.Domain;
using NZWALK.Repositories;

namespace NZWALK.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository regionsRepository;
        private readonly IMapper mapper;

        public RegionsController(IRegionRepository regionsRepository, IMapper mapper)
        {
            this.regionsRepository = regionsRepository;
            this.mapper = mapper;
            
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRegions()
        {
            var regions = await regionsRepository.GetAllAsync();

            //return DTO regions
            //var regionsDTO = new List<Models.DTO.Region>();
            //regions.ToList().ForEach(region =>
            //{
            //    var regionDTO = new Models.DTO.Region()
            //    {
            //        Id = region.Id,
            //        Name = region.Name,
            //        Code = region.Code,
            //        Area = region.Area,
            //        Lat = region.Lat,
            //        Long = region.Long,
            //        Population = region.Population,
            //    };

            var regionsDTO = mapper.Map<List<Models.DTO.Region>>(regions);

               
            

            return Ok(regionsDTO);
        }
    }
}
