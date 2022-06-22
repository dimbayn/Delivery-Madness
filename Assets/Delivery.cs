using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    [SerializeField] Color32 hasPackageColor = new Color32 (255, 245, 0, 255);
    [SerializeField] Color32 noPackageColor = new Color32 (255, 255, 255, 255);

    [SerializeField] float destroyDelay = 0.25f;
    bool isPackagePickedUp = false;

    SpriteRenderer spriteRenderer;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Hell is coming ...");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // if the trigger is package then print "package picked up"
        if (other.tag == "Package" && !isPackagePickedUp)
        {
            Debug.Log("Package picked up");
            spriteRenderer.color = hasPackageColor;
            isPackagePickedUp = true;
            Destroy(other.gameObject, destroyDelay);
        }

        if (other.tag == "Customer" && isPackagePickedUp)
        {
            Debug.Log("Package delivered");
            spriteRenderer.color = noPackageColor;
            isPackagePickedUp = false;
        }
    }
}
