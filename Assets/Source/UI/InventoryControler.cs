using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryControler : MonoBehaviour
{
    [SerializeField]
    private UIInventory inventoryUI;

    public int inventorySize = 10;

    private void Start()
    {
        inventoryUI.InitializeInventoryUI(inventorySize);
    }


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (inventoryUI.isActiveAndEnabled == false)
            {
                inventoryUI.Show();
            }
            else
            {
                inventoryUI.Hide();
            }
        }
    }
}
