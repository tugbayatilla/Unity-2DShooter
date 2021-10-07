using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyedCondition : GameWinLooseCondition
{
    // Start is called before the first frame update
    public GameObject target;

    //The object of type 'GameObject' has been destroyed but you are still trying to access it
    private string targetName;

    private void Start()
    {
        targetName = target.name;
    }

    public override bool CheckCondition()
    {
        return target == null;
    }

}
