//Nesteruk, Video 7
//Scenario: Genealogy application

//Relationships between people
using System.Collections.Generic;

//Possible relationships between people
public enum Relationship
{
    Parent,
    Child,
    Sibling
} //enum Relationships

//Low level
public class Relationships
{
    //Private list
    //- Use the C#7 tuples
    //  Person from which, relationshiop, applies to person
    private List<(Person, Relationship, Person)> relations = new List<(Person, Relationship, Person)>();

    //Property getter of private list
    //- Nesteruk: "Now the problem with this scenario and the reason why the dependency inversion 
    //             principle exists is that's we are accessing a very low level part of the relationships
    //             class. We are accessing its data store and we are accessing it through specifically
    //             designed property which exposes the private thing has public. And what this means
    //             in practice is that relationships cannot change its mind about how to store the
    //             relationships."
    //  We can, for instance, not change the data stire to use a dictionary instead of tuples since since
    //  the higher level classes depends on the way the data is stored. I'm going to start using a dictionary and I'm going to remove this duplication as well or something
    public List<(Person, Relationship, Person)> Relations => relations;

    public void AddParentAndChild(Person parent, Person child)
    {
        relations.Add((parent, Relationship.Parent, child));
        relations.Add((child, Relationship.Child, parent));
    } //AddParentAndChild
} //Relationships

