using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : Shooting
{
    public override bool ShootCondition()
    {
        return Input.GetKeyDown(KeyCode.Space);
    }
}
