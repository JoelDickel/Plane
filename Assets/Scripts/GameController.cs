
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    //timer
    [SerializeField] private float timer = 1f;

    //Meu obstáculo
    [SerializeField] private GameObject obstaculo;

    //posicao para criar obstáculo
    [SerializeField] private Vector3 posicao;

    //posicao min e max
    [SerializeField] private float posMin = -0.3f;
    [SerializeField] private float posMax = 2.4f;

    //timer random
    [SerializeField] private float timerMin = 1f;
    [SerializeField] private float timerMax = 3f;

    //variavel dos pontos
    private float pontos = 0f;

    //variavel dos pontos canvas
    [SerializeField] private Text pontosTexto;

    //variavel do lvl
    private int level = 1;
    [SerializeField] private Text levelTexto;

    //variavel para ganahr lvl
    [SerializeField] private float proximoLevel = 10f;

    //Variaveis do som
    [SerializeField] private AudioClip levelUp;

    //Variavel com a posicao da camera
    private Vector3 camPos;

    // Start is called before the first frame update
    void Start()
    {
        //pegando a posicao da camera
        camPos = Camera.main.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        //ganhando pontos
        Pontos();


        //dando oi a cada segundo
        CriaObstaculo();

        //ganhando lvl 
        GanhaLevel();
    }

    private void Pontos()
    {
        pontos += Time.deltaTime * level;

        //passando os pontos para o meu texto de pontos
        pontosTexto.text = Mathf.Round(pontos).ToString();
        
        
    }

    private void GanhaLevel()
    {

        //passando lvl para o texto do lvl
        levelTexto.text = level.ToString();

        //SE os pontos forem maiores do que o próximo level, então eu aumento o valor do lvl eu dobro a quantidade de pontos
        //para o próximo lvl
        if(pontos > proximoLevel)
        {
            //aumentando o lvl em 1  
            level++;
            //dobrando o valor do próximo lvl
            proximoLevel *= 2;
            //tocando som
            AudioSource.PlayClipAtPoint(levelUp, camPos);

           
        }
    }

    private void CriaObstaculo()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            //Debug.Log("oi");

            posicao.y = Random.Range(posMin, posMax);

            //criando obstáculo
            Instantiate(obstaculo, posicao, Quaternion.identity);


            timer = Random.Range(timerMin/level, timerMax);

        }
    }

    //criando um metodo para retornar o lvl
    public int RetornaLevel()
    {
        return level;
    }
}
