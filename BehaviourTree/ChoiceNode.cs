using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceNode : CompositeNode
{
    public string Title;
    protected override void OnStart()
    {
    }

    protected override void OnStop()
    {
    }

    protected override State OnUpdate()
    {
        return State.Success;
    }
}
