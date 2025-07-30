namespace ExportImagesAndRichText.Data {
    public class EmployeesService {
        public List<Employee> GetEmployees() {
            var employees = new List<Employee>() {
                new Employee() {
                    EmployeeID = 1,
                    FirstName = "Nancy",
                    LastName = "Davolio",
                    NotesHtml = "<ul></ul><p><strong>Title Of Courtesy: Ms</strong>.</p><p><span style=\"color: #33cccc;\">Title:&nbsp;Sales Representative</span></p><p>Education includes a BA in psychology from <span style=\"text-decoration: underline;\"><em>Colorado State University</em></span> in 1970.  She also completed \"The Art of the Cold Call.\"  Nancy is a member of Toastmasters International.</p>",
                    PhotoUrl = "Images/Nancy.jpg"
                },
                new Employee() {
                    EmployeeID = 2,
                    FirstName = "Andrew",
                    LastName = "Fuller",
                    NotesHtml = "<ul></ul><p><strong>Title Of Courtesy: Dr.</strong></p><p><span style=\"color: #33cccc;\">Title:&nbsp;Vice President, Sales</span></p><p>Andrew received his BTS commercial in 1974 and a Ph.D. in international marketing from the <span style=\"text-decoration: underline;\"><em>University of Dallas</em></span> in 1981.  He is fluent in French and Italian and reads German.  He joined the company as a sales representative, was promoted to sales manager in January 1992 and to vice president of sales in March 1993.  Andrew is a member of the Sales Management Roundtable, the Seattle Chamber of Commerce, and the Pacific Rim Importers Association.</p>",
                    PhotoUrl = "Images/Andrew.jpg"
                },
                new Employee() {
                    EmployeeID = 3,
                    FirstName = "Janet",
                    LastName = "Leverling",
                    NotesHtml = "<ul></ul><p><strong>Title Of Courtesy: Ms.</strong></p><p><span style=\"color: #33cccc;\">Title:&nbsp;Sales Representative</span></p><p>Janet has a BS degree in chemistry from <span style=\"text-decoration: underline;\"><em>Boston College</em></span> (1984).  She has also completed a certificate program in food retailing management.  Janet was hired as a sales associate in 1991 and promoted to sales representative in February 1992.</p>",
                    PhotoUrl = "Images/Janet.jpg"
                },
                new Employee() {
                    EmployeeID = 4,
                    FirstName = "Margaret",
                    LastName = "Peacock",
                    NotesHtml = "<ul></ul><p><strong>Title Of Courtesy: Mrs.</strong></p><p><span style=\"color: #33cccc;\">Title:&nbsp;Vice President, Sales</span></p><p>Margaret holds a BA in English literature from <span style=\"text-decoration: underline;\"><em>Concordia College</em></span> (1958) and an MA from the American Institute of Culinary Arts (1966).  She was assigned to the London office temporarily from July through November 1992.</p>",
                    PhotoUrl = "Images/Margaret.jpg"
                },
                new Employee() {
                    EmployeeID = 5,
                    FirstName = "Steven",
                    LastName = "Buchanan",
                    NotesHtml = "<ul></ul><p><strong>Title Of Courtesy: Mr.</strong></p><p><span style=\"color: #33cccc;\">Title:&nbsp;Sales Manager</span></p><p>Steven Buchanan graduated from <span style=\"text-decoration: underline;\"><em>St. Andrews University, Scotland</em></span>, with a BSC degree in 1976.  Upon joining the company as a sales representative in 1992, he spent 6 months in an orientation program at the Seattle office and then returned to his permanent post in London.  He was promoted to sales manager in March 1993.  Mr. Buchanan has completed the courses \"Successful Telemarketing\" and \"International Sales Management.\"  He is fluent in French.</p>",
                    PhotoUrl = "Images/Steven.jpg"
                },
                new Employee() {
                    EmployeeID = 6,
                    FirstName = "Michael",
                    LastName = "Suyama",
                    NotesHtml = "<ul></ul><p><strong>Title Of Courtesy: Mr.</strong></p><p><span style=\"color: #33cccc;\">Title:&nbsp;Sales Representative</span></p><p>Michael is a graduate of <span style=\"text-decoration: underline;\"><em>Sussex University</em></span> (MA, economics, 1983) and the <span style=\"text-decoration: underline;\"><em>University of California at Los Angeles</em></span> (MBA, marketing, 1986).  He has also taken the courses \"Multi-Cultural Selling\" and \"Time Management for the Sales Professional.\"  He is fluent in Japanese and can read and write French, Portuguese, and Spanish.</p>",
                    PhotoUrl = "Images/Michael.jpg"
                },
                new Employee() {
                    EmployeeID = 7,
                    FirstName = "Robert",
                    LastName = "King",
                    NotesHtml = "<ul></ul><p><strong>Title Of Courtesy: Mr.</strong></p><p><span style=\"color: #33cccc;\">Title:&nbsp;Sales Representative</span></p><p>Robert King served in the Peace Corps and traveled extensively before completing his degree in English at the <span style=\"text-decoration: underline;\"><em>University of Michigan</em></span> in 1992, the year he joined the company.  After completing a course entitled \"Selling in Europe,\" he was transferred to the London office in March 1993.</p>",
                    PhotoUrl = "Images/Robert.jpg"
                },
                new Employee() {
                    EmployeeID = 8,
                    FirstName = "Laura",
                    LastName = "Callahan",
                    NotesHtml = "<ul></ul><p><strong>Title Of Courtesy: Ms.</strong></p><p><span style=\"color: #33cccc;\">Title:&nbsp;Inside Sales Coordinator</span></p><p>Laura received a BA in psychology from the <span style=\"text-decoration: underline;\"><em>University of Washington</em></span>.  She has also completed a course in business French.  She reads and writes French.</p>",
                    PhotoUrl = "Images/Laura.jpg"
                },
                new Employee() {
                    EmployeeID = 9,
                    FirstName = "Anne",
                    LastName = "Dodsworth",
                    NotesHtml = "<ul></ul><p><strong>Title Of Courtesy: Ms.</strong></p><p><span style=\"color: #33cccc;\">Title:&nbsp;Sales Representative</span></p><p>Anne has a BA degree in English from <span style=\"text-decoration: underline;\"><em>St. Lawrence College</em></span>.  She is fluent in French and German.</p>",
                    PhotoUrl = "Images/Anne.jpg"
                },
            };
            return employees;
        }
    }
}