using Microsoft.AspNetCore.Mvc;

namespace StoreManager.Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class StoreController : ControllerBase
    {
        [HttpGet]
        public string GetStores()
        {
            return "get all Test Store";
        }

        [HttpGet("{id}")]
        public string GetStoreById(int id)
        {
            return $"Test Store {id}";
        }

        [HttpPost]
        public string CreateStore()
        {
            return "new test store";
        }

        [HttpPut("{id}")]
        public string UpdateStore(int id)
        {
            return $"update Store {id}";
        }

        [HttpDelete("{id}")]
        public string DeleteStore(int id)
        {
            return $"Delete Store {id}";
        }
    }
}
