using System.Threading.Tasks;

namespace BlueLife.Business.Interfaces
{
    public interface ISeedDatabaseService
    {
        public void CreateStartOrderStatus();
        public Task CreateStartRole();
        public Task CreateStartAdmin();
        public Task CreateStartAddress();
    }
}