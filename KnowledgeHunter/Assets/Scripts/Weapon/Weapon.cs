using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon
{
    WeaponBase _base;
    int level;

    public int HP {get; set;}

    public List<Move> Moves {get; set;}

    public Weapon(WeaponBase pBase, int pLevel){
        _base = pBase;
        level = pLevel;
        HP = _base.MaxHp;

        Moves = new List<Move>();
        foreach(var move in _base.LearnableMoves){
            if(move.level <= level)
                Moves.Add(new Move(move.moveBase));
            
            if(Moves.Count >= 4)
                break;
        }
    }

    public int Attack {
        get{return Mathf.FloorToInt((_base.Attack * level) /100f) + 5;}
    }    

    public int MaxHp {
        get{return Mathf.FloorToInt((_base.MaxHp * level) /100f) + 5;}
    }

    public int Defense {
        get{return Mathf.FloorToInt((_base.Defense * level) /100f) + 5;}
    }

    public int MagicAtt {
        get{return Mathf.FloorToInt((_base.MagicAtt * level) /100f) + 5;}
    }

    public int MagicDef {
        get{return Mathf.FloorToInt((_base.MagicDef * level) /100f) + 5;}
    } 
    
    public int Speed {
        get{return Mathf.FloorToInt((_base.Speed * level) /100f) + 5;}
    }   
}
