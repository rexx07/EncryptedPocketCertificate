namespace EPC.Core.Domain.Documents
{
    public class Document : BaseEntity
    {
        /// <summary>
        /// Set Document name.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Type Of Document.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The authority issuing the document (public, private, local govt, state govt, federal gov.
        /// </summary>
        public string Authority { get; set; }

        /// <summary>
        /// Description about the document and what it entails
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Name of firm or body/administrative agency issuing the document.
        /// </summary>
        public string Licensor { get; set; }

        /// <summary>
        /// Date document submitted
        /// </summary>
        public DateTime DateAdded { get; set; }

        /// <summary>
        /// Is the document valid
        /// </summary>
        public bool IsValid { get; set; }

        /// <summary>
        /// Expiry Date
        /// </summary>
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// Set autorenew
        /// </summary>
        public bool AutoRenew { get; set; }
    }
}
