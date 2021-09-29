using System.Threading.Tasks;

namespace CHZU.OnlineJudge.Data
{
    public interface IOnlineJudgeDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
