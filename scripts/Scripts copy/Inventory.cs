using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Inventory : MonoBehaviour
{
    public int heartsCollectedAmount {get; private set;}
    public UnityEvent<Inventory> OnHeartCollected;

    public void heartsCollected () {
        heartsCollectedAmount++;
        OnHeartCollected.Invoke(this);
    }
}
