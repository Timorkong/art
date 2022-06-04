using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NodeCanvas;
using NodeCanvas.BehaviourTrees;

public class NewBehaviourScript : MonoBehaviour
{
    BehaviourTreeOwner behaviourTreeOwner;

    public bool bUpdat = false;

    // Start is called before the first frame update
    void Start()
    {
        behaviourTreeOwner = gameObject.GetComponent<BehaviourTreeOwner>();

        behaviourTreeOwner.updateMode = NodeCanvas.Framework.Graph.UpdateMode.Manual;
    }

    // Update is called once per frame
    void Update()
    {
        if (bUpdat)
        {
            this.behaviourTreeOwner.UpdateBehaviour();
        }
    }
}
