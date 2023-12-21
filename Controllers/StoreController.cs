using Microsoft.AspNetCore.Mvc;
using StoreManager.Api.DummyData;
using System.Text.Json;

namespace StoreManager.Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    [Produces("application/json")]
    public class StoreController : ControllerBase
    {
        [HttpGet]
        public List<DummyData.Store> GetStores()
        {
            DummyData.DummyData dummyData = new DummyData.DummyData();
            return dummyData.Stores();
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
