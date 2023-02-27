using DatingApp.Entities;

namespace DatingApp.Data.Fake
{
    public class FakeUserGenerator
    {
        public FakeUserGenerator(Random? random)
        {
            if (random == null)
            {
                throw new ArgumentNullException(nameof(random));
            }

            Random = random;
        }

        public FakeUserGenerator()
        {
            Random = new Random();
        }

        public Random Random { get; set; }

        // Female first names
        public string[] FemaleFirstNames { get; set; } = new string[] {
            "Emma", "Olivia", "Ava", "Isabella", "Sophia", "Mia", "Charlotte", "Amelia", "Harper", "Evelyn",
            "Abigail", "Emily", "Elizabeth", "Mila", "Ella", "Avery", "Sofia", "Camila", "Aria", "Scarlett",
            "Victoria", "Madison", "Luna", "Grace", "Chloe", "Penelope", "Layla", "Riley", "Zoey", "Nora",
            "Lily", "Eleanor", "Hannah", "Lillian", "Addison", "Aubrey", "Ellie", "Stella", "Natalie", "Zoe",
            "Leah", "Hazel", "Violet", "Aurora", "Savannah", "Audrey", "Brooklyn", "Bella", "Claire", "Skylar",
            "Lucy", "Paisley", "Everly", "Anna", "Caroline", "Nova", "Genesis", "Emilia", "Kennedy", "Samantha",
            "Maya", "Willow", "Kinsley", "Aaliyah", "Adalyn", "Aurora", "Brielle", "Charlie", "Elliana", "Eloise",
            "Esme", "Fatima", "Gemma", "Gianna", "Hailey", "Iris", "Jasmine", "Jocelyn", "Lana", "Lia",
            "Lydia", "Makayla", "Malia", "Nyla", "Reese", "Rowan", "Sage", "Sienna", "Summer", "Tessa"
        };

        // Male first names
        public string[] MaleFirstNames { get; set; } = new string[] {
            "Liam", "Noah", "Oliver", "Elijah", "William", "James", "Benjamin", "Lucas", "Henry", "Alexander",
            "Mason", "Michael", "Ethan", "Daniel", "Jacob", "Logan", "Jackson", "Levi", "Sebastian", "Mateo",
            "Jayden", "Caleb", "Luke", "Grayson", "Jack", "Ryan", "Connor", "Olivia", "Adam", "Nicholas",
            "Owen", "Wyatt", "Nathan", "Isaac", "Leo", "Lincoln", "Ezra", "Hudson", "Aiden", "Gabriel",
            "Carter", "Matthew", "Samuel", "David", "Joseph", "Asher", "Dylan", "Christopher", "John", "Isaiah",
            "Elliott", "Jonathan", "Nolan", "Hunter", "Christian", "Julian", "Aaron", "Elias", "Roman", "Xavier",
            "Tyler", "Jameson", "Miles", "William", "Evan", "Brayden", "Cole", "Ian", "Dominic", "Adam",
            "Carson", "Maverick", "Cooper", "Micah", "Jaxon", "Blake", "Maxwell", "Jace", "Ryder", "Jeremy"
        };

        // Last names
        public string[] LastNames { get; set; } = new string[] {
            "Smith", "Johnson", "Brown", "Taylor", "Anderson", "Thomas", "Jackson", "White", "Harris", "Martin",
            "Thompson", "Moore", "Young", "Allen", "Wright", "King", "Scott", "Green", "Baker", "Adams",
            "Nelson", "Carter", "Mitchell", "Perez", "Roberts", "Turner", "Phillips", "Campbell", "Parker", "Evans",
            "Edwards", "Collins", "Stewart", "Sanchez", "Morris", "Rogers", "Reed", "Cook", "Morgan", "Bell",
            "Murphy", "Bailey", "Rivera", "Cooper", "Richardson", "Cox", "Howard", "Ward", "Torres", "Peterson",
            "Gray", "Ramirez", "James", "Watson", "Brooks", "Kelly", "Sanders", "Price", "Bennett", "Wood",
            "Barnes", "Ross", "Henderson", "Coleman", "Jenkins", "Perry", "Powell", "Long", "Patterson", "Hughes",
            "Flores", "Washington", "Butler", "Simmons", "Foster", "Gonzales", "Bryant", "Alexander", "Russell", "Griffin",
            "Diaz", "Hayes", "Myers", "Ford", "Hamilton", "Graham", "Sullivan", "Wallace", "Woods", "Cole",
            "West", "Jordan", "Owens", "Reynolds", "Fisher", "Ellis", "Harrison", "Gibson", "Mcdonald", "Cruz",
            "Marshall", "Ortiz", "Gomez", "Murray", "Freeman", "Wells", "Webb", "Simpson", "Stevens", "Tucker"
        };

        /// <summary>
        /// Returns an enumerable of users that are generated endlessly.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AppUser> GetAppUsers()
            => GetAppUsers(-1);

        /// <summary>
        /// Returns an enumerable of users.
        /// </summary>
        /// <param name="amount">The amount of users to generate. If the <paramref name="amount"/>
        /// is less than 0, the users will be generated endlessly.</param>
        /// <returns></returns>
        public IEnumerable<AppUser> GetAppUsers(int amount)
        {
            while (amount < 0 || amount > 0)
            {
                string firstName;
                if (Random.Next() % 2 == 0)
                {
                    firstName = MaleFirstNames[Random.Next(MaleFirstNames.Length)];
                }
                else
                {
                    firstName = FemaleFirstNames[Random.Next(FemaleFirstNames.Length)];
                }

                yield return new AppUser
                {
                    UserName = $"{firstName} {LastNames[Random.Next(LastNames.Length)]}"
                };

                amount--;
            }
        }
    }
}
