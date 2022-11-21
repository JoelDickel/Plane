using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Programando : MonoBehaviour
{
    public int numero = 1;
    public int numerMes = 1;
    public string[] meses;

    public int taboada;

    // Start is called before the first frame update
    void Start()
    {
        int n = 0;

        //while
        while(n < meses.Length)
        {
            //escrevendo o mes
            Debug.Log(meses[n]);
          
            //aumentando valor do N
            n++;
        }



        //fazendo o switch
        //1 = bom dia 2 = boa tarde e 3 = beber
       /* switch (numero)
        {
            //meu primeiro caso
            case 1:
                Debug.Log("Bom Dia");
                break;
            case 2:
                Debug.Log("Churrasco!");
                break;
            case 3:
                Debug.Log("Beber!!");
                break;
        }*/

      /*  while (taboada < 11)
        {
            Debug.Log($"taboada de 2 * {taboada} = {taboada * 2}");
            taboada++;
        }*/

        Debug.Log("entendeu?");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
