using BaseLib.Abstracts;
using Godot;

namespace The_Werewolf.Character;

public class WereWolfCardPool : CustomCardPoolModel
{
    public override string Title => WereWolf.CharacterId;

    public override Color DeckEntryCardColor =>
        new("ffffff");

    public override bool IsColorless => false;
}