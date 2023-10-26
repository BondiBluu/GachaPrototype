using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum UnitStarRarity
{
    THREE,
    FOUR,
    FIVE
}

public enum UnitElement
{
    FIRE,
    WATER,
    EARTH,
    WIND,
    LIGHT,
    DARK,
}

public enum UnitType
{
    ATTACK,
    TANK,
    BALANCE,
    HEALING,
    MAGIC
}

[CreateAssetMenu(fileName = "New Unit", menuName = "Characters/Unit")]

public class UnitManager : ScriptableObject
{
    [SerializeField] string unitName;
    [SerializeField] int unitLevel = 1;
    [SerializeField] int unitMaxLevel;
    [SerializeField] int unitAtk;
    [SerializeField] int unitDef;
    [SerializeField] int unitHp;
    [SerializeField] int unitSpd;
    [SerializeField] UnitElement element;
    [SerializeField] UnitStarRarity starRarity;
    [SerializeField] UnitType type;
    [SerializeField] Sprite characterArt;

    public string UnitName
{
    get { return unitName; }
    set { unitName = value; }
}

public int UnitLevel
{
    get { return unitLevel; }
    set { unitLevel = value; }
}

public int UnitMaxLevel
{
    get { return unitMaxLevel; }
    set { unitMaxLevel = value; }
}

public int UnitAtk
{
    get { return unitAtk; }
    set { unitAtk = value; }
}

public int UnitDef
{
    get { return unitDef; }
    set { unitDef = value; }
}

public int UnitHp
{
    get { return unitHp; }
    set { unitHp = value; }
}

public int UnitSpd
{
    get { return unitSpd; }
    set { unitSpd = value; }
}

public UnitElement Element
{
    get { return element; }
    set { element = value; }
}

public UnitStarRarity StarRarity
{
    get { return starRarity; }
    set { starRarity = value; }
}

public UnitType Type
{
    get { return type; }
    set { type = value; }
}

public Sprite CharacterArt
{
    get { return characterArt; }
    set { characterArt = value; }

}
}