using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MüsteriFinder.Business.Abstract;
using MüsteriFinder.Business.Concrete;
using MüsteriFİnder_Entitis;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MüsteriController : ControllerBase
    {
        private IMüsteriService _müsteriService;

        public MüsteriController()
        {
            _müsteriService = new MüsteriManager();

        }
        [HttpGet]
        public List<Müsteri> Get()
        {

            return _müsteriService.GetAllMüsteris();
        }
        [HttpGet("{id}")]
        public Müsteri Get(int id)
        {

            return _müsteriService.GetMüsteriById(id);
        }

        [HttpPost]

        public Müsteri post([FromBody] Müsteri müsteri)
        {

            return _müsteriService.CreateMüsteri(müsteri);

        }

        [HttpPut]

        public Müsteri put([FromBody] Müsteri müsteri)
        {

            return _müsteriService.UpdateMüsteri(müsteri);

        }
        [HttpDelete("{id}")]

        public void Delete(int id)
        {
            _müsteriService.DeleteMüsteri(id);
        }
    }
}
