using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Weapon", menuName = "Weapon/Create new weapon")]

public class WeaponBase : ScriptableObject
{
   [SerializeField] string name;

   [TextArea]
   [SerializeField] string description;

   [SerializeField] Sprite frontSprite;
   [SerializeField] Sprite backSprite;
   
   [SerializeField] WeaponType type1;
   [SerializeField] WeaponType type2;

    //Base Stats
    [SerializeField] int maxHp;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int magicAtt;
    [SerializeField] int magicDef;
    [SerializeField] int speed;

    [SerializeField] List<LearnableMove> learnableMoves;

    public string Name {
        get{ return name; }
    }
    public string Description {
        get{ return description; }
    }

    public Sprite FrontSprite {
        get{ return frontSprite; }
    }
    public Sprite BackSprite {
        get{ return backSprite; }
    }
    public WeaponType Type1 {
        get{ return type1; }
    }
    public WeaponType Type2 {
        get{ return type2; }
    }

    public int MaxHp {
        get{ return maxHp; }
    }
    public int Attack {
        get{ return attack; }
    }
    public int Defense {
        get{ return defense; }
    }
    public int MagicAtt {
        get{ return magicAtt; }
    }
    public int MagicDef {
        get{ return magicDef; }
    }
    public int Speed {
        get{ return speed; }
    }

    public List<LearnableMove> LearnableMoves{
        get{return learnableMoves;}
    }
}

[System.Serializable]
public class LearnableMove{
    [SerializeField] public MoveBase moveBase;
    [SerializeField] public int level;
}

public enum WeaponType
{
 None,
 Fire, 
 Water,
 Electric,
 Ice,
 Poison,
 Psychic,
 Nature,
 Rock,
 Steel,
 Wood,
 Mystic,
}