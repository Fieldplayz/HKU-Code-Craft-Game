using UnityEngine;

[CreateAssetMenu(menuName = "My Assets/Status Effect")]
public class StatusSO : ScriptableObject
{
    public float statusEffectTimer = 4f;
    public float damage = 0;
    public float damageTimer = 0;

    public float decreaseMoveSpeed = 0;

}
