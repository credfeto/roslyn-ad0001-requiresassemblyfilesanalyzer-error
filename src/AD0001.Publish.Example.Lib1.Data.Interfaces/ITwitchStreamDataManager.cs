using System;
using System.Threading.Tasks;

namespace AD0001.Publish.Example.Lib1.Data.Interfaces;

public interface ITwitchStreamDataManager
{
    Task RecordStreamStartAsync(string channel, DateTime streamStartDate);

    Task AddChatterToStreamAsync(string channel, DateTime streamStartDate, string username);

    Task<bool> IsFirstMessageInStreamAsync(string channel, DateTime streamStartDate, string username);

    Task<bool> IsRegularChatterAsync(string channel, string username);

    Task<bool> UpdateFollowerMilestoneAsync(string channel, int followerCount);
}