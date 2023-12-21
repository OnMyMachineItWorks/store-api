namespace StoreManager.Api.DummyData
{
    public class DummyData
    {
        public List<Store> Stores() {
            List<Store> stores = new() {
                new Store{ Id=1, StoreName="Test Store", StoreManagerId="1", IsDeleted=false},
                new Store{ Id=2, StoreName="Second Store", StoreManagerId="2", IsDeleted=false}
            };
            return stores;
        }
    }

    public class Store
    {
        public int Id { get; set; }
        public string? StoreName { get; set; }
        public string? StoreManagerId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
