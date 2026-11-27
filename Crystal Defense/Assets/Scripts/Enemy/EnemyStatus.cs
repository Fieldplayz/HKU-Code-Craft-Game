using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatus : MonoBehaviour
{
    private StatusSO activeStatus;
    private float activeStatusTimer;

    private void Update()
    {
        if (activeStatus != null)
        {
            if (activeStatusTimer > 0)
            {
                activeStatusTimer -= Time.deltaTime;
            }
            else
            {
                activeStatus = null;
                activeStatusTimer = 0;
            }
        }
        
    }

    public void SetStatusEffect(StatusSO status)
    {
        activeStatus = status;
        activeStatusTimer = activeStatus.StatusTimer;
    }
}
