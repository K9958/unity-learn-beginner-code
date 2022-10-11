using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class AddSpeedEffect : UsableItem.UsageEffect
{
    public float Duration = 10.0f;
    public int DefenceChange = 50;
    public Sprite EffectSprite;

    public override bool Use(CharacterData user)
    {
        StatSystem.StatModifier modifier = new StatSystem.StatModifier();
        modifier.ModifierMode = StatSystem.StatModifier.Mode.Percentage;
        modifier.Stats.strength = DefenceChange;

        VFXManager.PlayVFX(VFXType.Healing, user.transform.position);

        user.Stats.AddTimedModifier(modifier, Duration, "DefenceAdd", EffectSprite);

        return true;
    }
}
