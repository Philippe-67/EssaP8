namespace ServicePriseDeRendezVous.Models
{
    public class Appointement
    {
        public int AppointementId { get; set; }
        public DateTime AppointementDate { get; set; }
        public string PatientId { get; set; }
        public string PatientName { get; set;}
        public string TypeRDV { get; set;}
    }
}
