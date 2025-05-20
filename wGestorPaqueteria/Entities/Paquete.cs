namespace wGestorPaqueteria.Entities
{
    public class Paquete
    {
        public int PaqueteID { get; set; }
        public string NumeroSeguimiento { get; set; }
        public decimal Peso { get; set; }
        public string Dimensiones { get; set; }
        public decimal ValorDeclarado { get; set; }
        public string Estado { get; set; } // Recibido, En tránsito, Entregado
        public int RemitenteID { get; set; }
        public int DestinatarioID { get; set; }

    }
    public class AsignacionPaquete
    {
        public int AsignacionID { get; set; }
        public int PaqueteID { get; set; }
        public string NumeroSeguimiento { get; set; }
        public string Estado { get; set; }

        // Remitente
        public int RemitenteID { get; set; }
        public string RemitenteNombre { get; set; }
        public string DireccionRemitente { get; set; }

        // Destinatario
        public int DestinatarioID { get; set; }
        public string DestinatarioNombre { get; set; }
        public string DireccionDestinatario { get; set; }
    }

}
