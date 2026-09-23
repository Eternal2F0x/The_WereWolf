using System.Reflection;
using Godot;
using HarmonyLib;
using MegaCrit.Sts2.Core.Modding;
using StsLogger = MegaCrit.Sts2.Core.Logging.Logger;
using StsLogType = MegaCrit.Sts2.Core.Logging.LogType;

namespace The_Werewolf;

[ModInitializer(nameof(Initialize))]
public partial class MainFile : Node
{
    public const string ModId = "The_Werewolf";
    public const string ResPath = $"res://{ModId}";

    public static StsLogger Logger { get; } =
        new(ModId, StsLogType.Generic);

    public static void Initialize()
    {
        var assembly = Assembly.GetExecutingAssembly();

        Harmony harmony = new(ModId);
        harmony.PatchAll(assembly);
    }
}