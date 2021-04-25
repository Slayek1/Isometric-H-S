using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFollow : MonoBehaviour
{
    public GameObject ball;
    Vector3 offset;//odleglosc od pilki
    public float lerpRate;//smooth
    bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        offset = ball.transform.position - transform.position;
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            Follow();
        }
    }

    void Follow()
    {
        Vector3 pos = transform.position;
        Vector3 targetPos = ball.transform.position - offset;//pozycja do ktorej kamera ma sie udac
        pos=Vector3.Lerp(pos, targetPos, lerpRate * Time.deltaTime);//pozycji nie mozna zmieniac bezposrednio stad przypisanie do zmiennej "pos"
        transform.position = pos;
    }
}
