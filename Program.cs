namespace Memento_PD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            Caretaker caretaker = new Caretaker();

            originator.State = "State #1";
            originator.State = "State #2";
            caretaker.Add(originator.CreateMemento());

            originator.State = "State #3";
            caretaker.Add(originator.CreateMemento());

            originator.State = "State #4";
            Console.WriteLine("Current State: " + originator.State);

            originator.SetMemento(caretaker.Get(0));
            Console.WriteLine("First saved State: " + originator.State);
            originator.SetMemento(caretaker.Get(1));
            Console.WriteLine("Second saved State: " + originator.State);

            Console.ReadKey();

        }
    }
}