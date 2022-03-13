using System;
using System.Threading.Tasks;

namespace AD0001.Publish.Example.Lib1.Data.Interfaces;

public interface ITwitchStreamerDataManager
{
    Task AddStreamerAsync(string streamerName, string streamerId, DateTime startedStreaming);

    Task<TwitchUser?> GetByUserNameAsync(string userName);
}