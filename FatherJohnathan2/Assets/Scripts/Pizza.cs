using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Opsive.UltimateCharacterController.Traits;

public class Pizza : MonoBehaviour, IInteractableTarget
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Can the target be interacted with?
    /// </summary>
    /// <param name="character">The character that wants to interactact with the target.</param>
    /// <returns>True if the target can be interacted with.</returns>
    public bool CanInteract(GameObject character)
    {
        return true;
    }

    /// <summary>
    /// Interact with the target.
    /// </summary>
    /// <param name="character">The character that wants to interactact with the target.</param>
    public void Interact(GameObject character)
    {
        // play pizza pick up event
    }
}
