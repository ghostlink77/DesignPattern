using UnityEngine;

public class Instanciate : MonoBehaviour
{
    public GameObject SingletonPrefab;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject instance = Instantiate(SingletonPrefab);
        }
    }
}
