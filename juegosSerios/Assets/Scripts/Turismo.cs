using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Turismo : MonoBehaviour
{
    [SerializeField] private TMP_Text _titulo;
    [SerializeField] private TMP_Text _explicacion;
    // Start is called before the first frame update
    void Start()
    {
        _titulo.gameObject.SetActive(true);
        _explicacion.gameObject.SetActive(false);   
        _titulo.text = GameManager.instance.DondeTurismo;
    }

   public void cordobaCuandoIr()
    {
        if (_titulo.text == "CORDOBA")
        {
            _explicacion.gameObject.SetActive(true);
            _explicacion.text = "Es recomendable ir a principios de primavera \n o finales de oto�o para tener las mejores temperaturas. \n si se visita en la segunda o tercera semana de mayo coincidira con \n el conscuros de los patios cordobeses";

        }
        else if(_titulo.text =="CADIZ")
        {
            _explicacion.gameObject.SetActive(true);
            _explicacion.text = "La mejor �poca para visitar C�diz suele ser durante la primavera (de marzo a junio) \n" +
                " y el oto�o (de septiembre a noviembre), cuando las temperaturas son suaves y agradables. \n" +
                "Evita los meses m�s calurosos del verano, especialmente julio y agosto,\n" +
                " si no toleras bien el calor intenso Es recomendable ir en primavera o verano \n " +
                "o finales de oto�o para tener las mejores temperaturas. \n ";

        }

    }
   
    public void cordobaTransporte()
    {
        if(_titulo.text == "CORDOBA")
        {
            _explicacion.gameObject.SetActive(true);
            _explicacion.text = "En cordoba lo recomendable es ir andando a todos los sitios ya que se encuentran vastante cerca. Si se prefiere tambien se cuenta con una red de autobuses. Sin embarco por el centro de la ciudad no pasan.";
        }
        else if (_titulo.text == "CADIZ")
        {
            _explicacion.gameObject.SetActive(true);
            _explicacion.text = "En C�diz, puedes moverte f�cilmente mediante autobuses urbanos,\n" +
                " taxis, alquiler de bicicletas o a pie, especialmente en el compacto centro hist�rico.\n" +
                " Para explorar �reas m�s remotas, considera el alquiler de coches, y aprovecha las conexiones \n" +
                "mar�timas para viajar por la costa.";
        }

    }
    public void cordobaquever()
    {
        if (_titulo.text == "CORDOBA")
        {
            _explicacion.gameObject.SetActive(true);
            _explicacion.text = "Mezquita catedral  \n Juderia  \n Jardices del alcazar  \n medina azahara  \n palacio de viana  \n centro historico  \n patios cordobeses  \n templo romano  \n cristo de los faroles  \n puente romano ";
        }
        else if (_titulo.text == "CADIZ")
        {
            _explicacion.gameObject.SetActive(true);
            _explicacion.text = "En C�diz, disfruta del encanto de su centro hist�rico con la Catedral \n" +
                "y la Torre Tavira, explora las playas como La Victoria,\n" +
                " y sum�rgete en la rica historia naval en el Museo Naval \n" +
                "y la base naval de la ciudad.";
        }

    }
    public void cordobacuantoir()
    {

        if(_titulo.text == "CORDOBA")
        {
            _explicacion.gameObject.SetActive(true);
            _explicacion.text = "Cordoba, aunque tiene muchas cosa sque ver es un lugar perfecto para ir en cualquier momento. \n Dependiendo de cuanto tiempo quieras dedicar a ver cada cosa. Cordoba se puede ver \n entre tres y cinco dias.";
        }
        else if (_titulo.text == "CADIZ")
        {
            _explicacion.gameObject.SetActive(true);
            _explicacion.text = "En C�diz, disfruta del encanto de su centro hist�rico con la Catedral \n" +
                "y la Torre Tavira, explora las playas como La Victoria,\n" +
                " y sum�rgete en la rica historia naval en el Museo Naval \n" +
                "y la base naval de la ciudad.";
         }

    }
    public void cordobadondecomer()
    {
        if (_titulo.text == "CORDOBA")
        {
            _explicacion.gameObject.SetActive(true);
            _explicacion.text = "Hay muchos sitios para ir a comer. Se caracteriza por las tapas. \n las tapas son peque�as porciones de comida que viene con la bebida. \n Alguno de los mejores sitios para comer en cordoba son: \n Casa Pepe de la juderia \n El numero 10 \n Bar Santos \n Taberna bonfo� \n Casa del pisto";
        }
        else if (_titulo.text == "CADIZ")
        {
            _explicacion.gameObject.SetActive(true);
            _explicacion.text = "C�diz, conocida por su rica tradici�n culinaria,\n" +
                " ofrece delicias marinas en lugares como la Plaza de la Catedral \n" +
                "y el Mercado Central, donde se pueden disfrutar de pescados frescos y platos t�picos andaluces.\n" +
                " Recomendaciones incluyen probar la cazuela de chocos o \n" +
                "las tapas en la hist�rica Taberna El T�o de la Tiza";
         }

    }
    public void cordobaclima()
    {

        if(_titulo.text == "CORDOBA")
        {
            _explicacion.gameObject.SetActive(true);
            _explicacion.text = " Cordoba se distingue por su clima mediterr�neo.\n Los veranos son muy calurosos, con temperaturas que suelen superar los 35C.\n Durante los inviernos el clima es m�s frio, con temperaturas entorno los 9-20C.\n En primavera y oto�o, C�rdoba tiene temperaturas moderadas, lo que es ideal para recorrer sus calles. ";
        }
        else if (_titulo.text == "CADIZ")
        {
            _explicacion.gameObject.SetActive(true);
            _explicacion.text = "C�diz tiene un clima mediterr�neo subtropical,\n" +
                " caracterizado por inviernos suaves y veranos c�lidos.\n" +
                " Las temperaturas oscilan entre los 10�C en invierno y los 30�C en verano,\n" +
                " con brisas marinas refrescante";
          }

    }
    public void cordobaalojamiento()
    {
        if (_titulo.text == "CORDOBA")
        {
            _explicacion.gameObject.SetActive(true);
            _explicacion.text = "Hay gran cantidad de hoteles, hostales, apartamentos turisticos... \n consultar en paginas segun las fechas del viaje";
        }
        else if (_titulo.text == "CADIZ")
        {
            _explicacion.gameObject.SetActive(true);
            _explicacion.text = "C�diz ofrece diversas opciones de alojamiento, desde hoteles boutique en el casco antiguo\n" +
                " hasta modernos apartamentos cerca de la playa.\n" +
                "La ciudad cuenta con una amplia oferta para adaptarse \n" +
                " a diferentes presupuestos y preferencias.";
           }
    }
    public void cordobaMasinformacion()
    {
        if (_titulo.text == "CORDOBA")
        {
            _explicacion.gameObject.SetActive(true);
            _explicacion.text = " para mas informacion consultar paginas: \n https://www.turismodecordoba.org/ \n https://www.cordoba.es/";
        }
        else if (_titulo.text == "CADIZ")
        {
            _explicacion.gameObject.SetActive(true);
            _explicacion.text = " para mas informacion consultar paginas: \n https://www.andalucia.org/es/provincia-cadiz \n https://turismo.cadiz.es/es/ver/todos";
        }
     
    }
}
