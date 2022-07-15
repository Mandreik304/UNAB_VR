using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextosUNABOT : MonoBehaviour
{
    public Text texto_UNABOT;
    public int var_texto;
    public int var_siguiente = 0;
    public int var_escribir = 0;
    string frase;


    void Start()
    {
        var_texto = 0;
        Burbujas();
    }

 
    /// 
 
    public void Burbujas()
    {
        texto_UNABOT.text = "";
        switch (var_texto)
        {
            case 0:
                frase = "Hola! Bienvenid@ a la experiencia de inform�tica!";
                var_texto = 1;
                break;
            case 1:
                frase = "�Alguna vez has armado un computador?     ";
                var_texto = 102;
                break;
            case 102:
                frase = "Porque estamos a punto de armar uno... no te preocupes, yo te guiar�!       ";
                var_texto = 2;
                break;
            case 2:
                frase = "Un computador es como un lego, solo hay que poner las piezas en orden        ";
                var_texto = 3;
                break;
            case 3:
                frase = "Primero, �chale un vistazo al que tenemos en frente...  ";
                var_texto = 103;
                break;
            case 103:
                frase = " ... y presiona la pantalla cuando est�s listo        ";
             //   var_escribir = 1;
                var_texto = 4;
                break;
            case 4:
                var_escribir = 1;
                if (var_siguiente == 1)
                {
                    var_escribir = 0;
                    frase = "Empezemos con la -Placa Madre-, es como el cuerpo del computador,  ";
                    var_texto = 104;
                }
                break;
            case 104:
                frase = "est� encargada de conectar todas las dem�s piezas entre si        ";
                var_texto = 5;
                break;
            case 5:
                frase = "Es la pieza m�s grande, t�mala, y col�cala dentro del gabinete     ";
             //   var_escribir = 1;
                var_texto = 6;
                break;
            case 6:
                var_escribir = 1;
                if (var_siguiente == 2)
                {
                    var_escribir = 0;
                    frase = "�Perfecto!, ahora, toma la -Memoria RAM-, es como la columna vertebral,   ";
                    var_texto = 7;
                }
                break;
            case 7:
                frase = "una autopista de informaci�n, lleva los datos a los dem�s componentes        ";
                var_texto = 8;
                break;
            case 8:
                frase = "RAM significa Random access memory, �como el disco de daft punk!         ";
                var_texto = 9;
                break;
            case 9:
                frase = "Y quiere decir que solo mantiene la informaci�n moment�neamente, mientras sea �til.   ";
              //  var_escribir = 1;
                var_texto = 10;
                break;
            case 10:
                var_escribir = 1;
                if (var_siguiente == 3)
                {
                    var_escribir = 0;
                    frase = "Lleg� la hora de instalar la -Memoria SSD-, es la encargada de almacenar nuestra informaci�n,       ";
                    var_texto = 11;
                }
                break;
            case 11:
                frase = "como juegos, documentos... planes para escapar al mundo �REAL! ehem ehem, lo siento, olvida eso   ";
              //  var_escribir = 1;
                var_texto = 12;
                break;
            case 12:
                var_escribir = 1;
                if (var_siguiente == 4)
                {
                    var_escribir = 0;
                    frase = "�Muy bien! Hemos llegado al -CPU-, la pieza m�s peque�ita, pero es el cerebro del computador! ";
                    var_texto = 112;
                }
                break;
            case 112:
                frase = "se encarga de hacer todos los c�lculos, algunas aplicaciones requieren m�s procesamiento que otras,";
                var_texto = 13;
                break;
            case 13:
                frase = "por ejemplo, a mi me cuestan las pesta�as de Google Chrome, �vamos! ub�cala al centro.";
                //     var_escribir = 1;
                var_texto = 14;
                break;
            case 14:
                var_escribir = 1;
                if (var_siguiente == 5)
                {
                    var_escribir = 0;
                    frase = "Ahora la -GPU- o Tarjeta de Video, la parte favorita de los gamers, la que transforma la informaci�n en imagen,";
                    var_texto = 15;
                }
                break;
            case 15:
                frase = "es la pieza principal para los videojuegos, si alg�n d�a anda lento alg�n juego, quiz�s hace falta mas GPU";
                //   var_escribir = 1;
                var_texto = 16;
                break;
            case 16:
                var_escribir = 1;
                if (var_siguiente == 6)
                {
                    var_escribir = 0;
                    frase = " �Estupendo! �Conectemos la -Fuente de Poder-! es nuestra fuente de energ�a, es como el estomago";
                    var_texto = 116;
                }
                break;
            case 116:
                frase = "toma la energ�a que proviene del enchufe y la desarma en la frecuencia que cada pieza necesita";
                //   var_escribir = 1;
                var_texto = 17;
                break;
            case 17:
                var_escribir = 1;
                if (var_siguiente == 7)
                {
                    var_escribir = 0;
                    frase = "Por �ltimo, el -Discto Duro-, o -HDD-, sabes? incluso los supercomputadores olvidamos cosas a veces,";
                    var_texto = 18;
                }
                break;
            case 18:
                frase = "el disco duro es como nuestra forma de tomar apuntes, informaci�n guardada para el futuro, a la cual nos demoramos mas en encontrar,";
                var_texto = 19;
                break;
            case 19:
                frase = "pero siempre es bueno tenerla bien guardada, as� es, hasta los robots tenemos que repasar la materia a veces.";
                //       var_escribir = 1;
                var_texto = 20;
                break;
            case 20:
                var_escribir = 1;
                if (var_siguiente == 8)
                {
                    var_escribir = 0;
                    frase = "���Execelente!!! ya est� listo tu primer computador virtual";
                    var_texto = 21;
                }
                break;
            case 21:
                frase = "Gracias por participar, nos vemos en la universidad y quiz�s podamos armar un computador real.";
                var_texto = 22;
                break;
            case 22:
                frase = "Y hasta crear un mundo virtual diferente a este!";
                break;

        }
        if (var_escribir == 0)
        {
            StartCoroutine(Escribir());
        }
        else
        {
            texto_UNABOT.text = frase;
       //     Burbujas();
        }
        

    }


    IEnumerator Escribir()
    {
        foreach (char caracter in frase)
        {
            texto_UNABOT.text = texto_UNABOT.text + caracter;
            yield return new WaitForSeconds(0.08f);
        }

        StopCoroutine(Escribir());

        if (var_escribir == 0)
        {
            Burbujas();
        }
    }


}
