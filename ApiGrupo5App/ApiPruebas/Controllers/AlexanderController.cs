using ApiPruebas.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiPruebas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlexanderController : ControllerBase
    {
        private readonly IAlexanderService _alexanderServices;

        public AlexanderController(IAlexanderService alexanderServices)
        {
            _alexanderServices = alexanderServices;
        }

        [HttpGet("Saludo")]
        public string GetSaludoAlexander() 
        {
            try
            {
                var response = _alexanderServices.SaludoAlexander();
                return response;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error:",ex);
            }
        }
    }
}
