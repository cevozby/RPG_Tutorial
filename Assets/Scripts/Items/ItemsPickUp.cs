using UnityEngine;

public class ItemsPickUp : Interactable
{
    public Item item;

    public override void Interact()
    {
        base.Interact();

        PickUp();
    }

    void PickUp()
    {
        Debug.Log("Picking up: " + item.name);
        // Add to Inventory
        bool wasPickedUp =  Inventory.instance.Add(item);
        if (wasPickedUp)
        {
            Destroy(gameObject);
        }
        
    }



}
