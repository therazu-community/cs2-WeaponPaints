using CounterStrikeSharp.API.Core;

namespace WeaponPaints
{
	public class Additional
	{
		public bool KnifeEnabled { get; set; } = true;
		public bool GloveEnabled { get; set; } = true;
		public bool MusicEnabled { get; set; } = true;
		public bool AgentEnabled { get; set; } = true;
		public bool SkinEnabled { get; set; } = true;
		public bool PinsEnabled { get; set; } = true;
		public bool CommandWpEnabled { get; set; } = true;
		public List<string> CommandKnife { get; set; } = ["knife"];
		public List<string> CommandMusic { get; set; } = ["music"];
		public List<string> CommandPin { get; set; } = ["pin", "pins", "coin", "coins"];
		public List<string> CommandGlove { get; set; } = ["gloves"];
		public List<string> CommandAgent { get; set; } = ["agents"];
		public List<string> CommandStattrak { get; set; } = ["stattrak", "st"];
		public List<string> CommandSkin { get; set; } = ["ws"];
		public List<string> CommandSkinSelection { get; set; } = ["skins"];
		public List<string> CommandRefresh { get; set; } = ["wp"];
		public bool ShowSkinImage { get; set; } = true;
	}

	public class WeaponPaintsConfig : BasePluginConfig
	{
		public override int Version { get; set; } = 10;
        public string MenuType { get; set; } = "CenterHtmlMenu";
        public string SkinsLanguage { get; set; } = "en";
		public string DatabaseHost { get; set; } = "";
		public int DatabasePort { get; set; } = 3306;
		public string DatabaseUser { get; set; } = "";
		public string DatabasePassword { get; set; } = "";
		public string DatabaseName { get; set; } = "";
		public int CmdRefreshCooldownSeconds { get; set; } = 3;
		public string Website { get; set; } = "example.com/skins";
		public Additional Additional { get; set; } = new();
	}
}