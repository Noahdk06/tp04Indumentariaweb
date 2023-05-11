public class Indumentaria
    {

        public string Medias { get; private set; }
        public int Pantalon { get; private set; }
        public int Camiseta { get; private set; }
        

        public Indumentaria()
        {
         Medias ="";
 
         Pantalon=0;
         Camiseta=0;
       
        }
        public Indumentaria(string calcetines, int pantis, int playera)
        {
            Medias = calcetines;
            Pantalon = pantis;
            Camiseta = playera;
          
            
        }
    }