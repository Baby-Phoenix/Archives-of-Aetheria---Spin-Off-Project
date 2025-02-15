using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "A.I/Enemy Actions/Attack Action")]
public class EnemyAttackAction : EnemyAction
{
    public int attackScore = 3;
    public float recoveryTime = 2;
    public bool isAbleToRotate = false;

    public float maximumAttackAngle = 35;
    public float minimumAttackAngle = -35;

    public float minimumDistanceNeededToAttack = 0;
    public float maximumDistanceNeededToAttack = 3;
}
