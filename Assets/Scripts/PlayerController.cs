using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{


    [SerializeField] private float velocidade = 5f;

    [SerializeField] private GameObject puf;

    
    //pegando informacoes do player
    //criando nossas variáveis
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //subindo ao apertar espaço
        Subir();

        //limitando velocidade de queda
        Descer();

        //resetando se sair da tela
        SeSairDaTela();
    }

    private void Descer()
    {
        if (rb.velocity.y < -velocidade)
        {
            //travando rb.velocity.y em -5
            rb.velocity = Vector2.down * velocidade;
        }
    }

    //criando metodo subir
    public void Subir()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //fazendo a velocidade do RB ir pra cia
            rb.velocity = Vector2.up * velocidade;

            //criando p puf
            //salvando a instancia dentro de uma variavel
            GameObject meuPuf = Instantiate(puf, transform.position, Quaternion.identity);

            //destruindo meu puff
            Destroy(meuPuf, 1.05f);
        }
    }

    //quando sair da tela
    private void SeSairDaTela()
    {
        if (transform.position.y > 4.8f || transform.position.y < -4.8f)
        {
            SceneManager.LoadScene(0);
        }
    }

    //configurar a colisão do player
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //usando o scenemanager para recarregar a cena
        SceneManager.LoadScene(0);
    }

}
