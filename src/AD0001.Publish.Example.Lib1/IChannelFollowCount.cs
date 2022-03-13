using System.Threading;
using System.Threading.Tasks;

namespace AD0001.Publish.Example.Lib1;

public interface IChannelFollowCount
{
    Task<int> GetCurrentFollowerCountAsync(string username, CancellationToken cancellationToken);
}