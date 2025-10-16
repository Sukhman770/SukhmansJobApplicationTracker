namespace JobApplicationTracker
{
    public enum ApplicationStatus
    {
        // Enum används för att definiera olika statusar för en jobbansökan.
        Applied,
        Interview,
        Offer,
        Rejected
    }

    public class JobApplication
    {
        // Alla attribut
        public string CompanyName { get; set; }
        public string PositionTitle { get; set; }
        public ApplicationStatus Status { get; set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime? ResponseDate { get; set; }
        public int SalaryExpectation { get; set; }

        // Metod för att få en sammanfattning av ansökan
        public string GetSummary()
        {
            return $"{CompanyName} - {PositionTitle} ({Status}) Ansökt: {ApplicationDate:yyyy-MM-dd}" +
                   (ResponseDate.HasValue ? $", Svar: {ResponseDate.Value:yyyy-MM-dd}" : "") +
                   $", Löneanspråk: {SalaryExpectation} kr";
        }

        public JobApplication(string companyName, string positionTitle, ApplicationStatus status, DateTime applicationDate, int salaryExpectation)
        {
            CompanyName = companyName;
            PositionTitle = positionTitle;
            Status = status;
            ApplicationDate = applicationDate;
            SalaryExpectation = salaryExpectation;
        }

        // En metod för att visa information om ansökan
        public override string ToString()
        {


            return $"Företag: {CompanyName}, Tjänst: {PositionTitle}, Status: {Status}, Ansökt: {ApplicationDate.ToShortDateString()}, Lön: {SalaryExpectation} kr";

        }
    }




}














