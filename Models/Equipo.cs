using System.Collections.Generic;

public static class Equipo
{

    static public Dictionary<string, Indumentaria> EquiposIndumentaria { get; private set; }

    static public List<string> ListaEquipos { get; private set; } = new List<string> {"Sacachispa", "Diego", "Chicago", "Betis", "Fiorentina", "Gales", "Japon" , "nigga","pala", "iquique"};
    static public List<string> ListaMedias { get; private set; } = new List<string> {"saca.png", "diego.png", "chicago.png", "betis.png", "fiorentina.png", "gales.jpg", "japon.png", "nigga.jpg", "pala.jpg" };
    static public List<string> ListaPantalones { get; private set; }
    static public List<string> ListaRemeras { get; private set; }

    static public bool IngresarIndumentaria(string EquipoSeleccionado, Indumentaria item)
    { 

      bool seCargo;
       if(EquiposIndumentaria.ContainsKey(EquipoSeleccionado)) 
       {
        seCargo=false;
       }
       else
       {
         EquiposIndumentaria.Add(EquipoSeleccionado,item);
         seCargo=true;
       }
     
        return seCargo;
    }
}
