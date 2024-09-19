using DSharpPlus;
using System;
using System.Threading.Tasks;

namespace MyFirstBot
{
    class Program{
        static async Task Main(string[] args)
        {
            DiscordClientBuilder builder = DiscordClientBuilder.CreateDefault("My First Token", DiscordIntents.AllUnprivileged | DiscordIntents.MessageContents);

            builder.ConfigureeventHandlers
            {
                b => b.HandleMessageCreated(async (s, e) =>
                {
                    if (e.Message.Content.ToLower().StartsWith("ping"))
                    {
                        await e.Message.RespondAsynch("pong!");
                    }
                }
            });

            // Connect the bot (optional step, but usually part of the workflow)
            DiscordClient client = builder.Build();
            await Task.Delay(-1);
            // Prevents the bot from exiting immediately
            await Task.Delay(-1);
        }
    }
}

