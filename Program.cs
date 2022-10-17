using LinkedListProgram;


LinkedList list = new LinkedList();
list.Add(56);
list.Add(30);
list.Add(70);

LinkedListAdd Linkedlist = new LinkedListAdd();
//Insert 70 At Staring.
Linkedlist.Add(70);
//Inserted 30 To 70
Linkedlist.Add(30);
//Inserted 56 To 30
Linkedlist.Add(56);
//Display The Linkedlist.
Linkedlist.Display();

// Create Object Of Implementing Class.
LinkedListAppend linkedList = new LinkedListAppend();
//Insert 56 At Staring.
linkedList.Add(56);
//Append 30 To 56.
linkedList.Append(30);
//Append 70 To 30.
linkedList.Append(70);
//Display The Linkedlist.
Linkedlist.Display();

PopMethod popMethod = new PopMethod();
popMethod.Add(56);
popMethod.Add(30);
popMethod.Add(70);
Console.WriteLine("______________");
popMethod.Display();
Console.WriteLine("______________");
Console.WriteLine("Element Popped out from the list");
popMethod.pop();
popMethod.Display();

Pop pop = new Pop();
pop.Add(56);
pop.Add(30);
pop.Add(70);
Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
pop.Display();
Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
Console.WriteLine("Element Popped out from the list");
pop.popLast();
pop.Display();
Console.WriteLine("_____________");

Console.WriteLine("Output For Element Inserted At a Particular Position Using Insert Method");
InsertBetween insertInBetween = new InsertBetween();
insertInBetween.Add(56);
insertInBetween.Append(70);
//Creating object of Node class and passing data. 
//Here 30 is Inserted To The List.
Node node = new Node(30);
Console.WriteLine("Element Inserted In Between ,The List After 56 : {0}", node.data, " ");
Console.WriteLine("So After Inserting The Final List Appears As :");
Console.WriteLine("____________");
insertInBetween.Insert(56, node);
insertInBetween.Display();

Console.WriteLine("Output For Search  Particular Element using Search Method from the List");
Console.WriteLine("Adding Elements as follows :");
Console.WriteLine("_________________");
SearchLinkedList search = new SearchLinkedList();
search.Add(56);
search.Add(30);
search.Add(70);
Console.WriteLine("___________________");
search.Display();
Console.WriteLine("____________________");
Console.WriteLine("After searching for a Particular Element ");
search.Search(30);
Console.WriteLine("__________________");
