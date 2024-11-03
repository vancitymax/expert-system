using ExpertSystem;
using ExpertSystemConsole;
using System.Collections;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ExpertSystem
{
    internal static class Results
    {
        public static List<Result> results = new List<Result>
        {
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.role, (new int[]{3}, 99999999) },
            //}, "test"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.canBuy, (true, 0) },
                { QuestionId.enemyOnVision, (true, 1) },
                { QuestionId.enemyPos, (true, 1) },
                { QuestionId.canDeffend, (true, 2) },
            }, "Вашій команді слід зібратися на захист"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.canBuy, (true, 0) },
                { QuestionId.enemyOnVision, (true, 1) },
                { QuestionId.enemyPos, (true, 1) },
                { QuestionId.canDeffend, (false, 2) },
            }, "Вам слід піти сплітпушити або кріпскіпати"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.canBuy, (true, 0) },
                { QuestionId.enemyOnVision, (true, 1) },
                { QuestionId.enemyPos, (false, 1) },
                { QuestionId.canFight, (false, 1) },
                { QuestionId.canDoObjective, (false, 2) },
            }, "Вам слід розійтися по карті й фармити"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.canBuy, (true, 0) },
                { QuestionId.enemyOnVision, (true, 1) },
                { QuestionId.enemyPos, (false, 1) },
                { QuestionId.canFight, (false, 1) },
                { QuestionId.canDoObjective, (true, 2) },
            }, "Вам слід забрати рошана/терментора"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.canBuy, (true, 0) },
                { QuestionId.enemyOnVision, (true, 1) },
                { QuestionId.enemyPos, (false, 1) },
                { QuestionId.canFight, (true, 2) },
            }, "Вам слід використати смок й атакувати ворожих героїв/вежі"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.canBuy, (true, 0) },
                { QuestionId.enemyOnVision, (false, 1) },
                { QuestionId.role, (new int[]{4,5}, 1) },
                { QuestionId.carrySave, (false, 2) },
            }, "Вам слід перетягнутися до кері й поставити варди"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.canBuy, (true, 0) },
                { QuestionId.enemyOnVision, (false, 1) },
                { QuestionId.role, (new int[]{4,5}, 1) },
                { QuestionId.carrySave, (true, 2) },
            }, "Вам слід зробити стаки та по можливості сплітпушити лінії"),

            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.heroRole, (IngameType.Killer, 1) },
                { QuestionId.missing, (MissingStaff.Mana, 1) },
                { QuestionId.stage, (GameState.Start, 2) },
                { QuestionId.canBuy, (false, 0) },
                { QuestionId.role, (new int[]{2}, 2) },
            }, "Bottle"),

            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.enemyInvis, (false, 3) },
                { QuestionId.supportType, (SupportStuff.Catch, 1) },
                { QuestionId.canCatch, (false, 1) },
                { QuestionId.stage, (GameState.Endgame, 2) },
                { QuestionId.canBuy, (false, 0) },
                { QuestionId.role, (new int[]{4,5}, 2) },
            }, "Gem of true sight"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.dmg, (new int[]{1, -1, -1 }, 4) },
                { QuestionId.missing, (MissingStaff.Survive, 2) },
                { QuestionId.canBuy, (false, 0) },
                { QuestionId.role, (new int[]{1,2,3,4,5}, 2) },
            }, "Ghost scepeter"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.canCatch, (false, 3) },
                { QuestionId.canBuy, (false, 0) },
                { QuestionId.role, (new int[]{1,2,3}, 2) },
            }, "Blink dagger"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.spammers, (false, 0) },
                { QuestionId.missing, (MissingStaff.Survive, 3) },
                { QuestionId.stage, (GameState.Start, 10) },
                { QuestionId.canBuy, (false, 0) },
            }, "Magic Stick"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.mainAttribute, (Atribute.Intelegance, 2) },
                { QuestionId.heroRole, (IngameType.Mage, 2) },
                { QuestionId.missing, (MissingStaff.Mana, 3) },
                { QuestionId.stage, (GameState.Start, 3) },
                { QuestionId.canBuy, (false, 0) },
            }, "Null Talisman"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.mainAttribute, (Atribute.Agility, 2) },
                { QuestionId.missing, (MissingStaff.Survive, 2) },
                { QuestionId.stage, (GameState.Start, 3) },
                { QuestionId.canBuy, (false, 0) },
            }, "Wtaith Band"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.mainAttribute, (Atribute.Strength, 2) },
                { QuestionId.missing, (MissingStaff.Survive, 2) },
                { QuestionId.stage, (GameState.Start, 3) },
                { QuestionId.canBuy, (false, 0) },
            }, "Bracer"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.missing, (MissingStaff.Mana, 3) },
                { QuestionId.stage, (GameState.Start, 3) },
                { QuestionId.canBuy, (false, 0) },
            }, "Soul Ring"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.missing, (MissingStaff.Mana, 3) },
                { QuestionId.stage, (GameState.Start, 3) },
                { QuestionId.canBuy, (false, 0) },
                { QuestionId.role, (new int[]{1,2,3}, 2) },
            }, "Falcon Blade"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.canCatch, (false, 1) },
                { QuestionId.missing, (MissingStaff.Damage, 2) },
                { QuestionId.stage, (GameState.Start, 1) },
                { QuestionId.canBuy, (false, 0) },
                { QuestionId.role, (new int[]{1,2,3,4}, 2) },
            }, "Phase Boots"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.farmState, (FarmType.Melee, 3) },
                { QuestionId.canCatch, (true, 2) },
                { QuestionId.missing, (MissingStaff.Farm, 2) },
                { QuestionId.stage, (GameState.Midgame, 2) },
                { QuestionId.canBuy, (false, 0) },
                { QuestionId.role, (new int[]{1,2,3}, 2) },
            }, "Mask of Madness"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.farmState, (FarmType.NoTime, 4) },
                { QuestionId.missing, (MissingStaff.Farm, 4) },
                { QuestionId.canBuy, (false, 0) },
            }, "Hand of Midass"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.baffType, (BaffType.AtackSpeed, 4) },
                { QuestionId.supportType, (SupportStuff.Baff, 4) },
                { QuestionId.canCatch, (true, 2) },
                { QuestionId.missing, (MissingStaff.Damage, 2) },
                { QuestionId.stage, (GameState.Endgame, 4) },
                { QuestionId.canBuy, (false, 0) },
                { QuestionId.role, (new int[]{1,2,3}, 2) },
            }, "Moon Shard"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.dmg, (new int[]{1,-1, -1}, 1) },
                { QuestionId.supportType, (SupportStuff.Heal, 1) },
                { QuestionId.missing, (MissingStaff.Support, 1) },
                { QuestionId.stage, (GameState.Start, 2) },
                { QuestionId.canBuy, (false, 0) },
                { QuestionId.role, (new int[]{3,4,5}, 2) },
            }, "Buckler"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.supportType, (SupportStuff.Baff, 2) },
                { QuestionId.missing, (MissingStaff.Support, 2) },
                { QuestionId.stage, (GameState.Start, 2) },
                { QuestionId.canBuy, (false, 0) },
                { QuestionId.role, (new int[]{4,5}, 2) },
            }, "Ring of Basilus"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.supportType, (SupportStuff.Heal, 3) },
                { QuestionId.missing, (MissingStaff.Support, 2) },
                { QuestionId.stage, (GameState.Start, 3) },
                { QuestionId.canBuy, (false, 0) },
                { QuestionId.role, (new int[]{3,4,5}, 2) },
            }, "Headdress"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.missing, (MissingStaff.Survive, 3) },
                { QuestionId.stage, (GameState.Start, 2) },
                { QuestionId.canBuy, (false, 0) },
                { QuestionId.role, (new int[]{4,5}, 2) },
            }, "Tranquil boots"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.baffType, (BaffType.Damage, 2) },
                { QuestionId.supportType, (SupportStuff.Baff, 2) },
                { QuestionId.missing, (MissingStaff.Support, 2) },
                { QuestionId.stage, (GameState.Midgame, 3) },
                { QuestionId.canBuy, (false, 0) },
                { QuestionId.role, (new int[]{4,5}, 3) },
            }, "Medallion of Courage"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.supportType, (SupportStuff.Baff, 3) },
                { QuestionId.missing, (MissingStaff.Mana, 4) },
                { QuestionId.stage, (GameState.Start, 2) },
                { QuestionId.canBuy, (false, 0) },
                { QuestionId.role, (new int[]{4,5}, 2) },
            }, "Arcane boots"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.baffType, (BaffType.AtackSpeed, 4) },
                { QuestionId.canCatch, (true, 2) },
                { QuestionId.missing, (MissingStaff.Support, 1) },
                { QuestionId.stage, (GameState.Midgame, 1) },
                { QuestionId.canBuy, (false, 0) },
                { QuestionId.role, (new int[]{3,4,5}, 2) },
            }, "Drum of Endurance"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.supportType, (SupportStuff.Heal, 4) },
                { QuestionId.missing, (MissingStaff.Support, 2) },
                { QuestionId.stage, (GameState.Midgame, 2) },
                { QuestionId.canBuy, (false, 0) },
                { QuestionId.role, (new int[]{3,4,5}, 2) },
            }, "Mekansm"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.supportType, (SupportStuff.Heal, 4) },
                { QuestionId.heroRole, (IngameType.Killer, 1) },
                { QuestionId.missing, (MissingStaff.Support, 2) },
                { QuestionId.stage, (GameState.Midgame, 3) },
                { QuestionId.canBuy, (false, 0) },
                { QuestionId.role, (new int[]{4,5}, 2) },
            }, "Holy Locket"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.dmg, (new int[]{-1,1, -1}, 4) },
                { QuestionId.supportType, (SupportStuff.Heal, 2) },
                { QuestionId.missing, (MissingStaff.Support, 2) },
                { QuestionId.stage, (GameState.Midgame, 2) },
                { QuestionId.canBuy, (false, 0) },
                { QuestionId.role, (new int[]{3,4}, 3) },
            }, "Pipe of insight"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.supportType, (SupportStuff.Heal, 4) },
                { QuestionId.missing, (MissingStaff.Support, 2) },
                { QuestionId.stage, (GameState.Endgame, 4) },
                { QuestionId.canBuy, (false, 0) },
                { QuestionId.role, (new int[]{3,4,5}, 2) },
            }, "Guardian graves"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.dmg, (new int[]{-1,1,-1}, 2) },
                { QuestionId.supportType, (SupportStuff.Escape, 4) },
                { QuestionId.missing, (MissingStaff.Support, 3) },
                { QuestionId.stage, (GameState.Midgame, 3) },
                { QuestionId.canBuy, (false, 0) },
                { QuestionId.role, (new int[]{4,5}, 2) },
            }, "Glimmer Cape"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.supportType, (SupportStuff.Escape, 4) },
                { QuestionId.missing, (MissingStaff.Support, 4) },
                { QuestionId.stage, (GameState.Midgame, 2) },
                { QuestionId.canBuy, (false, 0) },
                { QuestionId.role, (new int[]{4,5}, 3) },
            }, "Force Staff"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.canCatch, (false, 4) },
                { QuestionId.heroRole, (IngameType.Mage, 5) },
                { QuestionId.missing, (MissingStaff.Damage, 1.5f) },
                { QuestionId.stage, (GameState.Midgame, 2) },
                { QuestionId.canBuy, (false, 0) },
            }, "Aether lens"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.enemyBaffs, (true, 9) },
                { QuestionId.supportType, (SupportStuff.Escape, 2) },
                { QuestionId.canCatch, (false, 2) },
                { QuestionId.missing, (MissingStaff.Support, 2) },
                { QuestionId.stage, (GameState.Midgame, 2) },
                { QuestionId.canBuy, (false, 0) },
                { QuestionId.role, (new int[]{1,2,3,4,5}, 2) },
            }, "Euls scepter"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.supportType, (SupportStuff.Catch, 10) },
                { QuestionId.canCatch, (false, 10) },
                { QuestionId.missing, (MissingStaff.Damage, 1) },
                { QuestionId.stage, (GameState.Midgame, 2) },
                { QuestionId.canBuy, (false, 0) },
                { QuestionId.role, (new int[]{2,4}, 3) },
            }, "Rod of Atos"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.canCatch, (true, 3) },
                { QuestionId.heroRole, (IngameType.Mage, 6) },
                { QuestionId.missing, (MissingStaff.Damage, 2) },
                { QuestionId.stage, (GameState.Midgame, 2) },
                { QuestionId.canBuy, (false, 0) },
                { QuestionId.role, (new int[]{1,2}, 2) },
            }, "Dagon"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.supportType, (SupportStuff.Catch, 3) },
                { QuestionId.canCatch, (false, 3) },
                { QuestionId.heroRole, (IngameType.Mage, 2) },
                { QuestionId.missing, (MissingStaff.Damage, 2) },
                { QuestionId.stage, (GameState.Midgame, 2) },
                { QuestionId.canBuy, (false, 0) },
                { QuestionId.role, (new int[]{1,2,3,4,5}, 2) },
            }, "Orchid Malevolence"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.baffType, (BaffType.Damage, 2) },
                { QuestionId.supportType, (SupportStuff.Baff, 2) },
                { QuestionId.missing, (MissingStaff.Support, 2) },
                { QuestionId.stage, (GameState.Midgame, 3) },
                { QuestionId.canBuy, (false, 0) },
                { QuestionId.role, (new int[]{4,5}, 3) },
            }, "Solar Crest"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.enemyBaffs, (true, 4) },
                { QuestionId.supportType, (SupportStuff.Heal, 2) },
                { QuestionId.missing, (MissingStaff.Support, 2) },
                { QuestionId.stage, (GameState.Midgame, 2) },
                { QuestionId.canBuy, (false, 0) },
                { QuestionId.role, (new int[]{3,4,5}, 2) },
            }, "Scythe of Vyse"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.farmState, (FarmType.Melee, 2) },
                { QuestionId.enemyInvis, (true, 3) },
                { QuestionId.canCatch, (false, 4) },
                { QuestionId.missing, (MissingStaff.Damage, 2) },
                { QuestionId.stage, (GameState.Midgame, 3) },
                { QuestionId.canBuy, (false, 0) },
                { QuestionId.role, (new int[]{1,2,3}, 2) },
            }, "Gleipnir"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.dmg, (new int[]{-1,1,-1}, 1) },
                { QuestionId.missing, (MissingStaff.Survive, 3) },
                { QuestionId.stage, (GameState.Midgame, 2) },
                { QuestionId.canBuy, (false, 0) },
                { QuestionId.role, (new int[]{3,4}, 2) },
            }, "Hood of Defiance"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.missing, (MissingStaff.Survive, 3) },
                { QuestionId.stage, (GameState.Start, 2) },
                { QuestionId.canBuy, (false, 0) },
                { QuestionId.role, (new int[]{3,4}, 3) },
            }, "Vangurd"),
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.dmg, (new int[]{-1,-1,1}, 7) },
                { QuestionId.mainAttribute, (Atribute.Strength, 2) },
                { QuestionId.stage, (GameState.Midgame, 2) },
                { QuestionId.canBuy, (false, 0) },
                { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            }, "Blademale"),
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.spammers, (true, 1) },
            //    { QuestionId.farmState, (FarmType.Melee, 1) },
            //    { QuestionId.directSpells, (true, 1) },
            //    { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
            //    { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
            //    { QuestionId.enemyBaffs, (false, 1) },
            //    { QuestionId.enemyInvis, (false, 1) },
            //    { QuestionId.supportType, (SupportStuff.Escape, 1) },
            //    { QuestionId.canCatch, (true, 1) },
            //    { QuestionId.mainAttribute, (Atribute.Universal, 1) },
            //    { QuestionId.enemyPassive, (true, 1) },
            //    { QuestionId.heroRole, (IngameType.Killer, 1) },
            //    { QuestionId.missing, (MissingStaff.Mana, 1) },
            //    { QuestionId.stage, (GameState.Start, 1) },
            //    { QuestionId.canBuy, (false, 0) },
            //    { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            //}, "Aeon Disk"),
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.spammers, (true, 1) },
            //    { QuestionId.farmState, (FarmType.Melee, 1) },
            //    { QuestionId.directSpells, (true, 1) },
            //    { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
            //    { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
            //    { QuestionId.enemyBaffs, (false, 1) },
            //    { QuestionId.enemyInvis, (false, 1) },
            //    { QuestionId.supportType, (SupportStuff.Escape, 1) },
            //    { QuestionId.canCatch, (true, 1) },
            //    { QuestionId.mainAttribute, (Atribute.Universal, 1) },
            //    { QuestionId.enemyPassive, (true, 1) },
            //    { QuestionId.heroRole, (IngameType.Killer, 1) },
            //    { QuestionId.missing, (MissingStaff.Mana, 1) },
            //    { QuestionId.stage, (GameState.Start, 1) },
            //    { QuestionId.canBuy, (false, 0) },
            //    { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            //}, "Lotus orb"),
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.spammers, (true, 1) },
            //    { QuestionId.farmState, (FarmType.Melee, 1) },
            //    { QuestionId.directSpells, (true, 1) },
            //    { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
            //    { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
            //    { QuestionId.enemyBaffs, (false, 1) },
            //    { QuestionId.enemyInvis, (false, 1) },
            //    { QuestionId.supportType, (SupportStuff.Escape, 1) },
            //    { QuestionId.canCatch, (true, 1) },
            //    { QuestionId.mainAttribute, (Atribute.Universal, 1) },
            //    { QuestionId.enemyPassive, (true, 1) },
            //    { QuestionId.heroRole, (IngameType.Killer, 1) },
            //    { QuestionId.missing, (MissingStaff.Mana, 1) },
            //    { QuestionId.stage, (GameState.Start, 1) },
            //    { QuestionId.canBuy, (false, 0) },
            //    { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            //}, "Black king bar"),
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.spammers, (true, 1) },
            //    { QuestionId.farmState, (FarmType.Melee, 1) },
            //    { QuestionId.directSpells, (true, 1) },
            //    { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
            //    { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
            //    { QuestionId.enemyBaffs, (false, 1) },
            //    { QuestionId.enemyInvis, (false, 1) },
            //    { QuestionId.supportType, (SupportStuff.Escape, 1) },
            //    { QuestionId.canCatch, (true, 1) },
            //    { QuestionId.mainAttribute, (Atribute.Universal, 1) },
            //    { QuestionId.enemyPassive, (true, 1) },
            //    { QuestionId.heroRole, (IngameType.Killer, 1) },
            //    { QuestionId.missing, (MissingStaff.Mana, 1) },
            //    { QuestionId.stage, (GameState.Start, 1) },
            //    { QuestionId.canBuy, (false, 0) },
            //    { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            //}, "Hurricane Pike"),
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.spammers, (true, 1) },
            //    { QuestionId.farmState, (FarmType.Melee, 1) },
            //    { QuestionId.directSpells, (true, 1) },
            //    { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
            //    { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
            //    { QuestionId.enemyBaffs, (false, 1) },
            //    { QuestionId.enemyInvis, (false, 1) },
            //    { QuestionId.supportType, (SupportStuff.Escape, 1) },
            //    { QuestionId.canCatch, (true, 1) },
            //    { QuestionId.mainAttribute, (Atribute.Universal, 1) },
            //    { QuestionId.enemyPassive, (true, 1) },
            //    { QuestionId.heroRole, (IngameType.Killer, 1) },
            //    { QuestionId.missing, (MissingStaff.Mana, 1) },
            //    { QuestionId.stage, (GameState.Start, 1) },
            //    { QuestionId.canBuy, (false, 0) },
            //    { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            //}, "Manta style"),
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.spammers, (true, 1) },
            //    { QuestionId.farmState, (FarmType.Melee, 1) },
            //    { QuestionId.directSpells, (true, 1) },
            //    { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
            //    { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
            //    { QuestionId.enemyBaffs, (false, 1) },
            //    { QuestionId.enemyInvis, (false, 1) },
            //    { QuestionId.supportType, (SupportStuff.Escape, 1) },
            //    { QuestionId.canCatch, (true, 1) },
            //    { QuestionId.mainAttribute, (Atribute.Universal, 1) },
            //    { QuestionId.enemyPassive, (true, 1) },
            //    { QuestionId.heroRole, (IngameType.Killer, 1) },
            //    { QuestionId.missing, (MissingStaff.Mana, 1) },
            //    { QuestionId.stage, (GameState.Start, 1) },
            //    { QuestionId.canBuy, (false, 0) },
            //    { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            //}, "Linken`s sphere"),
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.spammers, (true, 1) },
            //    { QuestionId.farmState, (FarmType.Melee, 1) },
            //    { QuestionId.directSpells, (true, 1) },
            //    { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
            //    { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
            //    { QuestionId.enemyBaffs, (false, 1) },
            //    { QuestionId.enemyInvis, (false, 1) },
            //    { QuestionId.supportType, (SupportStuff.Escape, 1) },
            //    { QuestionId.canCatch, (true, 1) },
            //    { QuestionId.mainAttribute, (Atribute.Universal, 1) },
            //    { QuestionId.enemyPassive, (true, 1) },
            //    { QuestionId.heroRole, (IngameType.Killer, 1) },
            //    { QuestionId.missing, (MissingStaff.Mana, 1) },
            //    { QuestionId.stage, (GameState.Start, 1) },
            //    { QuestionId.canBuy, (false, 0) },
            //    { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            //}, "Heart of Tarasque"),
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.spammers, (true, 1) },
            //    { QuestionId.farmState, (FarmType.Melee, 1) },
            //    { QuestionId.directSpells, (true, 1) },
            //    { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
            //    { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
            //    { QuestionId.enemyBaffs, (false, 1) },
            //    { QuestionId.enemyInvis, (false, 1) },
            //    { QuestionId.supportType, (SupportStuff.Escape, 1) },
            //    { QuestionId.canCatch, (true, 1) },
            //    { QuestionId.mainAttribute, (Atribute.Universal, 1) },
            //    { QuestionId.enemyPassive, (true, 1) },
            //    { QuestionId.heroRole, (IngameType.Killer, 1) },
            //    { QuestionId.missing, (MissingStaff.Mana, 1) },
            //    { QuestionId.stage, (GameState.Start, 1) },
            //    { QuestionId.canBuy, (false, 0) },
            //    { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            //}, "Assault Cuirass"),
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.spammers, (true, 1) },
            //    { QuestionId.farmState, (FarmType.Melee, 1) },
            //    { QuestionId.directSpells, (true, 1) },
            //    { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
            //    { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
            //    { QuestionId.enemyBaffs, (false, 1) },
            //    { QuestionId.enemyInvis, (false, 1) },
            //    { QuestionId.supportType, (SupportStuff.Escape, 1) },
            //    { QuestionId.canCatch, (true, 1) },
            //    { QuestionId.mainAttribute, (Atribute.Universal, 1) },
            //    { QuestionId.enemyPassive, (true, 1) },
            //    { QuestionId.heroRole, (IngameType.Killer, 1) },
            //    { QuestionId.missing, (MissingStaff.Mana, 1) },
            //    { QuestionId.stage, (GameState.Start, 1) },
            //    { QuestionId.canBuy, (false, 0) },
            //    { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            //}, "Bloodstone"),
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.spammers, (true, 1) },
            //    { QuestionId.farmState, (FarmType.Melee, 1) },
            //    { QuestionId.directSpells, (true, 1) },
            //    { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
            //    { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
            //    { QuestionId.enemyBaffs, (false, 1) },
            //    { QuestionId.enemyInvis, (false, 1) },
            //    { QuestionId.supportType, (SupportStuff.Escape, 1) },
            //    { QuestionId.canCatch, (true, 1) },
            //    { QuestionId.mainAttribute, (Atribute.Universal, 1) },
            //    { QuestionId.enemyPassive, (true, 1) },
            //    { QuestionId.heroRole, (IngameType.Killer, 1) },
            //    { QuestionId.missing, (MissingStaff.Mana, 1) },
            //    { QuestionId.stage, (GameState.Start, 1) },
            //    { QuestionId.canBuy, (false, 0) },
            //    { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            //}, "Armlet of Mordiggian"),
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.spammers, (true, 1) },
            //    { QuestionId.farmState, (FarmType.Melee, 1) },
            //    { QuestionId.directSpells, (true, 1) },
            //    { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
            //    { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
            //    { QuestionId.enemyBaffs, (false, 1) },
            //    { QuestionId.enemyInvis, (false, 1) },
            //    { QuestionId.supportType, (SupportStuff.Escape, 1) },
            //    { QuestionId.canCatch, (true, 1) },
            //    { QuestionId.mainAttribute, (Atribute.Universal, 1) },
            //    { QuestionId.enemyPassive, (true, 1) },
            //    { QuestionId.heroRole, (IngameType.Killer, 1) },
            //    { QuestionId.missing, (MissingStaff.Mana, 1) },
            //    { QuestionId.stage, (GameState.Start, 1) },
            //    { QuestionId.canBuy, (false, 0) },
            //    { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            //}, "Skull basher"),
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.spammers, (true, 1) },
            //    { QuestionId.farmState, (FarmType.Melee, 1) },
            //    { QuestionId.directSpells, (true, 1) },
            //    { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
            //    { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
            //    { QuestionId.enemyBaffs, (false, 1) },
            //    { QuestionId.enemyInvis, (false, 1) },
            //    { QuestionId.supportType, (SupportStuff.Escape, 1) },
            //    { QuestionId.canCatch, (true, 1) },
            //    { QuestionId.mainAttribute, (Atribute.Universal, 1) },
            //    { QuestionId.enemyPassive, (true, 1) },
            //    { QuestionId.heroRole, (IngameType.Killer, 1) },
            //    { QuestionId.missing, (MissingStaff.Mana, 1) },
            //    { QuestionId.stage, (GameState.Start, 1) },
            //    { QuestionId.canBuy, (false, 0) },
            //    { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            //}, "Shadow blade"),
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.spammers, (true, 1) },
            //    { QuestionId.farmState, (FarmType.Melee, 1) },
            //    { QuestionId.directSpells, (true, 1) },
            //    { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
            //    { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
            //    { QuestionId.enemyBaffs, (false, 1) },
            //    { QuestionId.enemyInvis, (false, 1) },
            //    { QuestionId.supportType, (SupportStuff.Escape, 1) },
            //    { QuestionId.canCatch, (true, 1) },
            //    { QuestionId.mainAttribute, (Atribute.Universal, 1) },
            //    { QuestionId.enemyPassive, (true, 1) },
            //    { QuestionId.heroRole, (IngameType.Killer, 1) },
            //    { QuestionId.missing, (MissingStaff.Mana, 1) },
            //    { QuestionId.stage, (GameState.Start, 1) },
            //    { QuestionId.canBuy, (false, 0) },
            //    { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            //}, "Desolator"),
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.spammers, (true, 1) },
            //    { QuestionId.farmState, (FarmType.Melee, 1) },
            //    { QuestionId.directSpells, (true, 1) },
            //    { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
            //    { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
            //    { QuestionId.enemyBaffs, (false, 1) },
            //    { QuestionId.enemyInvis, (false, 1) },
            //    { QuestionId.supportType, (SupportStuff.Escape, 1) },
            //    { QuestionId.canCatch, (true, 1) },
            //    { QuestionId.mainAttribute, (Atribute.Universal, 1) },
            //    { QuestionId.enemyPassive, (true, 1) },
            //    { QuestionId.heroRole, (IngameType.Killer, 1) },
            //    { QuestionId.missing, (MissingStaff.Mana, 1) },
            //    { QuestionId.stage, (GameState.Start, 1) },
            //    { QuestionId.canBuy, (false, 0) },
            //    { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            //}, "Battle fury"),
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.spammers, (true, 1) },
            //    { QuestionId.farmState, (FarmType.Melee, 1) },
            //    { QuestionId.directSpells, (true, 1) },
            //    { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
            //    { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
            //    { QuestionId.enemyBaffs, (false, 1) },
            //    { QuestionId.enemyInvis, (false, 1) },
            //    { QuestionId.supportType, (SupportStuff.Escape, 1) },
            //    { QuestionId.canCatch, (true, 1) },
            //    { QuestionId.mainAttribute, (Atribute.Universal, 1) },
            //    { QuestionId.enemyPassive, (true, 1) },
            //    { QuestionId.heroRole, (IngameType.Killer, 1) },
            //    { QuestionId.missing, (MissingStaff.Mana, 1) },
            //    { QuestionId.stage, (GameState.Start, 1) },
            //    { QuestionId.canBuy, (false, 0) },
            //    { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            //}, "Ethernal blade"),
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.spammers, (true, 1) },
            //    { QuestionId.farmState, (FarmType.Melee, 1) },
            //    { QuestionId.directSpells, (true, 1) },
            //    { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
            //    { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
            //    { QuestionId.enemyBaffs, (false, 1) },
            //    { QuestionId.enemyInvis, (false, 1) },
            //    { QuestionId.supportType, (SupportStuff.Escape, 1) },
            //    { QuestionId.canCatch, (true, 1) },
            //    { QuestionId.mainAttribute, (Atribute.Universal, 1) },
            //    { QuestionId.enemyPassive, (true, 1) },
            //    { QuestionId.heroRole, (IngameType.Killer, 1) },
            //    { QuestionId.missing, (MissingStaff.Mana, 1) },
            //    { QuestionId.stage, (GameState.Start, 1) },
            //    { QuestionId.canBuy, (false, 0) },
            //    { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            //}, "Nullifier"),
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.spammers, (true, 1) },
            //    { QuestionId.farmState, (FarmType.Melee, 1) },
            //    { QuestionId.directSpells, (true, 1) },
            //    { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
            //    { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
            //    { QuestionId.enemyBaffs, (false, 1) },
            //    { QuestionId.enemyInvis, (false, 1) },
            //    { QuestionId.supportType, (SupportStuff.Escape, 1) },
            //    { QuestionId.canCatch, (true, 1) },
            //    { QuestionId.mainAttribute, (Atribute.Universal, 1) },
            //    { QuestionId.enemyPassive, (true, 1) },
            //    { QuestionId.heroRole, (IngameType.Killer, 1) },
            //    { QuestionId.missing, (MissingStaff.Mana, 1) },
            //    { QuestionId.stage, (GameState.Start, 1) },
            //    { QuestionId.canBuy, (false, 0) },
            //    { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            //}, "Butterfly"),
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.spammers, (true, 1) },
            //    { QuestionId.farmState, (FarmType.Melee, 1) },
            //    { QuestionId.directSpells, (true, 1) },
            //    { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
            //    { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
            //    { QuestionId.enemyBaffs, (false, 1) },
            //    { QuestionId.enemyInvis, (false, 1) },
            //    { QuestionId.supportType, (SupportStuff.Escape, 1) },
            //    { QuestionId.canCatch, (true, 1) },
            //    { QuestionId.mainAttribute, (Atribute.Universal, 1) },
            //    { QuestionId.enemyPassive, (true, 1) },
            //    { QuestionId.heroRole, (IngameType.Killer, 1) },
            //    { QuestionId.missing, (MissingStaff.Mana, 1) },
            //    { QuestionId.stage, (GameState.Start, 1) },
            //    { QuestionId.canBuy, (false, 0) },
            //    { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            //}, "Radiance"),
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.spammers, (true, 1) },
            //    { QuestionId.farmState, (FarmType.Melee, 1) },
            //    { QuestionId.directSpells, (true, 1) },
            //    { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
            //    { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
            //    { QuestionId.enemyBaffs, (false, 1) },
            //    { QuestionId.enemyInvis, (false, 1) },
            //    { QuestionId.supportType, (SupportStuff.Escape, 1) },
            //    { QuestionId.canCatch, (true, 1) },
            //    { QuestionId.mainAttribute, (Atribute.Universal, 1) },
            //    { QuestionId.enemyPassive, (true, 1) },
            //    { QuestionId.heroRole, (IngameType.Killer, 1) },
            //    { QuestionId.missing, (MissingStaff.Mana, 1) },
            //    { QuestionId.stage, (GameState.Start, 1) },
            //    { QuestionId.canBuy, (false, 0) },
            //    { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            //}, "Daedalus"),
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.spammers, (true, 1) },
            //    { QuestionId.farmState, (FarmType.Melee, 1) },
            //    { QuestionId.directSpells, (true, 1) },
            //    { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
            //    { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
            //    { QuestionId.enemyBaffs, (false, 1) },
            //    { QuestionId.enemyInvis, (false, 1) },
            //    { QuestionId.supportType, (SupportStuff.Escape, 1) },
            //    { QuestionId.canCatch, (true, 1) },
            //    { QuestionId.mainAttribute, (Atribute.Universal, 1) },
            //    { QuestionId.enemyPassive, (true, 1) },
            //    { QuestionId.heroRole, (IngameType.Killer, 1) },
            //    { QuestionId.missing, (MissingStaff.Mana, 1) },
            //    { QuestionId.stage, (GameState.Start, 1) },
            //    { QuestionId.canBuy, (false, 0) },
            //    { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            //}, "Silver Edge"),
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.spammers, (true, 1) },
            //    { QuestionId.farmState, (FarmType.Melee, 1) },
            //    { QuestionId.directSpells, (true, 1) },
            //    { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
            //    { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
            //    { QuestionId.enemyBaffs, (false, 1) },
            //    { QuestionId.enemyInvis, (false, 1) },
            //    { QuestionId.supportType, (SupportStuff.Escape, 1) },
            //    { QuestionId.canCatch, (true, 1) },
            //    { QuestionId.mainAttribute, (Atribute.Universal, 1) },
            //    { QuestionId.enemyPassive, (true, 1) },
            //    { QuestionId.heroRole, (IngameType.Killer, 1) },
            //    { QuestionId.missing, (MissingStaff.Mana, 1) },
            //    { QuestionId.stage, (GameState.Start, 1) },
            //    { QuestionId.canBuy, (false, 0) },
            //    { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            //}, "Divine Rapier"),
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.spammers, (true, 1) },
            //    { QuestionId.farmState, (FarmType.Melee, 1) },
            //    { QuestionId.directSpells, (true, 1) },
            //    { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
            //    { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
            //    { QuestionId.enemyBaffs, (false, 1) },
            //    { QuestionId.enemyInvis, (false, 1) },
            //    { QuestionId.supportType, (SupportStuff.Escape, 1) },
            //    { QuestionId.canCatch, (true, 1) },
            //    { QuestionId.mainAttribute, (Atribute.Universal, 1) },
            //    { QuestionId.enemyPassive, (true, 1) },
            //    { QuestionId.heroRole, (IngameType.Killer, 1) },
            //    { QuestionId.missing, (MissingStaff.Mana, 1) },
            //    { QuestionId.stage, (GameState.Start, 1) },
            //    { QuestionId.canBuy, (false, 0) },
            //    { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            //}, "Bloodthorn"),
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.spammers, (true, 1) },
            //    { QuestionId.farmState, (FarmType.Melee, 1) },
            //    { QuestionId.directSpells, (true, 1) },
            //    { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
            //    { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
            //    { QuestionId.enemyBaffs, (false, 1) },
            //    { QuestionId.enemyInvis, (false, 1) },
            //    { QuestionId.supportType, (SupportStuff.Escape, 1) },
            //    { QuestionId.canCatch, (true, 1) },
            //    { QuestionId.mainAttribute, (Atribute.Universal, 1) },
            //    { QuestionId.enemyPassive, (true, 1) },
            //    { QuestionId.heroRole, (IngameType.Killer, 1) },
            //    { QuestionId.missing, (MissingStaff.Mana, 1) },
            //    { QuestionId.stage, (GameState.Start, 1) },
            //    { QuestionId.canBuy, (false, 0) },
            //    { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            //}, "Abyssal blade"),
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.spammers, (true, 1) },
            //    { QuestionId.farmState, (FarmType.Melee, 1) },
            //    { QuestionId.directSpells, (true, 1) },
            //    { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
            //    { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
            //    { QuestionId.enemyBaffs, (false, 1) },
            //    { QuestionId.enemyInvis, (false, 1) },
            //    { QuestionId.supportType, (SupportStuff.Escape, 1) },
            //    { QuestionId.canCatch, (true, 1) },
            //    { QuestionId.mainAttribute, (Atribute.Universal, 1) },
            //    { QuestionId.enemyPassive, (true, 1) },
            //    { QuestionId.heroRole, (IngameType.Killer, 1) },
            //    { QuestionId.missing, (MissingStaff.Mana, 1) },
            //    { QuestionId.stage, (GameState.Start, 1) },
            //    { QuestionId.canBuy, (false, 0) },
            //    { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            //}, "Dragon Lance"),
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.spammers, (true, 1) },
            //    { QuestionId.farmState, (FarmType.Melee, 1) },
            //    { QuestionId.directSpells, (true, 1) },
            //    { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
            //    { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
            //    { QuestionId.enemyBaffs, (false, 1) },
            //    { QuestionId.enemyInvis, (false, 1) },
            //    { QuestionId.supportType, (SupportStuff.Escape, 1) },
            //    { QuestionId.canCatch, (true, 1) },
            //    { QuestionId.mainAttribute, (Atribute.Universal, 1) },
            //    { QuestionId.enemyPassive, (true, 1) },
            //    { QuestionId.heroRole, (IngameType.Killer, 1) },
            //    { QuestionId.missing, (MissingStaff.Mana, 1) },
            //    { QuestionId.stage, (GameState.Start, 1) },
            //    { QuestionId.canBuy, (false, 0) },
            //    { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            //}, "Kaya"),
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.spammers, (true, 1) },
            //    { QuestionId.farmState, (FarmType.Melee, 1) },
            //    { QuestionId.directSpells, (true, 1) },
            //    { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
            //    { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
            //    { QuestionId.enemyBaffs, (false, 1) },
            //    { QuestionId.enemyInvis, (false, 1) },
            //    { QuestionId.supportType, (SupportStuff.Escape, 1) },
            //    { QuestionId.canCatch, (true, 1) },
            //    { QuestionId.mainAttribute, (Atribute.Universal, 1) },
            //    { QuestionId.enemyPassive, (true, 1) },
            //    { QuestionId.heroRole, (IngameType.Killer, 1) },
            //    { QuestionId.missing, (MissingStaff.Mana, 1) },
            //    { QuestionId.stage, (GameState.Start, 1) },
            //    { QuestionId.canBuy, (false, 0) },
            //    { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            //}, "Echo Sabre"),
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.spammers, (true, 1) },
            //    { QuestionId.farmState, (FarmType.Melee, 1) },
            //    { QuestionId.directSpells, (true, 1) },
            //    { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
            //    { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
            //    { QuestionId.enemyBaffs, (false, 1) },
            //    { QuestionId.enemyInvis, (false, 1) },
            //    { QuestionId.supportType, (SupportStuff.Escape, 1) },
            //    { QuestionId.canCatch, (true, 1) },
            //    { QuestionId.mainAttribute, (Atribute.Universal, 1) },
            //    { QuestionId.enemyPassive, (true, 1) },
            //    { QuestionId.heroRole, (IngameType.Killer, 1) },
            //    { QuestionId.missing, (MissingStaff.Mana, 1) },
            //    { QuestionId.stage, (GameState.Start, 1) },
            //    { QuestionId.canBuy, (false, 0) },
            //    { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            //}, "Maelstorm"),
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.spammers, (true, 1) },
            //    { QuestionId.farmState, (FarmType.Melee, 1) },
            //    { QuestionId.directSpells, (true, 1) },
            //    { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
            //    { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
            //    { QuestionId.enemyBaffs, (false, 1) },
            //    { QuestionId.enemyInvis, (false, 1) },
            //    { QuestionId.supportType, (SupportStuff.Escape, 1) },
            //    { QuestionId.canCatch, (true, 1) },
            //    { QuestionId.mainAttribute, (Atribute.Universal, 1) },
            //    { QuestionId.enemyPassive, (true, 1) },
            //    { QuestionId.heroRole, (IngameType.Killer, 1) },
            //    { QuestionId.missing, (MissingStaff.Mana, 1) },
            //    { QuestionId.stage, (GameState.Start, 1) },
            //    { QuestionId.canBuy, (false, 0) },
            //    { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            //}, "Diffusal blade"),
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.spammers, (true, 1) },
            //    { QuestionId.farmState, (FarmType.Melee, 1) },
            //    { QuestionId.directSpells, (true, 1) },
            //    { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
            //    { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
            //    { QuestionId.enemyBaffs, (false, 1) },
            //    { QuestionId.enemyInvis, (false, 1) },
            //    { QuestionId.supportType, (SupportStuff.Escape, 1) },
            //    { QuestionId.canCatch, (true, 1) },
            //    { QuestionId.mainAttribute, (Atribute.Universal, 1) },
            //    { QuestionId.enemyPassive, (true, 1) },
            //    { QuestionId.heroRole, (IngameType.Killer, 1) },
            //    { QuestionId.missing, (MissingStaff.Mana, 1) },
            //    { QuestionId.stage, (GameState.Start, 1) },
            //    { QuestionId.canBuy, (false, 0) },
            //    { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            //}, "Mage slayer"),
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.spammers, (true, 1) },
            //    { QuestionId.farmState, (FarmType.Melee, 1) },
            //    { QuestionId.directSpells, (true, 1) },
            //    { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
            //    { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
            //    { QuestionId.enemyBaffs, (false, 1) },
            //    { QuestionId.enemyInvis, (false, 1) },
            //    { QuestionId.supportType, (SupportStuff.Escape, 1) },
            //    { QuestionId.canCatch, (true, 1) },
            //    { QuestionId.mainAttribute, (Atribute.Universal, 1) },
            //    { QuestionId.enemyPassive, (true, 1) },
            //    { QuestionId.heroRole, (IngameType.Killer, 1) },
            //    { QuestionId.missing, (MissingStaff.Mana, 1) },
            //    { QuestionId.stage, (GameState.Start, 1) },
            //    { QuestionId.canBuy, (false, 0) },
            //    { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            //}, "Havens halebard"),
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.spammers, (true, 1) },
            //    { QuestionId.farmState, (FarmType.Melee, 1) },
            //    { QuestionId.directSpells, (true, 1) },
            //    { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
            //    { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
            //    { QuestionId.enemyBaffs, (false, 1) },
            //    { QuestionId.enemyInvis, (false, 1) },
            //    { QuestionId.supportType, (SupportStuff.Escape, 1) },
            //    { QuestionId.canCatch, (true, 1) },
            //    { QuestionId.mainAttribute, (Atribute.Universal, 1) },
            //    { QuestionId.enemyPassive, (true, 1) },
            //    { QuestionId.heroRole, (IngameType.Killer, 1) },
            //    { QuestionId.missing, (MissingStaff.Mana, 1) },
            //    { QuestionId.stage, (GameState.Start, 1) },
            //    { QuestionId.canBuy, (false, 0) },
            //    { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            //}, "Satanic"),
            //new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
            //    { QuestionId.spammers, (true, 1) },
            //    { QuestionId.farmState, (FarmType.Melee, 1) },
            //    { QuestionId.directSpells, (true, 1) },
            //    { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
            //    { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
            //    { QuestionId.enemyBaffs, (false, 1) },
            //    { QuestionId.enemyInvis, (false, 1) },
            //    { QuestionId.supportType, (SupportStuff.Escape, 1) },
            //    { QuestionId.canCatch, (true, 1) },
            //    { QuestionId.mainAttribute, (Atribute.Universal, 1) },
            //    { QuestionId.enemyPassive, (true, 1) },
            //    { QuestionId.heroRole, (IngameType.Killer, 1) },
            //    { QuestionId.missing, (MissingStaff.Mana, 1) },
            //    { QuestionId.stage, (GameState.Start, 1) },
            //    { QuestionId.canBuy, (false, 0) },
            //    { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            //}, "Eye of skadi"),
            /*
            new Result(new Dictionary<QuestionId, (dynamic res, float koef)>(){
                { QuestionId.spammers, (true, 1) },
                { QuestionId.farmState, (FarmType.Melee, 1) },
                { QuestionId.directSpells, (true, 1) },
                { QuestionId.dmg, (new int[]{12.3f,14.4f}, 1) },
                { QuestionId.baffType, (BaffType.AtackSpeed, 1) },
                { QuestionId.enemyBaffs, (false, 1) },
                { QuestionId.enemyInvis, (false, 1) },
                { QuestionId.supportType, (SupportStuff.Escape, 1) },
                { QuestionId.canCatch, (true, 1) },
                { QuestionId.mainAttribute, (Atribute.Universal, 1) },
                { QuestionId.enemyPassive, (true, 1) },
                { QuestionId.heroRole, (IngameType.Killer, 1) },
                { QuestionId.missing, (MissingStaff.Mana, 1) },
                { QuestionId.stage, (GameState.Start, 1) },
                { QuestionId.canBuy, (false, 0) },
                { QuestionId.role, (new int[]{1,2,3,4,5}, 1) },
            }, "template"),
            */
        };
        public static IEnumerable<(Result res, float koef)> GetResult(Dictionary<QuestionId, Question> answers)
        {
            var ret = new List<(Result res, float koef)>();

            foreach(var r in results)
            {
                float koef = 1;
                foreach (var param in r.ValidParams)
                {
                    if (!answers.ContainsKey(param.Key))
                    {
                        continue;
                    }

                    if (answers[param.Key].PickedAnswers.Count>1)//костыль, лень править
                    {
                        if (param.Key == QuestionId.dmg)
                        {
                            StringBuilder sb = new();
                            List<int> tmp = new();
                            foreach (var a in answers[param.Key].PickedAnswers)
                            {
                                tmp.Add(a.AnswerInput.Value);
                            }
                            tmp.Add(100 - tmp[0] - tmp[1]);
                            if (tmp[0] > tmp[1] && tmp[0] > tmp[2]) { tmp[0] = 1; tmp[1] = -1; tmp[2] = -1; }
                            if (tmp[1] > tmp[0] && tmp[1] > tmp[2]) { tmp[0] = -1; tmp[1] = 1; tmp[2] = -1; }
                            if (tmp[2] > tmp[0] && tmp[2] > tmp[1]) { tmp[0] = -1; tmp[1] = -1; tmp[2] = 1; }

                            if (Enumerable.SequenceEqual(tmp, (IEnumerable<int>)r.ValidParams[param.Key].res))
                            {
                                koef *= param.Value.koef;
                            }
                            continue;
                        }
                        throw new Exception("I dont know how");
                    }
                    if (param.Key == QuestionId.role)
                    {
                        bool corr = true;
                        foreach (var a in answers[param.Key].PickedAnswers)
                        {
                            if (!((int[])param.Value.res).Contains((int)mapper(param.Key, a.AnswerText)))
                            {
                                corr = false;
                                break;
                            }
                        }
                        if (corr)
                        {
                            koef *= param.Value.koef;
                        }
                        continue;
                    }

                    if (string.Equals(mapper(param.Key, answers[param.Key].PickedAnswers[0].AnswerText), r.ValidParams[param.Key].res))
                    {
                        koef *= param.Value.koef;
                    }
                }
                ret.Add((r, koef));
            }
            return ret.OrderByDescending(x => x.koef);
        }

        private static dynamic mapper(QuestionId id, string ans)
        {
            switch (id)
            {
                case QuestionId.spammers:
                    switch (ans)
                    {
                        case "Так":
                            return true;
                        case "Ні":
                            return false;
                        default:
                            throw new Exception($"Answer {ans} not implemented");
                    }
                case QuestionId.farmState:
                    switch (ans)
                    {
                        case "Ближній бій":
                            return FarmType.Melee;
                        case "Стрілець":
                            return FarmType.Ranged;
                        case "Маг":
                            return FarmType.Magic;
                        case "Немає часу на фарм":
                            return FarmType.NoTime;
                        default:
                            throw new Exception($"Answer {ans} not implemented");
                    }
                case QuestionId.directSpells:
                    switch (ans)
                    {
                        case "Так":
                            return true;
                        case "Ні":
                            return false;
                        default:
                            throw new Exception($"Answer {ans} not implemented");
                    }
                case QuestionId.baffType:
                    switch (ans)
                    {
                        case "Урон":
                            return BaffType.Damage;
                        case "Швидкість атаки":
                            return BaffType.AtackSpeed;
                        case "Захист від направлених заклинань":
                            return BaffType.DirectSpellDef;
                        default:
                            throw new Exception($"Answer {ans} not implemented");
                    }
                case QuestionId.enemyBaffs:
                    switch (ans)
                    {
                        case "Так":
                            return true;
                        case "Ні":
                            return false;
                        default:
                            throw new Exception($"Answer {ans} not implemented");
                    }
                case QuestionId.enemyInvis:
                    switch (ans)
                    {
                        case "Так":
                            return true;
                        case "Ні":
                            return false;
                        default:
                            throw new Exception($"Answer {ans} not implemented");
                    }
                case QuestionId.supportType:
                    switch (ans)
                    {
                        case "Баф":
                            return SupportStuff.Baff;
                        case "Лікування":
                            return SupportStuff.Heal;
                        case "Ескейп":
                            return SupportStuff.Escape;
                        case "Ловити ворога":
                            return SupportStuff.Catch;
                        default:
                            throw new Exception($"Answer {ans} not implemented");
                    }
                case QuestionId.canCatch:
                    switch (ans)
                    {
                        case "Так":
                            return true;
                        case "Ні":
                            return false;
                        default:
                            throw new Exception($"Answer {ans} not implemented");
                    }
                case QuestionId.mainAttribute:
                    switch (ans)
                    {
                        case "Сила":
                            return Atribute.Strength;
                        case "Вдалість":
                            return Atribute.Agility;
                        case "Інтелект":
                            return Atribute.Intelegance;
                        default:
                            throw new Exception($"Answer {ans} not implemented");
                    }
                case QuestionId.enemyPassive:
                    switch (ans)
                    {
                        case "Так":
                            return true;
                        case "Ні":
                            return false;
                        default:
                            throw new Exception($"Answer {ans} not implemented");
                    }
                case QuestionId.heroRole:
                    switch (ans)
                    {
                        case "Вбивця":
                            return IngameType.Killer;
                        case "Стрілець":
                            return IngameType.Ranger;
                        case "Маг":
                            return IngameType.Mage;
                        case "Танк":
                            return IngameType.Tank;
                        case "Сплітпушер":
                            return IngameType.SplitPusher;
                        default:
                            throw new Exception($"Answer {ans} not implemented");
                    }
                case QuestionId.missing:
                    switch (ans)
                    {
                        case "Виживання":
                            return MissingStaff.Survive;
                        case "Урону":
                            return MissingStaff.Damage;
                        case "Мани":
                            return MissingStaff.Mana;
                        case "Підтримки команди":
                            return MissingStaff.Support;
                        case "Фарму":
                            return MissingStaff.Farm;
                        default:
                            throw new Exception($"Answer {ans} not implemented");
                    }
                case QuestionId.canDoObjective:
                    switch (ans)
                    {
                        case "Так":
                            return true;
                        case "Ні":
                            return false;
                        default:
                            throw new Exception($"Answer {ans} not implemented");
                    }
                case QuestionId.canDeffend:
                    switch (ans)
                    {
                        case "Так":
                            return true;
                        case "Ні":
                            return false;
                        default:
                            throw new Exception($"Answer {ans} not implemented");
                    }
                case QuestionId.canFight:
                    switch (ans)
                    {
                        case "Так":
                            return true;
                        case "Ні":
                            return false;
                        default:
                            throw new Exception($"Answer {ans} not implemented");
                    }
                case QuestionId.enemyPos:
                    switch (ans)
                    {
                        case "Своїй":
                            return true;
                        case "Вашій":
                            return false;
                        default:
                            throw new Exception($"Answer {ans} not implemented");
                    }
                case QuestionId.stage:
                    switch (ans)
                    {
                        case "Початок":
                            return GameState.Start;
                        case "Середина":
                            return GameState.Midgame;
                        case "Лейт":
                            return GameState.Endgame;
                        default:
                            throw new Exception($"Answer {ans} not implemented");
                    }
                case QuestionId.carrySave:
                    switch (ans)
                    {
                        case "Так":
                            return true;
                        case "Ні":
                            return false;
                        default:
                            throw new Exception($"Answer {ans} not implemented");
                    }
                case QuestionId.enemyOnVision:
                    switch (ans)
                    {
                        case "Так":
                            return true;
                        case "Ні":
                            return false;
                        default:
                            throw new Exception($"Answer {ans} not implemented");
                    }
                case QuestionId.canBuy:
                    switch (ans)
                    {
                        case "Так":
                            return true;
                        case "Ні":
                            return false;
                        default:
                            throw new Exception($"Answer {ans} not implemented");
                    }
                case QuestionId.role:
                    switch (ans)
                    {
                        case "1":
                            return 1;
                        case "2":
                            return 2;
                        case "3":
                            return 3;
                        case "4":
                            return 4;
                        case "5":
                            return 5;
                        default:
                            throw new Exception($"Answer {ans} not implemented");
                    }
                default:
                    throw new Exception("This id not implemented");
            }
        }
    }

    public enum IngameType { Mage, Killer, SplitPusher, Ranger, Tank };
    public enum GameState { Start, Midgame, Endgame };
    public enum MissingStaff { Survive, Damage, Mana, Support, Farm };
    public enum SupportStuff { Baff, Heal, Escape, Catch };
    public enum Atribute { Intelegance, Strength, Agility, Universal };
    public enum BaffType { Damage, AtackSpeed, DirectSpellDef };
    public enum FarmType { Magic, Melee, Ranged, NoTime };
    internal class Result
    {
        public Dictionary<QuestionId, (dynamic res, float koef)> ValidParams;
        public string Text;
        public string? PhotoPath;
        public Result(Dictionary<QuestionId, (dynamic res, float koef)> values, string text, string? photoPath = null)
        {
            ValidParams = values;
            Text = text;
            PhotoPath = photoPath;
        }
    }
}