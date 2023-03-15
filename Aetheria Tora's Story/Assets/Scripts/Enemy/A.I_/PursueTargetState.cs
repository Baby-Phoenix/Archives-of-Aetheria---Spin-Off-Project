using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PursueTargetState : State
{
    public override State Tick(EnemyManager enemyManager, EnemyStats enemyStats, EnemyAnimatorManager enemyAnimatorManager)
    {
        //Chase the target
        //If withic attack range, return combat stance state
        //if target is out of range, return this state and continue to chase target
        return this;
    }
}