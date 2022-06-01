using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlataforma : MonoBehaviour
{
    public List<GameObject> plataformas = new List<GameObject>();
    public int distancia;

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < plataformas.Count; i++)
        {
           Instantiate(plataformas[i], new Vector3(0,0, i * 86), transform.rotation);
            distancia += 86;
        }

        InvokeRepeating("Recicle", 15f, 30f);

    }

    public void Recicle()
    {

        for (int i = 0; i < plataformas.Count; i++)
        { 
            Instantiate(plataformas[i], new Vector3(0, 0, distancia), transform.rotation);
            plataformas[i].transform.position = new Vector3(0, 0, distancia);
            distancia += 86;
        }

    }


}
