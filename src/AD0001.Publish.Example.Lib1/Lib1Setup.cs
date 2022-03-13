﻿using AD0001.Publish.Example.Lib1.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AD0001.Publish.Example.Lib1;

public static class Lib1Setup
{
    public static IServiceCollection AddLib1(this IServiceCollection services)
    {
        return ChannelFollowCount.RegisterHttpClient(services.AddSingleton<IChannelFollowCount, ChannelFollowCount>());
    }
}