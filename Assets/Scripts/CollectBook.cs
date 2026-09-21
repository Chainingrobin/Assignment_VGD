using UnityEngine;

public class BookCollect : MonoBehaviour
{
    //[SerializeField] AudioSource: 

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
