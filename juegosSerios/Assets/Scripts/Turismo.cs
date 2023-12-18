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
            _explicacion.text = "Es recomendable ir a principios de primavera \n o finales de otoño para tener las mejores temperaturas. \n si se visita en la segunda o tercera semana de mayo coincidira con \n el conscuros de los patios cordobeses";

        }
        else
        {
            _explicacion.gameObject.SetActive(true);
            _explicacion.text = "Es recomendable ir en primavera o verano \n o finales de otoño para tener las mejores temperaturas. \n ";

        }

    }
    public void cordobaTransporte()
    {
        if(_titulo.text == "CORDOBA")
        {
            _explicacion.gameObject.SetActive(true);
            _explicacion.text = "En cordoba lo recomendable es ir andando a todos los sitios ya que se encuentran vastante cerca. Si se prefiere tambien se cuenta con una red de autobuses. Sin embarco por el centro de la ciudad no pasan.";
        }
        else
        {
            _explicacion.gameObject.SetActive(true);
            _explicacion.text = "En Granada lo recomendable es ir andando a todos los sitios y disfrutar de sus edificios históricos. También cuenta con transporte público, \npara asi hacer más accesible su escarpado terreno a personas con discapacodad o mayores.";
        }
       
    }
    public void cordobaquever()
    {
        if (_titulo.text == "CORDOBA")
        {
            _explicacion.gameObject.SetActive(true);
            _explicacion.text = "Mezquita catedral  \n Juderia  \n Jardices del alcazar  \n medina azahara  \n palacio de viana  \n centro historico  \n patios cordobeses  \n templo romano  \n cristo de los faroles  \n puente romano ";
        }
        else
        {
            _explicacion.gameObject.SetActive(true);
            _explicacion.text = "Alhambra \n Mirador San Nicolás \n Albaicín \n San Matías \n Famosa calle:  Pedro Antonio Alarcón \n Parque Lorca \n ";
        }
        
    }
    public void cordobacuantoir()
    {

        if(_titulo.text == "CORDOBA")
        {
            _explicacion.gameObject.SetActive(true);
            _explicacion.text = "Cordoba, aunque tiene muchas cosa sque ver es un lugar perfecto para ir en cualquier momento. \n Dependiendo de cuanto tiempo quieras dedicar a ver cada cosa. Cordoba se puede ver \n entre tres y cinco dias.";
        }
        else
        {
            _explicacion.gameObject.SetActive(true);
            _explicacion.text = "El mejor momento para disfrutar de la parva es \n la primera semana de agosto, que es cuendo se celebra";
        }
       
    }
    public void cordobadondecomer()
    {
        if (_titulo.text == "CORDOBA")
        {
            _explicacion.gameObject.SetActive(true);
            _explicacion.text = "Hay muchos sitios para ir a comer. Se caracteriza por las tapas. \n las tapas son pequeñas porciones de comida que viene con la bebida. \n Alguno de los mejores sitios para comer en cordoba son: \n Casa Pepe de la juderia \n El numero 10 \n Bar Santos \n Taberna bonfoé \n Casa del pisto";
        }
        else
        {
            _explicacion.gameObject.SetActive(true);
            _explicacion.text = "Granada destaca por su comida, las tapas sobretodo. \n Lo mas sorprendente acaba siendo el precio. Una ubicación muy amable al bolsillo. \n En la mayoría de bares tienes una  bebida con tapa  por un módico precio. \n";
        }

    }
    public void cordobaclima()
    {

        if(_titulo.text == "CORDOBA")
        {
            _explicacion.gameObject.SetActive(true);
            _explicacion.text = " Cordoba se distingue por su clima mediterráneo.\n Los veranos son muy calurosos, con temperaturas que suelen superar los 35C.\n Durante los inviernos el clima es más frio, con temperaturas entorno los 9-20C.\n En primavera y otoño, Córdoba tiene temperaturas moderadas, lo que es ideal para recorrer sus calles. ";
        }
        else{
            _explicacion.gameObject.SetActive(true);
            _explicacion.text = " Granada destaca por un clima seco, en invierno tiene temperaturas de hasta 0 grados y los veranos sueles ser demasiado agobiantes, \npor eso las mejores sueles ser primavera y otoño";
        }
      
    }
    public void cordobaalojamiento()
    {
        if (_titulo.text == "CORDOBA")
        {
            _explicacion.gameObject.SetActive(true);
            _explicacion.text = "Hay gran cantidad de hoteles, hostales, apartamentos turisticos... \n consultar en paginas segun las fechas del viaje";
        }
        else
        {
            _explicacion.gameObject.SetActive(true);
            _explicacion.text = "Hay muchos sitios locales de alojamiento. \n Destaca: las  casas cueva en Guadix.";
        }
      
    }
    public void cordobaMasinformacion()
    {
        if (_titulo.text == "CORDOBA")
        {
            _explicacion.gameObject.SetActive(true);
            _explicacion.text = " para mas informacion consultar paginas: \n https://www.turismodecordoba.org/ \n https://www.cordoba.es/";
        }
        else
        {
            _explicacion.gameObject.SetActive(true);
            _explicacion.text = " para mas informacion consultar paginas: \n https://www.andalucia.org/es/provincia-granada \n https://www.granada.es/";
        }
     
    }
}
