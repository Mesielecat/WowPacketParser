﻿using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [DBTableName("playerchoice")]
    public sealed class PlayerChoiceTemplate : IDataModel
    {
        [DBFieldName("ChoiceId", true)]
        public int? ChoiceId;

        [DBFieldName("UiTextureKitId")]
        public int? UiTextureKitId;

        [DBFieldName("Question")]
        public string Question;

        [DBFieldName("HideWarboardHeader")]
        public int HideWarboardHeader;

        [DBFieldName("KeepOpenAfterChoice")]
        public int KeepOpenAfterChoice;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }

    [DBTableName("playerchoice_locale")]
    public sealed class PlayerChoiceLocaleTemplate : IDataModel
    {
        [DBFieldName("ChoiceId", true)]
        public int? ChoiceId;

        [DBFieldName("Locale")]
        public string Locale;

        [DBFieldName("Question")]
        public string Question;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }

    [DBTableName("playerchoice_response")]
    public sealed class PlayerChoiceResponseTemplate : IDataModel
    {
        [DBFieldName("ChoiceId", true)]
        public int? ChoiceId;

        [DBFieldName("ResponseId", true)]
        public int? ResponseId;

        [DBFieldName("Index")]
        public uint? Index;

        [DBFieldName("ChoiceArtFileId")]
        public int? ChoiceArtFileId;

        [DBFieldName("Flags")]
        public int? Flags;

        [DBFieldName("WidgetSetId")]
        public uint? WidgetSetId;

        [DBFieldName("GroupId")]
        public int? GroupId;

        [DBFieldName("Header")]
        public string Header;

        [DBFieldName("Answer")]
        public string Answer;

        [DBFieldName("Description")]
        public string Description;

        [DBFieldName("Confirmation")]
        public string Confirmation;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }

    [DBTableName("playerchoice_response_locale")]
    public sealed class PlayerChoiceResponseLocaleTemplate : IDataModel
    {
        [DBFieldName("ChoiceId", true)]
        public int? ChoiceId;

        [DBFieldName("ResponseId", true)]
        public int? ResponseId;

        [DBFieldName("Locale")]
        public string Locale;

        [DBFieldName("Header")]
        public string Header;

        [DBFieldName("Answer")]
        public string Answer;

        [DBFieldName("Description")]
        public string Description;

        [DBFieldName("Confirmation")]
        public string Confirmation;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }

    [DBTableName("playerchoice_response_reward")]
    public sealed class PlayerChoiceResponseRewardTemplate : IDataModel
    {
        [DBFieldName("ChoiceId", true)]
        public int? ChoiceId;

        [DBFieldName("ResponseId", true)]
        public int? ResponseId;

        [DBFieldName("TitleId")]
        public int? TitleId;

        [DBFieldName("PackageId")]
        public int? PackageId;

        [DBFieldName("SkillLineId")]
        public int? SkillLineId;

        [DBFieldName("SkillPointCount")]
        public uint? SkillPointCount;

        [DBFieldName("ArenaPointCount")]
        public uint? ArenaPointCount;

        [DBFieldName("HonorPointCount")]
        public uint? HonorPointCount;

        [DBFieldName("Money")]
        public ulong? Money;

        [DBFieldName("Xp")]
        public uint? Xp;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }

    [DBTableName("playerchoice_response_reward_currency")]
    public sealed class PlayerChoiceResponseRewardCurrencyTemplate : IDataModel
    {
        [DBFieldName("ChoiceId", true)]
        public int? ChoiceId;

        [DBFieldName("ResponseId", true)]
        public int? ResponseId;

        [DBFieldName("Index")]
        public uint? Index;

        [DBFieldName("CurrencyId")]
        public int? CurrencyId;

        [DBFieldName("Quantity")]
        public int? Quantity;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }

    [DBTableName("playerchoice_response_reward_faction")]
    public sealed class PlayerChoiceResponseRewardFactionTemplate : IDataModel
    {
        [DBFieldName("ChoiceId", true)]
        public uint? ChoiceId;

        [DBFieldName("ResponseId", true)]
        public uint? ResponseId;

        [DBFieldName("Index")]
        public uint? Index;

        [DBFieldName("FactionId")]
        public uint? FactionId;

        [DBFieldName("Quantity")]
        public uint? Quantity;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }

    [DBTableName("playerchoice_response_reward_item")]
    public sealed class PlayerChoiceResponseRewardItemTemplate : IDataModel
    {
        [DBFieldName("ChoiceId", true)]
        public int? ChoiceId;

        [DBFieldName("ResponseId", true)]
        public int? ResponseId;

        [DBFieldName("Index")]
        public uint? Index;

        [DBFieldName("ItemId")]
        public int? ItemId;

        [DBFieldName("BonusListIDs")]
        public string BonusListIDs;

        [DBFieldName("Quantity")]
        public int? Quantity;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }
}
