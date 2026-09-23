using BaseLib.Abstracts;
using Godot;

namespace The_Werewolf.Character;

public class WereWolfRelicPool : CustomRelicPoolModel
{
    public override Color LabOutlineColor =>
        WereWolf.Color;
}