using System;
using UnityEngine;

public class RoomTrigger : MonoBehaviour
{
    public event Action Entered;
    public event Action Left;

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.TryGetComponent(out Enemy enemy))
        {
            Entered.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D collider2D)
    {
        if (collider2D.TryGetComponent(out Enemy enemy))
        {
            Left.Invoke();
        }
    }
}
