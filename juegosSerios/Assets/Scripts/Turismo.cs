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
        _explicacion.gameObject.SetActive(true);
        _explicacion.text = "Es recomendable ir a principios de primavera \n o finales de otoño para tener las mejores temperaturas. \n si se visita en la segunda o tercera semana de mayo coincidira con \n el conscuros de los patios cordobeses";

    }
    public void cordobaTransporte()
    {
        _explicacion.gameObject.SetActive(true);
        _explicacion.text = "En cordoba lo recomendable es ir andando a todos los sitios ya que se encuentran vastante cerca. Si se prefiere tambien se cuenta con una red de autobuses. Sin embarco por el centro de la ciudad no pasan.";
    }
    public void cordobaquever()
    {
        _explicacion.gameObject.SetActive(true);
        _explicacion.text = "Mezquita catedral  \n Juderia  \n Jardices del alcazar  \n medina azahara  \n palacio de viana  \n centro historico  \n patios cordobeses  \n templo romano  \n cristo de los faroles  \n puente romano ";
    }
    public void cordobacuantoir()
    {
        _explicacion.gameObject.SetActive(true);
        _explicacion.text = "Cordoba, aunque tiene muchas cosa sque ver es un lugar perfecto para ir en cualquier momento. \n Dependiendo de cuanto tiempo quieras dedicar a ver cada cosa. Cordoba se puede ver \n entre tres y cinco dias.";
    }
    public void cordobadondecomer()
    {
        _explicacion.gameObject.SetActive(true);
        _explicacion.text = "Hay muchos sitios para ir a comer. Se caracteriza por las tapas. \n las tapas son pequeñas porciones de comida que viene con la bebida. \n Alguno de los mejores sitios para comer en cordoba son: \n Casa Pepe de la juderia \n El numero 10 \n Bar Santos \n Taberna bonfoé \n Casa del pisto";
    }
    public void cordobaclima()
    {
        _explicacion.gameObject.SetActive(true);
        _explicacion.text = " Cordoba se distingue por su clima mediterráneo.\n Los veranos son muy calurosos, con temperaturas que suelen superar los 35C.\n Durante los inviernos el clima es más frio, con temperaturas entorno los 9-20C.\n En primavera y otoño, Córdoba tiene temperaturas moderadas, lo que es ideal para recorrer sus calles. ";
    }
    public void cordobaalojamiento()
    {
        _explicacion.gameObject.SetActive(true);
        _explicacion.text = "Hay gran cantidad de hoteles, hostales, apartamentos turisticos... \n consultar en paginas segun las fechas del viaje";
    }
    public void cordobaMasinformacion()
    {
        _explicacion.gameObject.SetActive(true);
        _explicacion.text = " para mas informacion consultar paginas: \n https://www.turismodecordoba.org/ \n https://www.cordoba.es/";
    }
}
