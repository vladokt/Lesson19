namespace Services
{
    /// <summary>
    /// Passnenger DTO.
    /// </summary>
    public class PassengerDto : BaseDto
    {
        /// <summary>
        /// Surname.
        /// </summary>
        public string Surname { get; set; } = "";

        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// Date of birth.
        /// </summary>
        public DateTime DateOfBirth { get; set; }
    }
}
