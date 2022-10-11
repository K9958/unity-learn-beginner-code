using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class MyWeaponAttackEffect : Weapon.WeaponAttackEffect
{
    public int healthChange;
    public override void OnAttack(CharacterData target, CharacterData user, ref Weapon.AttackData attackData)
    {
        
    }
    
    public override void OnPostAttack(CharacterData target, CharacterData user, Weapon.AttackData data)
    {
        user.Stats.ChangeHealth(healthChange);
    }
}
