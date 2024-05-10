using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class SimpleConditionNear : SimpleCondition
{
    //TODO visible
    //[SerializeField]
    //bool visible = false;
    //[SerializeField]
    //GameObject sphere;
    [SerializeField]
    Transform self;
    [SerializeField]
    Transform target;
    [SerializeField]
    float nearDistance;

    protected override bool FuncCondition()
    {
        if (self.tag.CompareTo("Player") == 0 || target.tag.CompareTo("Player") == 0)
        {
            if(PlayerStateController.Instance.IsBusy())
                return false;
        }
        return (self.position - target.position).magnitude <= nearDistance;
    }

}
