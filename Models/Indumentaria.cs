public class Indumentaria
    {

        public string Medias { get; private set; }
        public string Pantalon { get; private set; }
        public string Camiseta { get; private set; }
        

        public Indumentaria()
        {
         Medias ="";
 
         Pantalon="";
         Camiseta="";
       
        }
        public Indumentaria(string calcetines, string pantis, string playera)
        {
            Medias = calcetines;
            Pantalon = pantis;
            Camiseta = playera;
          
            
        }
    }