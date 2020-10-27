using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Pwa.Shared.Models.Concrete
{
    public class States
    {
        [Display(Name = "State Id")]
        public int Id { get; private set; }

        [Display(Name = "State Name")]
        public string Name { get; private set; }

        [Display(Name = "State Abbreviation")]
        public string Abbreviation { get; private set; }

        public static List<States> ListAllStates = new List<States>() {
                new States() { Id = 1, Name = "Alabama", Abbreviation = "AL" },
                new States() { Id = 2, Name = "Alaska", Abbreviation = "AK" },
                new States() { Id = 3, Name = "Arizona", Abbreviation = "AZ" },
                new States() { Id = 4, Name = "Arkansas", Abbreviation = "AK" },
                new States() { Id = 5, Name = "California", Abbreviation = "CA" },
                new States() { Id = 6, Name = "Colorado", Abbreviation = "CO" },
                new States() { Id = 7, Name = "Connecticut", Abbreviation = "CT" },
                new States() { Id = 8, Name = "Delaware", Abbreviation = "DE" },
                new States() { Id = 9, Name = "Florida", Abbreviation = "FL" },
                new States() { Id = 10, Name = "Georgia", Abbreviation = "GA" },
                new States() { Id = 11, Name = "Hawaii", Abbreviation = "HI" },
                new States() { Id = 12, Name = "Idaho", Abbreviation = "Id" },
                new States() { Id = 13, Name = "Illinois", Abbreviation = "IL" },
                new States() { Id = 14, Name = "Indiana", Abbreviation = "IN" },
                new States() { Id = 15, Name = "Iowa", Abbreviation = "IA" },
                new States() { Id = 16, Name = "Kansas", Abbreviation = "KS" },
                new States() { Id = 17, Name = "Kentucky", Abbreviation = "KY" },
                new States() { Id = 18, Name = "Louisiana", Abbreviation = "LA" },
                new States() { Id = 19, Name = "Maine", Abbreviation = "ME" },
                new States() { Id = 20, Name = "Maryland", Abbreviation = "MD" },
                new States() { Id = 21, Name = "Massachusetts", Abbreviation = "MA" },
                new States() { Id = 22, Name = "Michigan", Abbreviation = "MI" },
                new States() { Id = 23, Name = "Minnesota", Abbreviation = "MN" },
                new States() { Id = 24, Name = "Mississippi", Abbreviation = "MS" },
                new States() { Id = 25, Name = "Missouri", Abbreviation = "MO" },
                new States() { Id = 26, Name = "Montana", Abbreviation = "MT" },
                new States() { Id = 27, Name = "Nebraska", Abbreviation = "NE" },
                new States() { Id = 28, Name = "Nevada", Abbreviation = "NV" },
                new States() { Id = 29, Name = "New Hampshire", Abbreviation = "NH" },
                new States() { Id = 30, Name = "New Jersey", Abbreviation = "NJ" },
                new States() { Id = 31, Name = "New Mexico", Abbreviation = "NM" },
                new States() { Id = 32, Name = "New York", Abbreviation = "NY" },
                new States() { Id = 33, Name = "North Carolina", Abbreviation = "NC" },
                new States() { Id = 34, Name = "North Dakota", Abbreviation = "ND" },
                new States() { Id = 35, Name = "Ohio", Abbreviation = "OH" },
                new States() { Id = 36, Name = "Oklahoma", Abbreviation = "OK" },
                new States() { Id = 37, Name = "Oregon", Abbreviation = "OR" },
                new States() { Id = 38, Name = "Pennsylvania", Abbreviation = "PA" },
                new States() { Id = 39, Name = "Rhode Island", Abbreviation = "RI" },
                new States() { Id = 40, Name = "South Carolina", Abbreviation = "SC" },
                new States() { Id = 41, Name = "South Dakota", Abbreviation = "SD" },
                new States() { Id = 42, Name = "Tennessee", Abbreviation = "TN" },
                new States() { Id = 43, Name = "Texas", Abbreviation = "TX" },
                new States() { Id = 44, Name = "Utah", Abbreviation = "UT" },
                new States() { Id = 45, Name = "Vermont", Abbreviation = "VT" },
                new States() { Id = 46, Name = "Virginia", Abbreviation = "VA" },
                new States() { Id = 47, Name = "Washington", Abbreviation = "WA" },
                new States() { Id = 48, Name = "West Virginia", Abbreviation = "WV" },
                new States() { Id = 49, Name = "Wisconsin", Abbreviation = "WI" },
                new States() { Id = 50, Name = "Wyoming", Abbreviation = "WY" }
        };

        public static States GetStateById(int StateId) => ListAllStates.Find(s => s.Id.Equals(StateId));

        public static States GetStateByName(string StateName) => ListAllStates.Find(s => s.Name.Equals(StateName));       
    }
}