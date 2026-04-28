using SPTarkov.Server.Core.Models.Spt.Mod;

namespace DWVCoreSlotPicture
{
    public record ModMetadata : AbstractModMetadata
    {
        public override string ModGuid { get; init; } = "com.szonszczyk.dwvcoreslotpicture";
        public override string Name { get; init; } = "DWVCoreSlotPicture";
        public override string Author { get; init; } = "Szonszczyk";
        public override List<string>? Contributors { get; init; }
        public override SemanticVersioning.Version Version { get; init; } = new("1.0.0");
        public override SemanticVersioning.Range SptVersion { get; init; } = new("~4.0.4");
        public override List<string>? Incompatibilities { get; init; } = [];
        public override Dictionary<string, SemanticVersioning.Range>? ModDependencies { get; init; } = new()
        {
            { "com.wtt.commonlib", new SemanticVersioning.Range("~2.0.0") },
            { "com.szonszczyk.definitiveweaponvariants", new SemanticVersioning.Range(">4.1.0") }
        };
        public override string? Url { get; init; } = "https://github.com/Szonszczyk/DWVCoreSlotPicture";
        public override bool? IsBundleMod { get; init; } = false;
        public override string? License { get; init; } = "MIT";
    }
}