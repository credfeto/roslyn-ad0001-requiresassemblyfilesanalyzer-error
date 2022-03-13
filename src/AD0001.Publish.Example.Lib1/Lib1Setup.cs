using Credfeto.Notification.Bot.Twitch;
using Credfeto.Notification.Bot.Twitch.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AD0001.Publish.Example.Lib1;

public static class Lib1Setup
{
    public static IServiceCollection AddTwitch(this IServiceCollection services)
    {
        return ChannelFollowCount.RegisterHttpClient(services.AddSingleton<IChannelFollowCount, ChannelFollowCount>());
    }
}