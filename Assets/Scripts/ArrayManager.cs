using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayManager : MonoBehaviour
{

    [SerializeField] GameObject[] objectsCollection;
    [SerializeField] int randomNumber;
    [SerializeField] Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        objectsCollection = GameObject.FindGameObjectsWithTag("ObjetoLab");
        AgregarColliderAElementosDelArray();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            PosicionarElementosDelArray();
            GenerarNumeroAlAzar();
        }

        if (Input.GetKey(KeyCode.O))
        {
            InstanciarObjectoAlAzarDelArray();
        }

    }

    void DestruirElementosDelArray()
    {
        for (int i = 0; i < objectsCollection.Length; i++)
        {
            Destroy(objectsCollection[i]);
        }
    }

    void PosicionarElementosDelArray()
    {
        for (int i = 0; i < objectsCollection.Length; i++)
        {
            objectsCollection[i].transform.position = new Vector3(-2.111369f, 2.42f + i, -2);
        }
    }

    void AgregarColliderAElementosDelArray()
    {
        for (int i = 0; i < objectsCollection.Length; i++)
        {
            objectsCollection[i].AddComponent<BoxCollider>();
        }
    }

    void GenerarNumeroAlAzar()
    {
        randomNumber = Random.Range(0,11);
    }

    void InstanciarObjectoAlAzarDelArray()
    {
        Instantiate(objectsCollection[Random.Range(0, objectsCollection.Length)], spawnPoint.position,Quaternion.identity);
    }
}
