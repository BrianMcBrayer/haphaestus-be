using System.Collections.Generic;
using System.Linq;

namespace haphaestusBe.Models
{
    public static class MockEmployees
    {
        public static IReadOnlyList<Employee> Employees => new List<Employee>
        {
            new Employee(0, new PersonName("Albert", "Barrows"), false, new PersonName("", ""), new List<PersonName>{
              new PersonName("Tyrone", "Barrows"),
              new PersonName("Valerie", "Barrows"),
            }),
            new Employee(1, new PersonName("Kenny", "Boyle"), true, new PersonName("Alma", "Boyle"), new List<PersonName>{
              new PersonName("Forrest", "Boyle"),
            }),
            new Employee(2, new PersonName("Marlene", "Hoeger"), true, new PersonName("Thelma", "Hoeger"), new List<PersonName>{
              new PersonName("Stephen", "Hoeger"),
              new PersonName("Hubert", "Hoeger"),
              new PersonName("Rose", "Hoeger"),
              new PersonName("Theresa", "Hoeger"),
            }),
            new Employee(3, new PersonName("Faye", "Padberg"), true, new PersonName("Ralph", "Padberg"), new List<PersonName>{
            }),
            new Employee(4, new PersonName("Hazel", "Mayer"), true, new PersonName("Suzanne", "Mayer"), new List<PersonName>{
            }),
            new Employee(5, new PersonName("Santiago", "Spinka"), true, new PersonName("Regina", "Spinka"), new List<PersonName>{
              new PersonName("Janice", "Spinka"),
              new PersonName("Kim", "Spinka"),
              new PersonName("Eileen", "Spinka"),
              new PersonName("Floyd", "Spinka"),
            }),
            new Employee(6, new PersonName("Jo", "Reynolds"), false, new PersonName("", ""), new List<PersonName>{
            }),
            new Employee(7, new PersonName("Darrin", "Harvey"), true, new PersonName("Yolanda", "Harvey"), new List<PersonName>{
            }),
            new Employee(8, new PersonName("Theresa", "McLaughlin"), false, new PersonName("", ""), new List<PersonName>{
            }),
            new Employee(9, new PersonName("Lauren", "Marvin"), false, new PersonName("", ""), new List<PersonName>{
            }),
            new Employee(10, new PersonName("Brandi", "Weber"), true, new PersonName("Belinda", "Weber"), new List<PersonName>{
              new PersonName("Jessie", "Weber"),
            }),
            new Employee(11, new PersonName("Colin", "McCullough"), false, new PersonName("", ""), new List<PersonName>{
              new PersonName("Kristen", "McCullough"),
              new PersonName("Charles", "McCullough"),
              new PersonName("Amelia", "McCullough"),
              new PersonName("Antonio", "McCullough"),
            }),
            new Employee(12, new PersonName("Rachael", "Leffler"), true, new PersonName("Franklin", "Leffler"), new List<PersonName>{
            }),
            new Employee(13, new PersonName("Angel", "Hegmann"), true, new PersonName("Ray", "Hegmann"), new List<PersonName>{
              new PersonName("Ernesto", "Hegmann"),
              new PersonName("Laverne", "Hegmann"),
            }),
            new Employee(14, new PersonName("Gregory", "McClure"), true, new PersonName("Manuel", "McClure"), new List<PersonName>{
              new PersonName("Tina", "McClure"),
              new PersonName("Eva", "McClure"),
              new PersonName("Carlton", "McClure"),
              new PersonName("Candice", "McClure"),
            }),
            new Employee(15, new PersonName("Delia", "Reichel"), false, new PersonName("", ""), new List<PersonName>{
            }),
            new Employee(16, new PersonName("Fredrick", "Rippin"), true, new PersonName("Eloise", "Rippin"), new List<PersonName>{
              new PersonName("Darrel", "Rippin"),
              new PersonName("Mona", "Rippin"),
              new PersonName("Ora", "Rippin"),
              new PersonName("Jacqueline", "Rippin"),
            }),
            new Employee(17, new PersonName("Matt", "Muller"), false, new PersonName("", ""), new List<PersonName>{
            }),
            new Employee(18, new PersonName("Mike", "Ferry"), true, new PersonName("Milton", "Ferry"), new List<PersonName>{
              new PersonName("Kay", "Ferry"),
              new PersonName("Kelly", "Ferry"),
            }),
            new Employee(19, new PersonName("Jeannette", "Kertzmann"), false, new PersonName("", ""), new List<PersonName>{
              new PersonName("Colleen", "Kertzmann"),
            }),
            new Employee(20, new PersonName("Cheryl", "Bashirian"), false, new PersonName("", ""), new List<PersonName>{
            }),
            new Employee(21, new PersonName("Kathryn", "Prohaska"), false, new PersonName("", ""), new List<PersonName>{
              new PersonName("Irene", "Prohaska"),
              new PersonName("Amelia", "Prohaska"),
              new PersonName("Jerry", "Prohaska"),
              new PersonName("Cathy", "Prohaska"),
            }),
            new Employee(22, new PersonName("Fredrick", "Cormier"), false, new PersonName("", ""), new List<PersonName>{
            }),
            new Employee(23, new PersonName("Saul", "Quitzon"), true, new PersonName("Roland", "Quitzon"), new List<PersonName>{
              new PersonName("Jeffrey", "Quitzon"),
              new PersonName("Roman", "Quitzon"),
              new PersonName("Glenda", "Quitzon"),
              new PersonName("Crystal", "Quitzon"),
            }),
            new Employee(24, new PersonName("Derek", "Towne"), true, new PersonName("Henrietta", "Towne"), new List<PersonName>{
              new PersonName("Ervin", "Towne"),
              new PersonName("Shawna", "Towne"),
              new PersonName("Bruce", "Towne"),
              new PersonName("Jesus", "Towne"),
              new PersonName("Tracy", "Towne"),
            }),
            new Employee(25, new PersonName("Mike", "Walsh"), false, new PersonName("", ""), new List<PersonName>{
              new PersonName("Louise", "Walsh"),
            }),
            new Employee(26, new PersonName("Mildred", "Connelly"), false, new PersonName("", ""), new List<PersonName>{
            }),
            new Employee(27, new PersonName("Elijah", "Hartmann"), false, new PersonName("", ""), new List<PersonName>{
            }),
            new Employee(28, new PersonName("Blanche", "Russel"), false, new PersonName("", ""), new List<PersonName>{
            }),
            new Employee(29, new PersonName("Dwayne", "Crona"), false, new PersonName("", ""), new List<PersonName>{
            }),
            new Employee(30, new PersonName("Cedric", "Berge"), true, new PersonName("Danny", "Berge"), new List<PersonName>{
              new PersonName("Edgar", "Berge"),
              new PersonName("Emmett", "Berge"),
              new PersonName("Lynn", "Berge"),
              new PersonName("Vicky", "Berge"),
              new PersonName("Carmen", "Berge"),
            }),
            new Employee(31, new PersonName("Leticia", "Baumbach"), false, new PersonName("", ""), new List<PersonName>{
              new PersonName("Roman", "Baumbach"),
              new PersonName("Inez", "Baumbach"),
              new PersonName("Joanne", "Baumbach"),
              new PersonName("Beulah", "Baumbach"),
              new PersonName("Kristina", "Baumbach"),
            }),
            new Employee(32, new PersonName("Christopher", "Stiedemann"), false, new PersonName("", ""), new List<PersonName>{
            }),
            new Employee(33, new PersonName("Lucy", "Daugherty"), true, new PersonName("Stacy", "Daugherty"), new List<PersonName>{
            }),
            new Employee(34, new PersonName("Janie", "Ratke"), true, new PersonName("Vera", "Ratke"), new List<PersonName>{
              new PersonName("Domingo", "Ratke"),
              new PersonName("Andrea", "Ratke"),
              new PersonName("Becky", "Ratke"),
            }),
            new Employee(35, new PersonName("Jeanette", "Grant"), false, new PersonName("", ""), new List<PersonName>{
            }),
            new Employee(36, new PersonName("Randall", "Schroeder"), true, new PersonName("Manuel", "Schroeder"), new List<PersonName>{
              new PersonName("Marianne", "Schroeder"),
              new PersonName("Martha", "Schroeder"),
              new PersonName("Fannie", "Schroeder"),
            }),
            new Employee(37, new PersonName("Jessie", "Barrows"), true, new PersonName("Iris", "Barrows"), new List<PersonName>{
              new PersonName("Jimmy", "Barrows"),
              new PersonName("Ervin", "Barrows"),
              new PersonName("Natasha", "Barrows"),
              new PersonName("Olga", "Barrows"),
            }),
            new Employee(38, new PersonName("Wanda", "Skiles"), true, new PersonName("Doris", "Skiles"), new List<PersonName>{
            }),
            new Employee(39, new PersonName("Terri", "Crist"), false, new PersonName("", ""), new List<PersonName>{
              new PersonName("Evelyn", "Crist"),
              new PersonName("Angie", "Crist"),
              new PersonName("Kurt", "Crist"),
            }),
            new Employee(40, new PersonName("Wendell", "Schaden"), false, new PersonName("", ""), new List<PersonName>{
            }),
            new Employee(41, new PersonName("Kellie", "Rosenbaum"), false, new PersonName("", ""), new List<PersonName>{
            }),
            new Employee(42, new PersonName("Darrell", "Lang"), false, new PersonName("", ""), new List<PersonName>{
            }),
            new Employee(43, new PersonName("Fredrick", "Tillman"), false, new PersonName("", ""), new List<PersonName>{
            }),
            new Employee(44, new PersonName("Tammy", "Hettinger"), false, new PersonName("", ""), new List<PersonName>{
            }),
            new Employee(45, new PersonName("May", "Kassulke"), false, new PersonName("", ""), new List<PersonName>{
              new PersonName("Darryl", "Kassulke"),
              new PersonName("Catherine", "Kassulke"),
              new PersonName("Ruby", "Kassulke"),
              new PersonName("Joseph", "Kassulke"),
              new PersonName("Sergio", "Kassulke"),
            }),
            new Employee(46, new PersonName("Paulette", "Schmeler"), true, new PersonName("Kenny", "Schmeler"), new List<PersonName>{
              new PersonName("Erika", "Schmeler"),
              new PersonName("Gerardo", "Schmeler"),
              new PersonName("Lois", "Schmeler"),
              new PersonName("Virgil", "Schmeler"),
            }),
            new Employee(47, new PersonName("Leslie", "Hartmann"), false, new PersonName("", ""), new List<PersonName>{
            }),
            new Employee(48, new PersonName("Ramiro", "Koch"), false, new PersonName("", ""), new List<PersonName>{
              new PersonName("Derek", "Koch"),
              new PersonName("Debra", "Koch"),
              new PersonName("Lori", "Koch"),
            }),
            new Employee(49, new PersonName("Kristin", "Runolfsson"), true, new PersonName("Virginia", "Runolfsson"), new List<PersonName>{
              new PersonName("Pat", "Runolfsson"),
              new PersonName("Harold", "Runolfsson"),
              new PersonName("Forrest", "Runolfsson"),
            }),
            new Employee(50, new PersonName("Gilbert", "Goodwin"), false, new PersonName("", ""), new List<PersonName>{
            }),
            new Employee(51, new PersonName("Sonya", "Russel"), false, new PersonName("", ""), new List<PersonName>{
              new PersonName("Kate", "Russel"),
              new PersonName("Christopher", "Russel"),
            }),
            new Employee(52, new PersonName("Perry", "Wisozk"), false, new PersonName("", ""), new List<PersonName>{
              new PersonName("Francisco", "Wisozk"),
            }),
            new Employee(53, new PersonName("Ross", "Kautzer"), false, new PersonName("", ""), new List<PersonName>{
            }),
            new Employee(54, new PersonName("Shelia", "Bartell"), false, new PersonName("", ""), new List<PersonName>{
            }),
            new Employee(55, new PersonName("Sherman", "VonRueden"), false, new PersonName("", ""), new List<PersonName>{
            }),
            new Employee(56, new PersonName("Cecilia", "Schneider"), true, new PersonName("Shane", "Schneider"), new List<PersonName>{
              new PersonName("Edith", "Schneider"),
              new PersonName("Cristina", "Schneider"),
              new PersonName("Jeffrey", "Schneider"),
              new PersonName("Manuel", "Schneider"),
            }),
            new Employee(57, new PersonName("Darryl", "Walter"), true, new PersonName("Anita", "Walter"), new List<PersonName>{
            }),
            new Employee(58, new PersonName("Lorenzo", "Schimmel"), true, new PersonName("Roberto", "Schimmel"), new List<PersonName>{
              new PersonName("Cody", "Schimmel"),
            }),
            new Employee(59, new PersonName("Andre", "Greenholt"), true, new PersonName("Mike", "Greenholt"), new List<PersonName>{
              new PersonName("Harry", "Greenholt"),
              new PersonName("Preston", "Greenholt"),
              new PersonName("Nettie", "Greenholt"),
              new PersonName("Delores", "Greenholt"),
            }),
            new Employee(60, new PersonName("Jerald", "Koch"), true, new PersonName("Ethel", "Koch"), new List<PersonName>{
              new PersonName("Nettie", "Koch"),
            }),
            new Employee(61, new PersonName("Randy", "Beier"), true, new PersonName("Margie", "Beier"), new List<PersonName>{
            }),
            new Employee(62, new PersonName("Harriet", "Denesik"), true, new PersonName("Darla", "Denesik"), new List<PersonName>{
              new PersonName("Jason", "Denesik"),
              new PersonName("Delia", "Denesik"),
              new PersonName("Lynn", "Denesik"),
              new PersonName("Alonzo", "Denesik"),
            }),
            new Employee(63, new PersonName("Sara", "Carter"), true, new PersonName("Cassandra", "Carter"), new List<PersonName>{
              new PersonName("Tammy", "Carter"),
              new PersonName("Marian", "Carter"),
              new PersonName("Timothy", "Carter"),
              new PersonName("Cecilia", "Carter"),
              new PersonName("Krystal", "Carter"),
            }),
            new Employee(64, new PersonName("Leslie", "Mitchell"), true, new PersonName("Dewey", "Mitchell"), new List<PersonName>{
              new PersonName("Norman", "Mitchell"),
            }),
            new Employee(65, new PersonName("Laverne", "Bergstrom"), false, new PersonName("", ""), new List<PersonName>{
              new PersonName("Judith", "Bergstrom"),
              new PersonName("Lewis", "Bergstrom"),
              new PersonName("Darrell", "Bergstrom"),
              new PersonName("Felipe", "Bergstrom"),
            }),
            new Employee(66, new PersonName("Stacey", "Sawayn"), false, new PersonName("", ""), new List<PersonName>{
            }),
            new Employee(67, new PersonName("Theodore", "Lynch"), true, new PersonName("Dean", "Lynch"), new List<PersonName>{
              new PersonName("Toby", "Lynch"),
            }),
            new Employee(68, new PersonName("Ramona", "Medhurst"), true, new PersonName("Douglas", "Medhurst"), new List<PersonName>{
              new PersonName("Alyssa", "Medhurst"),
            }),
            new Employee(69, new PersonName("Marcus", "Leffler"), false, new PersonName("", ""), new List<PersonName>{
            }),
            new Employee(70, new PersonName("Patti", "Collins"), false, new PersonName("", ""), new List<PersonName>{
            }),
            new Employee(71, new PersonName("Preston", "Berge"), false, new PersonName("", ""), new List<PersonName>{
            }),
            new Employee(72, new PersonName("Cody", "Mitchell"), false, new PersonName("", ""), new List<PersonName>{
              new PersonName("Lana", "Mitchell"),
              new PersonName("Stephanie", "Mitchell"),
            }),
            new Employee(73, new PersonName("Todd", "Walker"), true, new PersonName("Ricky", "Walker"), new List<PersonName>{
              new PersonName("Virginia", "Walker"),
              new PersonName("Pamela", "Walker"),
              new PersonName("Stella", "Walker"),
              new PersonName("Laurie", "Walker"),
            }),
            new Employee(74, new PersonName("Marco", "Harris"), true, new PersonName("Stella", "Harris"), new List<PersonName>{
            }),
            new Employee(75, new PersonName("Gustavo", "Lemke"), false, new PersonName("", ""), new List<PersonName>{
              new PersonName("Marlon", "Lemke"),
            }),
            new Employee(76, new PersonName("Donnie", "Daniel"), true, new PersonName("Mercedes", "Daniel"), new List<PersonName>{
              new PersonName("Eric", "Daniel"),
              new PersonName("Sarah", "Daniel"),
            }),
            new Employee(77, new PersonName("Lance", "Bruen"), true, new PersonName("Pam", "Bruen"), new List<PersonName>{
              new PersonName("Ellis", "Bruen"),
              new PersonName("Pamela", "Bruen"),
              new PersonName("Karl", "Bruen"),
              new PersonName("Andres", "Bruen"),
            }),
            new Employee(78, new PersonName("Wallace", "Casper"), true, new PersonName("Lawrence", "Casper"), new List<PersonName>{
              new PersonName("Grace", "Casper"),
              new PersonName("Sylvester", "Casper"),
              new PersonName("Ismael", "Casper"),
            }),
            new Employee(79, new PersonName("Leticia", "Daniel"), false, new PersonName("", ""), new List<PersonName>{
              new PersonName("Tami", "Daniel"),
              new PersonName("Michelle", "Daniel"),
            }),
            new Employee(80, new PersonName("Barbara", "Thompson"), false, new PersonName("", ""), new List<PersonName>{
            }),
            new Employee(81, new PersonName("Allan", "Romaguera"), true, new PersonName("Casey", "Romaguera"), new List<PersonName>{
            }),
            new Employee(82, new PersonName("Kent", "Dickens"), false, new PersonName("", ""), new List<PersonName>{
            }),
            new Employee(83, new PersonName("Edmund", "Turcotte"), true, new PersonName("Jacob", "Turcotte"), new List<PersonName>{
              new PersonName("Jo", "Turcotte"),
              new PersonName("Corey", "Turcotte"),
              new PersonName("Rolando", "Turcotte"),
              new PersonName("Clifton", "Turcotte"),
            }),
            new Employee(84, new PersonName("Travis", "Leffler"), false, new PersonName("", ""), new List<PersonName>{
            }),
            new Employee(85, new PersonName("Nadine", "Schowalter"), true, new PersonName("Grant", "Schowalter"), new List<PersonName>{
              new PersonName("Erica", "Schowalter"),
              new PersonName("Ernesto", "Schowalter"),
              new PersonName("Irvin", "Schowalter"),
              new PersonName("Sue", "Schowalter"),
            }),
            new Employee(86, new PersonName("Kerry", "Dibbert"), true, new PersonName("Elijah", "Dibbert"), new List<PersonName>{
            }),
            new Employee(87, new PersonName("Pauline", "O'Reilly"), true, new PersonName("Stephanie", "O'Reilly"), new List<PersonName>{
            }),
            new Employee(88, new PersonName("Susan", "Bosco"), true, new PersonName("Chad", "Bosco"), new List<PersonName>{
            }),
            new Employee(89, new PersonName("Frances", "Kuhic"), true, new PersonName("Calvin", "Kuhic"), new List<PersonName>{
            }),
            new Employee(90, new PersonName("Kristina", "Swaniawski"), true, new PersonName("Boyd", "Swaniawski"), new List<PersonName>{
              new PersonName("Dorothy", "Swaniawski"),
              new PersonName("Erin", "Swaniawski"),
              new PersonName("Lindsey", "Swaniawski"),
              new PersonName("Ellis", "Swaniawski"),
            }),
            new Employee(91, new PersonName("Brett", "Ryan"), false, new PersonName("", ""), new List<PersonName>{
            }),
            new Employee(92, new PersonName("Angie", "DuBuque"), true, new PersonName("Nelson", "DuBuque"), new List<PersonName>{
            }),
            new Employee(93, new PersonName("Geneva", "Franecki"), true, new PersonName("Allan", "Franecki"), new List<PersonName>{
              new PersonName("Rosa", "Franecki"),
              new PersonName("Heidi", "Franecki"),
            }),
            new Employee(94, new PersonName("Nicole", "Emmerich"), true, new PersonName("Kate", "Emmerich"), new List<PersonName>{
              new PersonName("Angie", "Emmerich"),
            }),
            new Employee(95, new PersonName("Leona", "Schmitt"), false, new PersonName("", ""), new List<PersonName>{
              new PersonName("Terry", "Schmitt"),
              new PersonName("Ivan", "Schmitt"),
              new PersonName("Emilio", "Schmitt"),
              new PersonName("Carlton", "Schmitt"),
            }),
            new Employee(96, new PersonName("Flora", "Hyatt"), false, new PersonName("", ""), new List<PersonName>{
              new PersonName("Elisa", "Hyatt"),
            }),
            new Employee(97, new PersonName("April", "Bernier"), true, new PersonName("Wilson", "Bernier"), new List<PersonName>{
              new PersonName("Ross", "Bernier"),
              new PersonName("Mildred", "Bernier"),
              new PersonName("Deanna", "Bernier"),
              new PersonName("Iris", "Bernier"),
              new PersonName("Felix", "Bernier"),
            }),
            new Employee(98, new PersonName("Randy", "Homenick"), true, new PersonName("Linda", "Homenick"), new List<PersonName>{
              new PersonName("Nicole", "Homenick"),
            }),
            new Employee(99, new PersonName("Felipe", "Larkin"), true, new PersonName("Jeremy", "Larkin"), new List<PersonName>{
              new PersonName("Ramon", "Larkin"),
              new PersonName("Elijah", "Larkin"),
            })
        }.OrderBy(e => e.Name.LastName).ThenBy(e => e.Name.FirstName).ToList();
    }
}
