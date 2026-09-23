using BaseLib.Abstracts;
using BaseLib.Utils.NodeFactories;
using Godot;
using MegaCrit.Sts2.Core.Entities.Characters;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.Cards;
using MegaCrit.Sts2.Core.Models.Relics;

namespace The_Werewolf.Character;

public class WereWolf : PlaceholderCharacterModel
{
    public const string CharacterId = "WereWolf";

    public static readonly Color Color = new("ffffff");

    public override Color NameColor => Color;

    public override CharacterGender Gender => CharacterGender.Neutral;

    public override int StartingHp => 70;

    public override IEnumerable<CardModel> StartingDeck =>
    [
        ModelDb.Card<StrikeIronclad>(),
        ModelDb.Card<StrikeIronclad>(),
        ModelDb.Card<StrikeIronclad>(),
        ModelDb.Card<StrikeIronclad>(),
        ModelDb.Card<StrikeIronclad>(),

        ModelDb.Card<DefendIronclad>(),
        ModelDb.Card<DefendIronclad>(),
        ModelDb.Card<DefendIronclad>(),
        ModelDb.Card<DefendIronclad>(),
        ModelDb.Card<DefendIronclad>()
    ];

    public override IReadOnlyList<RelicModel> StartingRelics =>
    [
        ModelDb.Relic<BurningBlood>()
    ];

    public override CardPoolModel CardPool =>
        ModelDb.CardPool<WereWolfCardPool>();

    public override RelicPoolModel RelicPool =>
        ModelDb.RelicPool<WereWolfRelicPool>();

    public override PotionPoolModel PotionPool =>
        ModelDb.PotionPool<WereWolfPotionPool>();

    public override Control CustomIcon
    {
        get
        {
            var icon = NodeFactory<Control>.CreateFromResource(
                CustomIconTexturePath
            );

            icon.SetAnchorsAndOffsetsPreset(
                Control.LayoutPreset.FullRect
            );

            return icon;
        }
    }

    public override string CustomIconTexturePath =>
        "character_icon_werewolf.png";

    public override string CustomCharacterSelectIconPath =>
        "char_select_werewolf.png";

    public override string CustomCharacterSelectLockedIconPath =>
        "char_select_werewolf_locked.png";

    public override string CustomMapMarkerPath =>
        "map_marker_werewolf.png";
}