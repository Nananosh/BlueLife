using System.Threading.Tasks;

namespace BlueLife.Business.Interfaces
{
    public interface ISeedDatabaseService
    {
        public void CreateStartOrderStatus();
        public Task CreateStartRole();
    }
}