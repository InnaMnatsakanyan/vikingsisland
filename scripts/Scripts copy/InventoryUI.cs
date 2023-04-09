using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI healthNumber;
    // Start is called before the first frame update
    void Start()
    {
        healthNumber = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateNumber(Inventory inventory)
    {
        healthNumber.text = inventory.heartsCollectedAmount.ToString();        
    }
}
