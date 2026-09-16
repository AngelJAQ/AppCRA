using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARObjectSpawner : MonoBehaviour
{
    public GameObject prefab;
    public ARSession session;

    void Update()
    {
        if (session != null && session.enabled)
        {
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Vector3 spawnPos = Camera.main.transform.position + Camera.main.transform.forward * 0.5f;
                Instantiate(prefab, spawnPos, Quaternion.identity);
            }
        }
    }
}
