namespace SOE3MaterialVerwaltung.Models
{
    public class StatistikViewModel
    {
        public List<Materialgruppe> MaterialgruppeList { get; set; }
        public List<Material> MaterialList { get; set; }
        public StatistikViewModel()
        {
            MaterialgruppeList = new List<Materialgruppe>();
            MaterialList = new List<Material>();
        }
    }
}
