using UnityEngine;

public class Singleton : MonoBehaviour
{
    private static Singleton instance;

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                SetupInstance();
            }
            return instance;
        }
    }

    private static void SetupInstance()
    {
        instance = FindAnyObjectByType<Singleton>();
        if (instance == null)
        {
            GameObject singletonObject = new GameObject();
            instance = singletonObject.AddComponent<Singleton>();
            singletonObject.name = "Singleton";
            DontDestroyOnLoad(singletonObject);
        }
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            Debug.Log("Already exsist other Singleton Object");
        }
    }
}
