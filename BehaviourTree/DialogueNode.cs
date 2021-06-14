using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueNode : CompositeNode
{
    [TextArea()]
    public string Text;
    [Space()]
    public Character Character;
    public float duration;
    public string Sequence;

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
