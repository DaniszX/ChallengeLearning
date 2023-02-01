using Dzień_6;

User user1 = new User("Anakin", "Vader");
User user2 = new User("Kenobi", "ObiWan");
User user3 = new User("Padme", "Amidala");
User user4 = new User("JarJar", "Secret_Sith");

user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
Console.WriteLine(result);
var name = User.GameName;
var pie = Math.PI;

List<User> users = new List<User>()
{
    user1, user2, user3
};

int maxResult = -1;
User employeeWithHighestGrade = null;

foreach (var user in users)
{
    if (user.Result > maxResult)
    {
        employeeWithHighestGrade = user;
    }
}