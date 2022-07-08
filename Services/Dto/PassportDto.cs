namespace Services
{
    /// <summary>
    /// Passport DTO.
    /// </summary>
    public class PassportDto : BaseDto
    {
        /// <summary>
        /// Passport No.
        /// </summary>
        public int PassportNo { get; set; }

        /// <summary>
        /// Date of issue.
        /// </summary>
        public DateTime DateOfIssue { get; set; }

        /// <summary>
        /// Passenger id.
        /// </summary>
        public long PassengerId { get; set; }
    }
}
