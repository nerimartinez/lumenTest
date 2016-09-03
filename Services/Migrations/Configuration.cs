namespace ServicesLayer.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ServicesLayer.Models.LumenContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ServicesLayer.Models.LumenContext context)
        {
            var man1 = new Manufacturer() { Id = 1, Name = "Check Point" };
            var man2 = new Manufacturer() { Id = 2, Name = "Cisco" };
var man3 = new Manufacturer() { Id = 3, Name = "iptables" };
var man4 = new Manufacturer() { Id = 4, Name = "Juniper" };
var man5 = new Manufacturer() { Id = 5, Name = "Netscreen" };
var man6 = new Manufacturer() { Id = 6, Name = "PF" };
var man7 = new Manufacturer() { Id = 7, Name = "Vyatta" };
var man8 = new Manufacturer() { Id = 8, Name = "Palo Alto Networks" };
var man9 = new Manufacturer() { Id = 9, Name = "Centripetal Networks" };
var man10 = new Manufacturer() { Id = 10, Name = "Ubiquiti" };
var man11 = new Manufacturer() { Id = 11, Name = "tcpdump" };
var man12 = new Manufacturer() { Id = 12, Name = "Other" };
var man13 = new Manufacturer() { Id = 13, Name = "Infoblox" };
var man14 = new Manufacturer() { Id = 14, Name = "DNS Server" };
            //  This method will be called after migrating to the latest version.
            context.Manufacturers.AddOrUpdate(
                x => x.Id,
                man1,
                man2,
                man3,
                man4,
                man5,
                man6,
                man7,
                man8,
                man9,
                man10,
                man11,
                man12,
                man13,
                man14
                );

            context.Models.AddOrUpdate(
                x => x.Id,
                new Model() { Id = 1, Manufacturer = man1, Name = "VPN - 1 Power Linux" },
new Model() { Id = 2, Manufacturer = man1, Name = "UTM / SPLAT" },
new Model() { Id = 3, Manufacturer = man1, Name = "Other" },
new Model() { Id = 4, Manufacturer = man2, Name = "ASA" },
new Model() { Id = 5, Manufacturer = man2, Name = "PIX" },
new Model() { Id = 6, Manufacturer = man2, Name = "ISR/IOS Firewall" },
new Model() { Id = 7, Manufacturer = man2, Name = "Other" },
new Model() { Id = 10, Manufacturer = man3, Name = "Linux" },
new Model() { Id = 11, Manufacturer = man3, Name = "BSD" },
new Model() { Id = 12, Manufacturer = man3, Name = "Other" },
new Model() { Id = 13, Manufacturer = man4, Name = "SRX - Security Zones" },
new Model() { Id = 14, Manufacturer = man4, Name = "SRX - Firewall Filter" },
new Model() { Id = 16, Manufacturer = man4, Name = "Routers (MX)" },
new Model() { Id = 17, Manufacturer = man4, Name = "Other" },
new Model() { Id = 18, Manufacturer = man5, Name = "5 GT / XT" },
new Model() { Id = 19, Manufacturer = man5, Name = "5 GT / XT Plus" },
new Model() { Id = 20, Manufacturer = man5, Name = "HSC" },
new Model() { Id = 21, Manufacturer = man5, Name = "HSC Plus" },
new Model() { Id = 22, Manufacturer = man5, Name = "SSG 5/20" },
new Model() { Id = 23, Manufacturer = man5, Name = "25/50" },
new Model() { Id = 24, Manufacturer = man5, Name = "SSG 140" },
new Model() { Id = 25, Manufacturer = man5, Name = "204/208" },
new Model() { Id = 26, Manufacturer = man5, Name = "SSG 500" },
new Model() { Id = 27, Manufacturer = man5, Name = "500 Series" },
new Model() { Id = 28, Manufacturer = man5, Name = "ISG / GPRS" },
new Model() { Id = 29, Manufacturer = man5, Name = "5200/5400" },
new Model() { Id = 30, Manufacturer = man5, Name = "Other" },
new Model() { Id = 31, Manufacturer = man6, Name = "pfSense" },
new Model() { Id = 32, Manufacturer = man6, Name = "FreeBSD" },
new Model() { Id = 33, Manufacturer = man6, Name = "OpenBSD" },
new Model() { Id = 34, Manufacturer = man6, Name = "Other" },
new Model() { Id = 35, Manufacturer = man7, Name = "Bridge" },
new Model() { Id = 36, Manufacturer = man7, Name = "Router" },
new Model() { Id = 37, Manufacturer = man7, Name = "Other" },
new Model() { Id = 38, Manufacturer = man8, Name = "PANOS v5.0" },
new Model() { Id = 39, Manufacturer = man8, Name = "Other" },
new Model() { Id = 40, Manufacturer = man9, Name = "RuleGate" },
new Model() { Id = 41, Manufacturer = man9, Name = "Other" },
new Model() { Id = 42, Manufacturer = man10, Name = "EdgeOS (Router mode)" },
new Model() { Id = 43, Manufacturer = man10, Name = "EdgeOS (bridge mode)" },
new Model() { Id = 44, Manufacturer = man10, Name = "Other" },
new Model() { Id = 45, Manufacturer = man11, Name = "pcap" },
new Model() { Id = 46, Manufacturer = man11, Name = "Other" },
new Model() { Id = 47, Manufacturer = man12, Name = "DNS Firewall" },
new Model() { Id = 48, Manufacturer = man13, Name = "Other" },
new Model() { Id = 49, Manufacturer = man14, Name = "Other" }
                );

            context.Policies.AddOrUpdate(
                x => x.Id,
                new Policy() { Id = 1, Value = "Basic" },
                new Policy() { Id = 1, Value = "Advance" }
                );

            context.Locations.AddOrUpdate(
                x => x.Id,
                new Location { Id = 1, Name = "Afghanistan" },
new Location { Id = 2, Name = "Albania" },
new Location { Id = 3, Name = "Algeria" },
new Location { Id = 4, Name = "American Samoa" },
new Location { Id = 5, Name = "Andorra" },
new Location { Id = 6, Name = "Angola" },
new Location { Id = 7, Name = "Anguilla" },
new Location { Id = 8, Name = "Antarctica" },
new Location { Id = 9, Name = "Antigua & Barbuda" },
new Location { Id = 10, Name = "Antilles, Netherlands" },
new Location { Id = 11, Name = "Arabia, Saudi" },
new Location { Id = 12, Name = "Argentina" },
new Location { Id = 13, Name = "Armenia" },
new Location { Id = 14, Name = "Aruba" },
new Location { Id = 15, Name = "Australia" },
new Location { Id = 16, Name = "Austria" },
new Location { Id = 17, Name = "Azerbaijan" },
new Location { Id = 18, Name = "Bahamas" },
new Location { Id = 19, Name = "Bahrain" },
new Location { Id = 20, Name = "Bangladesh" },
new Location { Id = 21, Name = "Barbados" },
new Location { Id = 22, Name = "Belarus" },
new Location { Id = 23, Name = "Belgium" },
new Location { Id = 24, Name = "Belize" },
new Location { Id = 25, Name = "Benin" },
new Location { Id = 26, Name = "Bermuda" },
new Location { Id = 27, Name = "Bhutan" },
new Location { Id = 28, Name = "Bolivia" },
new Location { Id = 29, Name = "Bosnia and Herzegovina" },
new Location { Id = 30, Name = "Botswana" },
new Location { Id = 31, Name = "Bouvet Island" },
new Location { Id = 32, Name = "Brazil" },
new Location { Id = 33, Name = "British Indian Ocean T" },
new Location { Id = 34, Name = "British Virgin Islands" },
new Location { Id = 35, Name = "Brunei Darussalam" },
new Location { Id = 36, Name = "Bulgaria" },
new Location { Id = 37, Name = "Burkina Faso" },
new Location { Id = 38, Name = "Burundi" },
new Location { Id = 39, Name = "Cambodia" },
new Location { Id = 40, Name = "Cameroon" },
new Location { Id = 41, Name = "Canada" },
new Location { Id = 42, Name = "Cape Verde" },
new Location { Id = 43, Name = "Cayman Islands" },
new Location { Id = 44, Name = "Central African Republic" },
new Location { Id = 45, Name = "Chad" },
new Location { Id = 46, Name = "Chile" },
new Location { Id = 47, Name = "China" },
new Location { Id = 48, Name = "Christmas Island" },
new Location { Id = 49, Name = "Cocos (Keeling) Islands" },
new Location { Id = 50, Name = "Colombia" },
new Location { Id = 51, Name = "Comoros" },
new Location { Id = 52, Name = "Congo" },
new Location { Id = 53, Name = "Cook Islands" },
new Location { Id = 54, Name = "Costa Rica" },
new Location { Id = 55, Name = "Cote D Ivoire" },
new Location { Id = 56, Name = "Croatia" },
new Location { Id = 57, Name = "Cuba" },
new Location { Id = 58, Name = "Cyprus" },
new Location { Id = 59, Name = "Czech Republic" },
new Location { Id = 60, Name = "Denmark" },
new Location { Id = 61, Name = "Djibouti" },
new Location { Id = 62, Name = "Dominica" },
new Location { Id = 63, Name = "Dominican Republic" },
new Location { Id = 64, Name = "East Timor (Timor-Leste)" },
new Location { Id = 65, Name = "Ecuador" },
new Location { Id = 66, Name = "Egypt" },
new Location { Id = 67, Name = "El Salvador" },
new Location { Id = 68, Name = "Equatorial Guinea" },
new Location { Id = 69, Name = "Eritrea" },
new Location { Id = 70, Name = "Estonia" },
new Location { Id = 71, Name = "Ethiopia" },
new Location { Id = 72, Name = "European Union" },
new Location { Id = 73, Name = "Falkland Islands (Malvinas)" },
new Location { Id = 74, Name = "Faroe Islands" },
new Location { Id = 75, Name = "Fiji" },
new Location { Id = 76, Name = "Finland" },
new Location { Id = 77, Name = "France" },
new Location { Id = 78, Name = "French Guiana" },
new Location { Id = 79, Name = "French Polynesia" },
new Location { Id = 80, Name = "French Southern Terr" },
new Location { Id = 81, Name = "Gabon" },
new Location { Id = 82, Name = "Gambia" },
new Location { Id = 83, Name = "Georgia" },
new Location { Id = 84, Name = "Germany" },
new Location { Id = 85, Name = "Ghana" },
new Location { Id = 86, Name = "Gibraltar" },
new Location { Id = 87, Name = "Greece" },
new Location { Id = 88, Name = "Greenland" },
new Location { Id = 89, Name = "Grenada" },
new Location { Id = 90, Name = "Guadeloupe" },
new Location { Id = 91, Name = "Guam" },
new Location { Id = 92, Name = "Guatemala" },
new Location { Id = 93, Name = "Guernsey and Alderney" },
new Location { Id = 94, Name = "Guiana French" },
new Location { Id = 95, Name = "Guinea" },
new Location { Id = 96, Name = "Guinea-Bissau" },
new Location { Id = 97, Name = "Guinea-Equatorial" },
new Location { Id = 98, Name = "Guyana" },
new Location { Id = 99, Name = "Haiti" },
new Location { Id = 100, Name = "Heard & McDonald Is(AU)" },
new Location { Id = 101, Name = "Holy See (Vatican)" },
new Location { Id = 102, Name = "Honduras" },
new Location { Id = 103, Name = "Hong Kong (China)" },
new Location { Id = 104, Name = "Hungary" },
new Location { Id = 105, Name = "Iceland" },
new Location { Id = 106, Name = "India" },
new Location { Id = 107, Name = "Indonesia" },
new Location { Id = 108, Name = "Iran Islamic Republic of" },
new Location { Id = 109, Name = "Iraq" },
new Location { Id = 110, Name = "Ireland" },
new Location { Id = 111, Name = "Israel" },
new Location { Id = 112, Name = "Italy" },
new Location { Id = 113, Name = "Ivory Coast (Cote d Ivoire)" },
new Location { Id = 114, Name = "Jamaica" },
new Location { Id = 115, Name = "Japan" },
new Location { Id = 116, Name = "Jersey" },
new Location { Id = 117, Name = "Jordan" },
new Location { Id = 118, Name = "Kazakhstan" },
new Location { Id = 119, Name = "Kenya" },
new Location { Id = 120, Name = "Kiribati" },
new Location { Id = 121, Name = "Korea Dem. Peoples Rep" },
new Location { Id = 122, Name = "Korea, (South) Republic of" },
new Location { Id = 123, Name = "Kosovo" },
new Location { Id = 124, Name = "Kuwait" },
new Location { Id = 125, Name = "Kyrgyzstan" },
new Location { Id = 126, Name = "Lao Peoples Democ. Rep" },
new Location { Id = 127, Name = "Latvia" },
new Location { Id = 128, Name = "Lebanon" },
new Location { Id = 129, Name = "Lesotho" },
new Location { Id = 130, Name = "Liberia" },
new Location { Id = 131, Name = "Libyan Arab Jamahiriya" },
new Location { Id = 132, Name = "Liechtenstein" },
new Location { Id = 133, Name = "Lithuania" },
new Location { Id = 134, Name = "Luxembourg" },
new Location { Id = 135, Name = "Macao, (China)" },
new Location { Id = 136, Name = "Macedonia, TFYR" },
new Location { Id = 137, Name = "Madagascar" },
new Location { Id = 138, Name = "Malawi" },
new Location { Id = 139, Name = "Malaysia" },
new Location { Id = 140, Name = "Maldives" },
new Location { Id = 141, Name = "Mali" },
new Location { Id = 142, Name = "Malta" },
new Location { Id = 143, Name = "Man, Isle of" },
new Location { Id = 144, Name = "Marshall Islands" },
new Location { Id = 145, Name = "Martinique (FR)" },
new Location { Id = 146, Name = "Mauritania" },
new Location { Id = 147, Name = "Mauritius" },
new Location { Id = 148, Name = "Mayotte (FR)" },
new Location { Id = 149, Name = "Mexico" },
new Location { Id = 150, Name = "Micronesia, Fed. States of" },
new Location { Id = 151, Name = "Moldova, Republic of" },
new Location { Id = 152, Name = "Monaco" },
new Location { Id = 153, Name = "Mongolia" },
new Location { Id = 154, Name = "Montenegro" },
new Location { Id = 155, Name = "Montserrat" },
new Location { Id = 156, Name = "Morocco" },
new Location { Id = 157, Name = "Mozambique" },
new Location { Id = 158, Name = "Myanmar (ex-Burma)" },
new Location { Id = 159, Name = "Namibia" },
new Location { Id = 160, Name = "Nauru" },
new Location { Id = 237, Name = "Uganda" },
new Location { Id = 238, Name = "Ukraine" },
new Location { Id = 239, Name = "United Arab Emirates" },
new Location { Id = 240, Name = "United Kingdom" },
new Location { Id = 241, Name = "United States" },
new Location { Id = 242, Name = "US Minor Outlying Isl" },
new Location { Id = 243, Name = "Uruguay" },
new Location { Id = 244, Name = "Uzbekistan" },
new Location { Id = 245, Name = "Vanuatu" },
new Location { Id = 246, Name = "Vatican (Holy See)" },
new Location { Id = 247, Name = "Venezuela" },
new Location { Id = 248, Name = "Viet Nam" },
new Location { Id = 249, Name = "Virgin Islands, British" },
new Location { Id = 250, Name = "Virgin Islands, U.S." },
new Location { Id = 251, Name = "Wallis and Futuna" },
new Location { Id = 252, Name = "Western Sahara" },
new Location { Id = 253, Name = "Yemen" },
new Location { Id = 254, Name = "Zambia" },
new Location { Id = 255, Name = "Zimbabwe" }
                );



            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters"},
            //      new Person { FullName = "Brice Lambson"},
            //      new Person { FullName = "Rowan Miller"}
            //    );
            //
        }
    }
}
