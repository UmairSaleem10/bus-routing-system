//*/ See https://aka.ms/new-console-template for more information*/
/*Console.WriteLine("Hello, World!");
Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
List<string> route = new List<string>();
route.Add("Gulberg");
dict.Add("Mughalpura", route);
dict.Add("Dhrampura", route);

foreach (string key in dict.Keys)
{
    Console.Write(key + " = ");
    foreach (string val in dict[key])
    {
        Console.Write(val+ ", ");
    }
    Console.WriteLine();
}
class Dictionaries
{
 
        

    
}*/

using Graph_implementation__C_sharp_;
using System;

var vertices = new[] { Tuple.Create("Badami Bagh", true),Tuple.Create("Shad Bagh", true), Tuple.Create("China Scheme", true), Tuple.Create("Data Nagar", true), Tuple.Create("Kot Khawaja Seed", true),
                       Tuple.Create("Misri Shah", true), Tuple.Create("Data Darbar", true), Tuple.Create("Lahore Meuseum", true), Tuple.Create("Islampura", true), Tuple.Create("Mazang Chungi", true),
                       Tuple.Create("Gulshan Ravi", true), Tuple.Create("Lahore Zoo", true), Tuple.Create("Bagh-e-Jinnah", true), Tuple.Create("Samanabad", true), Tuple.Create("Iqbal Town", true),
                       Tuple.Create("Shadman", true), Tuple.Create("Ichra", true), Tuple.Create("Muslim Town", true), Tuple.Create("Gaddafi Stadium", true), Tuple.Create("Model Town", true),
                       Tuple.Create("Township", true), Tuple.Create("Walton", true),Tuple.Create("DHA phase-5", true), Tuple.Create("DHA phase-6", true), Tuple.Create("Green Town", true), Tuple.Create("Faisal Town", true),
                       Tuple.Create("Johar Town", true), Tuple.Create("Ali Town", true), Tuple.Create("Thokar Niaz Baig", true), Tuple.Create("Jail Road", true), Tuple.Create("Mall Road", true), Tuple.Create("Dhrampura", true),
                       Tuple.Create("Mughalpura", true), Tuple.Create("Tajpura", true), Tuple.Create("Harbanspura", true), Tuple.Create("Jallo Park", true), Tuple.Create("Wahga Border", true), Tuple.Create("Shalamar Garden", true),
                       Tuple.Create("UET", true),Tuple.Create("Masjid Wazir Khan", true), Tuple.Create("Shahadrah", true), Tuple.Create("Cantt", true), Tuple.Create("Sadar-Lahore", true), Tuple.Create("Allama Iqbal International Airport", true),
                       Tuple.Create("Lahore Railway Station", true), Tuple.Create("Mochi Gate", false), Tuple.Create("Harbanspura", false), Tuple.Create("Al-Hafeez Garden", false), 
                       Tuple.Create("Lahore Medical and Dental College", false), Tuple.Create("Harbanspura Police Station", false), Tuple.Create("Tajbagh", false), Tuple.Create("Ghaziabad", false), Tuple.Create("New Officers Colony", false),
                       Tuple.Create("RA-Bazar", false), Tuple.Create("University of South Asia", false), Tuple.Create("PAF College", false), Tuple.Create("Cavalary Ground", false), Tuple.Create("Ramgarh", false), Tuple.Create("Singhpura", false),
                       Tuple.Create("Baghbanpura", false),Tuple.Create("Garhi Shahu", false), Tuple.Create("Delhi Gate", false), Tuple.Create("Mochi Gate", false), Tuple.Create("Kashmiri Gate", false), Tuple.Create("Urdu Bazar", false), Tuple.Create("Gawalmandi", false), Tuple.Create("GCU", false), Tuple.Create("NCA", false),
                       Tuple.Create("Anarkali", false), Tuple.Create("Miani Sahib", false), Tuple.Create("Chauburji", false), Tuple.Create("Tollinton Market", false), Tuple.Create("Macleod Road", false), Tuple.Create("Hall Road", false), Tuple.Create("Punjab Assembly", false),Tuple.Create("Atchison College", false), Tuple.Create("Zaman Park", false),
                       Tuple.Create("Race Course Park", false), Tuple.Create("Services Hospital", false), Tuple.Create("Gulberg", false), Tuple.Create("Hafeez Centre", false), Tuple.Create("Sheikh Zayed Hospital", false), Tuple.Create("Punjab University", false),
                       Tuple.Create("Gulshan Iqbal Park", false), Tuple.Create("Allama Iqbal Open University", false), Tuple.Create("FAST University", false), Tuple.Create("Allama Iqbal Medical College", false), Tuple.Create("Jinnah Hospital", false), Tuple.Create("Doctors Hospital", false), Tuple.Create("Emporium Mall", false),
                       Tuple.Create("UCP", false), Tuple.Create("UMT", false), Tuple.Create("Bahria Town", false), Tuple.Create("Valencia", false), Tuple.Create("LDA Avenue", false), Tuple.Create("Wapda Town", false), Tuple.Create("UOL", false), Tuple.Create("DHA phase-8", false), Tuple.Create("LUMS", false),
                       Tuple.Create("Paragon City", false), Tuple.Create("Daroghewala", false), Tuple.Create("Dera Gujran", false)};
 
var edges = new[] { Tuple.Create("Badami Bagh", "Shad Bagh", 2.3, true),
                    Tuple.Create("Badami bagh", "Shahadrah", 6.1, true), 
                    Tuple.Create("Badami Bagh", "Data Nagar", 7.4, true),
                    Tuple.Create("Data Nagar", "Data Darbar", 3.6, true),
                    Tuple.Create("Data Nagar", "Misri Shah", 2.1, true),
                    Tuple.Create("Data Darbar", "Misri Shah", 4.9, true),
                    Tuple.Create("Data Darbar", "Lahore Meuseum", 2.2, true),
                    Tuple.Create("Data Darbar", "Masjid Wazir Khan", 3.7, true),
                    Tuple.Create("Lahore Meuseum", "Islampura", 1.7, true),
                    Tuple.Create("Lahore Meuseum", "Mazang Chungi", 1.5, true),
                    Tuple.Create("Islampura", "Mazang Chungi", 1.8, true),
                    Tuple.Create("Islampura", "Gulsahan Ravi", 3.0, true),
                    Tuple.Create("Samanabad", "Gulsahan Ravi", 3.7, true),
                    Tuple.Create("Samanabad", "Iqbal Town", 3.4, true),
                    Tuple.Create("Mazang Chungi", "Lahore Zoo", 2.1, true),
                    Tuple.Create("Bagh-e-Jinnah", "Lahore Zoo", 0.4, true),
                    Tuple.Create("Bagh-e-Jinnah", "Shadman", 2.1, true),
                    Tuple.Create("Samanabad", "Ichra", 3.5, true),
                    Tuple.Create("Muslim Town", "Gaddafi Stadium", 1.6, true),
                    Tuple.Create("Model Town", "Gaddafi Stadium", 5.0, true),
                    Tuple.Create("Model Town", "Township", 4.6, true),
                    Tuple.Create("Walton", "Township", 13.0, true),
                    Tuple.Create("Walton", "Gaddafi Stadium", 8.8, true),
                    Tuple.Create("Walton", "DHA phase-5", 2.7, true),
                    Tuple.Create("Walton", "DHA phase-6", 8.8, true),
                    Tuple.Create("DHA phase-5", "DHA phase-6", 7.3, true),
                    Tuple.Create("Model Town", "Green Town", 7.2, true),
                    Tuple.Create("Model Town", "Faisal Town", 2.3, true),
                    Tuple.Create("Model Town", "Johar Town", 6.9, true),
                    Tuple.Create("Faisal Town", "Johar Town", 4.8, true),
                    Tuple.Create("Faisal Town", "Green Town", 7.6, true),
                    Tuple.Create("Johar Town", "Ali Town", 3.4, true),
                    Tuple.Create("Johar Town", "Thokar Niaz Baig", 6.9, true),
                    Tuple.Create("Ichra", "Jail Road", 5.6, true),
                    Tuple.Create("Mall Road", "Jail Road", 5.5, true),
                    Tuple.Create("Mall Road", "Dhrampura", 2.1, true),
                    Tuple.Create("Mughalpura", "Dhrampura", 4.4, true),
                    Tuple.Create("Mughalpura", "Tajpura", 6.1, true),
                    Tuple.Create("Mughalpura", "Sadar-Lahore", 4.5, true),
                    Tuple.Create("Mughalpura", "Shalamar Garden", 5.1, true),
                    Tuple.Create("UET", "Shalamar Garden", 2.9,true),
                    Tuple.Create("UET", "Masjid Wazir Khan", 6.1,true),
                    Tuple.Create("Cantt", "Sadar-Lahore", 4.3,true),
                    Tuple.Create("Cantt", "Allama Iqbal International Airport", 9.8, true),
                    Tuple.Create("Harbanspura", "Tajpura", 5.1, true),
                    Tuple.Create("Harbanspura", "Jallo Park", 6.7, true),
                    Tuple.Create("Wahga Border", "Jallo Park", 14.0, true),
                    Tuple.Create("Iqbal Town", "Faisal Town", 5.1, true),
                    Tuple.Create("Shad Bagh", "Data Nagar", 2.4, true),
                    Tuple.Create("Shad Bagh", "China Scheme", 3.0, true),
                    Tuple.Create("Kot Khawaja Saeed", "China Scheme", 1.9, true),
                    Tuple.Create("Misri Shah", "Masjid Wazir Khan", 1.9, true),
                    Tuple.Create("Harbanspura", "Tajbagh", 2.8, false),
                    Tuple.Create("Harbanspura", "Harbanspura Police Station", 1.8, false),
                    Tuple.Create("Harbanspura", "Lahore Medical and Dental College", 4.4, false),
                    Tuple.Create("Harbanspura", "Al-Hafeez Garden", 4.8, false),
                    Tuple.Create("Harbanspura", "Sozo Water Park", 2.1, false),
                    Tuple.Create("Sadar-Lahore", "Ghaziabad", 2.6, false),
                    Tuple.Create("Sadar-Lahore", "New Officers Colony", 0.6, false),
                    Tuple.Create("Cantt", "RA-Bazar", 2.9, false),
                    //Tuple.Create("Cantt", "Askari 1", 3.5, false),
                    Tuple.Create("Cantt", "University of South Asia", 2.3, false),
                    Tuple.Create("Cantt", "Mall of Lahore", 1.8, false),
                    Tuple.Create("Cantt", "PAF College", 0.8, false),
                    Tuple.Create("Cantt", "Cavalry Ground", 4.4, false),
                    Tuple.Create("Mughalpura", "Ramgarh", 3.7, false),
                    Tuple.Create("UET", "Singhpura", 0.9, false),
                    Tuple.Create("UET", "Baghbanpura", 2.2, false),
                    Tuple.Create("UET", "Garhi Shahu", 4.6, false),
                    Tuple.Create("Lahore Railway Station", "Delhi Gate", 1.3, false),
                    Tuple.Create("Lahore Railway Station", "Mochi Gate", 2.4, false),
                    Tuple.Create("Lahore Railway Station", "Kashmiri Gate", 2.5, false),
                    Tuple.Create("Lahore Meuseum", "Urdu Bazar", 1.1, false),
                    Tuple.Create("Lahore Meuseum", "Gawalmandi", 2.5, false),
                    Tuple.Create("Lahore Meuseum", "GCU", 0.45, false),
                    Tuple.Create("Lahore Meuseum", "NCA", 0.2, false),
                    Tuple.Create("Lahore Meuseum", "Anarkali", 0.5, false),
                    Tuple.Create("Samanabad", "Miani Sahib Graveyard", 3.5, false),
                    Tuple.Create("Samanabad", "Chauburji", 3.3, false),
                    Tuple.Create("Samanabad", "Tollinton Market", 4.2, false),
                    Tuple.Create("Mall Road", "Macleod Road", 2.9, false),
                    Tuple.Create("Mall Road", "Atchison College", 1.6, false),
                    Tuple.Create("Mall Road", "Hall Road", 2.4, false),
                    Tuple.Create("Mall Road", "Punjab Assembly", 1.7, false),
                    Tuple.Create("Mall Road", "Zaman Park", 2.4, false),
                    Tuple.Create("Jail Road", "Race Course Park", 3.2, false),
                    Tuple.Create("Jail Road", "Services Hospital", 0.6, false),
                    Tuple.Create("Shadman", "Gulberg", 4.8, false),
                    Tuple.Create("Shadman", "Hafeez Centre", 3.7, false),
                    Tuple.Create("Iqbal Town", "Sheikh Zayed Hospital", 3.6, false),
                    Tuple.Create("Iqbal Town", "Punjab University", 4.2, false),
                    Tuple.Create("Iqbal Town", "Gulshan Iqbal Park", 0.5, false),
                    Tuple.Create("Iqbal Town", "Allama Iqbal Open University", 1.0, false),
                    Tuple.Create("Faisal Town", "FAST University", 1.0, false),
                    Tuple.Create("Faisal Town", "Allama Iqbal Medical College", 2.0, false),
                    Tuple.Create("Faisal Town", "Jinnah Hospital", 1.7, false),
                    Tuple.Create("Johar Town", "Doctors Hospital", 1.7, false),
                    Tuple.Create("Johar Town", "Emporium Mall", 1.5, false),
                    Tuple.Create("Johar Town", "UMT", 4.1, false),
                    Tuple.Create("Johar Town", "UCP", 5.4, false),
                    Tuple.Create("Thokar Niaz Baig", "Bahria Town", 18.4, false),
                    Tuple.Create("Thokar Niaz Baig", "Valencia", 13.9, false),
                    Tuple.Create("Thokar Niaz Baig", "LDA Avenue", 11.7, false),
                    Tuple.Create("Thokar Niaz Baig", "Wapda Town", 9.5, false),
                    Tuple.Create("Thokar Niaz Baig", "UOL", 15.2, false),
                    Tuple.Create("Allama Iqbal International Airport", "DHA phase-8", 8.2, false),
                    Tuple.Create("Allama Iqbal International Airport", "LUMS", 8.3, false),
                    Tuple.Create("Allama Iqbal International Airport", "Paragon City", 9.1, false),
                    Tuple.Create("Shalamar Garden", "Daroghewala", 2.4, false),
                    Tuple.Create("Shalamar Garden", "Dera Gujran", 6.8, false)
                    };

Buses bus1 = new Buses("LED-2198", 2007, 52, new (2023, 01, 04, 13, 00, 00));
Buses bus2 = new Buses("LER-3241", 2012, 60, new (2023, 01, 04, 15, 00, 00));
Buses bus3 = new Buses("ADH-1098", 2002, 45, new (2023, 12, 04, 11, 00, 00));
Buses bus4 = new Buses("BRG-2100", 2014, 65, new (2023, 12, 04, 21, 00, 00));
Buses bus5 = new Buses("LED-1000", 2017, 60, new (2023, 12, 04, 19, 00, 00));

DateTime dt = new DateTime(2002, 12, 03, 13, 00, 00);

var graph=new Graph_implementation__C_sharp_.Graph(vertices, edges);
graph.printGraph();
//var bfs = new BFS();

//BFS.BFScode(graph, "Cantt");
var totalEdge = graph.totalEdges();
Console.WriteLine("Total number of edges in the graph: " + totalEdge);
//graph.displayMap();
Dictionary<string, bool> processed=new Dictionary<string, bool>();
bool pathexists = graph.hasPath(Tuple.Create("Faisal Town", true), Tuple.Create("Badami Bagh", true), processed);
Console.WriteLine(pathexists);
graph.displayStations();
/*Console.WriteLine(string.Join(", ", BFS.BFScode(graph, "Jail Road")));
*/

double dist = graph.Dijkistra(Tuple.Create("Mughalpura", true), Tuple.Create("Faisal Town", true));
int fare = graph.calculateFare(dist);
Console.WriteLine(dist + " km" + " and fare will be Rs." + fare + " in " + graph.calculateEstimatedTime(dist) + " min.");

/*Console.WriteLine(dt);
Console.WriteLine(bus5.time);

var dt1 = DateTime.Now.ToString("hh:mm:ss");
Console.WriteLine(bus5.model + " (" + bus5.year + ") " + "is travelling at " + bus5.time);
*/