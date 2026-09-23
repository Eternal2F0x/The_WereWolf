using BaseLib.Abstracts;
using Godot;

namespace The_Werewolf.Character;

public class WereWolfPotionPool : CustomPotionPoolModel
{
    public override Color LabOutlineColor =>
        WereWolf.Color;
}