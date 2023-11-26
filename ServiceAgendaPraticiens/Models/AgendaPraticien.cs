namespace ServiceAgendaPraticiens.Models
{
    public class AgendaPraticien
    {
        public int AgendaPraticienId { get; set; }
        public int PraticienId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string NomPatient { get; set; }

        public virtual Praticien Praticien { get; set; }
    }
}
    