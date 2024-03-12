using System;
using System.Linq;

//This is high level
class Program
{
    static void Main(string[] args)
    {
        //Define persons
        var parent = new Person { Name = "John" };
        var child1 = new Person { Name = "Chris" };
        var child2 = new Person { Name = "Mary" };

        //Add relationships between people
        var relationships = new Relationships();
        relationships.AddParentAndChild(parent, child1);
        relationships.AddParentAndChild(parent, child2);

        //List relationships
        ListRelationships(relationships);

        Console.ReadKey();
    } //Main

    private static void ListRelationships(Relationships relationships)
    {
        //Find all of John's children through accessing the low-level Relations property
        var relations = relationships.Relations;
        foreach (var r in relations.Where(   x => x.Item1.Name == "John"
                                          && x.Item2 == Relationship.Parent))
            Console.WriteLine($"John has a child called {r.Item3.Name}");
    } //ListRelationships

} //class Program

