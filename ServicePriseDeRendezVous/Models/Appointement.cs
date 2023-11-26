namespace ServicePriseDeRendezVous.Models
{
    public class Appointement
    {
        public int AppointmentId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string PatientId { get; set; }
        public string PatientName { get; set;}
        public string TypeRDV { get; set;}
    }
}
