using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    //pegando meu material
    private Renderer meuFundo;


    //posicao do meu x offset
    private float xOffset = 0f;

    //posicao da minha textura
    private Vector2 texturaOffset;


    //Velocidade do fundo
    [SerializeField] private float velocidade = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        //pegando meu fundo
        meuFundo = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

        //diminuindo o valor do meu xOffset
        xOffset += Time.deltaTime * velocidade;

        //passando o xOffset para o eixo X da minha textura
        texturaOffset.x = xOffset;

        //movndo o offset x do meu renderer
        meuFundo.material.mainTextureOffset = texturaOffset;

    }
}
