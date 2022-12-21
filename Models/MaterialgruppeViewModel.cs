namespace SOE3MaterialVerwaltung.Models
{
    public class MaterialgruppeViewModel
    {
        public List<Materialgruppe> MaterialgruppeList { get; set; }

        public MaterialgruppeViewModel()
        {
            MaterialgruppeList = new List<Materialgruppe>();
        }
    }
}
