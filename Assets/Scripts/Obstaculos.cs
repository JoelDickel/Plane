using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    [SerializeField] private float velocidade = 4f;
    // Start is called before the first frame update
    [SerializeField] private GameObject eu;

    //criando a variavel  do game controller
    [SerializeField] private GameController game;
    void Start()
    {
        Destroy(eu, 5f);

        //encontrando o gamer controller da cena atual
        game = FindObjectOfType<GameController>();

        
    }

    // Update is called once per frame
    void Update()
    {
        //indo para a esquerda
        //transform.position = transform.position + Vector3.left;
        transform.position += Vector3.left * Time.deltaTime * velocidade;

        //minha velocidade vai ser 4f + level
        velocidade = 4f + game.RetornaLevel();
    }
}
