namespace Prolimza.Models
{
    public class Distrito
    {
        public int IdDistrito { get; set; }
        public string Nombre { get; set; }
        public int IdCanton { get; set; }
<<<<<<< Updated upstream
<<<<<<< Updated upstream
        public Canton Canton { get; set; }
        public ICollection<Bodega> Bodegas { get; set; }
=======
        public Canton? Canton { get; set; }
        public ICollection<Bodega>? Bodegas { get; set; }
>>>>>>> Stashed changes
=======
        public Canton? Canton { get; set; }
        public ICollection<Bodega>? Bodegas { get; set; }
>>>>>>> Stashed changes
    }
}
