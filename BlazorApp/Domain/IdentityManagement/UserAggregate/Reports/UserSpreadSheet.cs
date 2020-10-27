using ExportToExcel.Attributes;

namespace Domain.IdentityManagement.UserAggregate
{
    [SpreadSheet(nameof(UserSpreadSheet), typeof(UserSpreadSheet))]
    public class UserSpreadSheet
    {
        private UserSpreadSheet(User e)
        {
            Id = e.Id;
            FirstName = e.FirstName;
            LastName = e.LastName;
            Email = e.Email;
            PhoneNumber = e.PhoneNumber;
            UserName = e.UserName;
            NormalizedEmail = e.NormalizedEmail;
            NormalizedUserName = e.NormalizedUserName;
        }

        [SpreadSheetColumn(nameof(Id), 0)]
        public string Id { get; set; }

        [SpreadSheetColumn("First Name", 1)]
        public string FirstName { get; set; }

        [SpreadSheetColumn("Last Name", 2)]
        public string LastName { get; set; }

        [SpreadSheetColumn("Email", 3)]
        public string Email { get; set; }

        [SpreadSheetColumn("Phone Number", 4)]
        public string PhoneNumber { get; set; }

        [SpreadSheetColumn("User Name", 5)]
        public string UserName { get; set; }

        [SpreadSheetColumn("Normalized Email", 6)]
        public string NormalizedEmail { get; set; }

        [SpreadSheetColumn("Normalized User Name", 7)]
        public string NormalizedUserName { get; set; }

        public static implicit operator UserSpreadSheet(User e) => new UserSpreadSheet(e);        
    }
}
