// See https://aka.ms/new-console-template for more information
using AddDataOnMemory;

Console.WriteLine("Hello, World!");

var states = new List<string>
{
    "Miami",
    "Illinois",
    "New York",
    "Texas",
    "California",
    "Georgia",
    "Washington",
    "Alaska",
    "Hawaii",
    "Virginia",
    "New Jersey",
    "Pennsylvania",
    "North Carolina",
    "Colorado",
    "Arizona",
    "Ohio",
    "Michigan",
    "Minnesota"
};

//memory cache library
var memory = new MemoryCacheLibrary.Main();

//set values
memory.SetCache("myStates", states, 8, 0, 0);


var simpleSite = "www.mauriciojunior.net";
memory.SetCache("site", simpleSite);


//using custom class
var user = new UserModel
{
    IdUser = 1,
    NameUser = "Mauricio Junior",
    EmailUser = "a@a.com"
};

//set values
memory.SetCache<UserModel>("myUsers", user);


//get values
var _states = memory.GetCache("myStates") as List<string>;
foreach(var state in _states)
{
    Console.WriteLine(state);
}


var _users = memory.GetCache<UserModel>("myUsers");
Console.WriteLine(_users.NameUser);

Console.WriteLine(memory.GetCache("site"));
