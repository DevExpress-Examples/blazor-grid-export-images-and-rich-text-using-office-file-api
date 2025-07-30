using System.ComponentModel.DataAnnotations;

namespace ExportImagesAndRichText.Data {
    public class Employee {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? NotesHtml { get; set; }
        public string? PhotoUrl { get; set; }
    }
}