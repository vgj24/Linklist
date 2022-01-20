// See https://aka.ms/new-console-template for more information
using LinkLIstProgramAssgn;

Console.WriteLine("Link List Assignment");
#region linklist
LinkLIstAssign list = new LinkLIstAssign();
//Console.WriteLine("Adding 56,30,70 to linked list");
//list.Add(56);
//list.Add(30);
//list.Add(70);
//list.Display();

//Console.WriteLine("adding 70,,30 ,56 t list ");
//list.Add(70);
//list.Add(56);
//list.Display();

//Console.WriteLine("Adding 56 then 30 then 70");
//list.Add(56);
//list.Add(30);
//list.Add(70);

//Console.WriteLine("adding 56 and 70 to list");
//list.Add(56);
//list.Add(70);
//list.Display();
//Console.WriteLine("\n adding at 30 between 56 and 70 perticuler position", list.insertAtPerticularPosition(2, 30));
//list.Display();
//Console.WriteLine("\n Searching node 30");
//list.Search(30);
//Console.WriteLine("\n adding 40 after 30 ", list.Searchnew());
//list.Display();
//Console.WriteLine("\n remove 40 from list ");
//list.Search(40);

//list.removeFirstnode();
//list.Display();
//Console.WriteLine("\n");
list.Add(56);
list.Add(30);
list.Add(70);
list.Display();

//Console.WriteLine("\n Remove first element ", list.removeFirstnode());
//list.Display();

//Console.WriteLine("\n Remove last node from list", list.removeLastnode());
//list.Display();

Console.WriteLine("\n organized list is ");
list.Organizedlist();
list.Display();

Console.ReadKey();

#endregion