using UnityEngine;

public class DestroyableCell : MonoBehaviour
{
    void OnMouseDown()
    {
        // gameObject.SetActive(false);
        Destroy(gameObject);
    }
}