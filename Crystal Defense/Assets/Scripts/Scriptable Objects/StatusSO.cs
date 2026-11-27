using UnityEngine;

[CreateAssetMenu(menuName = "SO/Status")]
public class StatusSO : ScriptableObject
{
    public float StatusTimer;
    public Color StatusColor;
    public float Damage;
    public float DamageTimer;
    [Range(0f, 1f)]
    public float DecreaseMovementSpeed;
    [Tooltip("Range of 0 to 1 what percent chance it has of activating the status effect")]
    public float statusEffectChance;
    

}
