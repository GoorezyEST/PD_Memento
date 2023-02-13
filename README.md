# Memento

The Memento pattern is a design pattern that provides a way to save and restore the state of an object. The main idea behind the pattern is to allow the state of an object to be captured and stored externally, so that it can be restored later if needed.

In the Memento pattern, there are three main classes involved:

•The Originator class, which represents the object whose state we want to save.
•The Memento class, which is used to capture and store the state of the Originator.
•The Caretaker class, which is responsible for storing and retrieving the Memento objects.

The Originator class has methods for creating a Memento (CreateMemento) and for restoring its state from a Memento (SetMemento). The Memento class is usually implemented as an immutable object, with its state being set in its constructor and a method for retrieving it. The Caretaker class is used to store a list of Memento objects and provide methods for adding and retrieving them.

The Memento pattern provides a way to save the state of an object while still maintaining the separation of concerns between the object and the caretaker. This allows the Originator to change its internal state without affecting the ability to restore previous states.

In summary, the Memento pattern is a useful tool for saving and restoring the state of an object in a way that is flexible and easy to maintain.