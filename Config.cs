using System.ComponentModel;
using Exiled.API.Interfaces;

namespace KillLogs
{
    public class Config : IConfig
    {
        [Description("Whether or not this plugin is enabled.")]
        public bool IsEnabled { get; set; } = true;
        
        [Description("The Discord webhook URL.")]
        public string DiscordWebhookUrl { get; set; } = "https://canary.discord.com/api/webhooks/id/secret";
        
        [Description("The Discord role ID to ping when a cuffed kill/teamkill happens.")]
        public string RoleIdToPing { get; set; } = "012345678910";

        [Description(
            "Length of the queue before it should be sent. Lower numbers result in faster sends to Discord but can lead to ratelimiting by Discord.")]
        public int QueueLength { get; set; } = 1000;

        [Description("Whether to log SCP kills or not.")]
        public bool LogScpKills { get; set; } = false;

        [Description("Whether or not to ping when a human kills another cuffed human.")]
        public bool PingCuffedHumanKills { get; set; } = true;

        [Description("Whether or not to ping when a teamkill happens.")]
        public bool PingTeamkills { get; set; } = true;

        public bool Debug { get; set; } = false;
        
    }
}