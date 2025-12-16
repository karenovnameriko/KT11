//Напишите обобщенный класс LinkedList<T>, который реализует структуру данных связный список для хранения элементов типа T.
//Затем напишите ограничение для этого класса, чтобы он мог работать только с типами, которые являются ссылочными типами (class).
//Затем напишите методы Add(T item), Remove(T item) и Contains(T item), которые добавляют, удаляют и проверяют наличие элемента в
//списке соответственно. Затем напишите пример использования этого класса для хранения объектов типов string, Person и Book.
namespace KT11_2;

class Program
{
    class LinkedList<T> where T: class
    {
        private class Node
        {
            public T Value;
            public Node Next;

            public Node(T value)
            {
                Value = value;
                Next = null;
            }
        }

        private Node head;

        public void Add(T item)
        {
            Node newNode = new Node(item);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }

        public bool Contains(T item)
        {
            Node current = head;

            while (current != null)
            {
                if (current.Value.Equals(item))
                    return true;

                current = current.Next;
            }

            return false;
        }

        public bool Remove(T item)
        {
            if (head == null)
                return false;

            if (head.Value.Equals(item))
            {
                head = head.Next;
                return true;
            }

            Node current = head;

            while (current.Next != null)
            {
                if (current.Next.Value.Equals(item))
                {
                    current.Next = current.Next.Next;
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public void Print()
        {
            Node current = head;

            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }

            Console.WriteLine();
        }
    }

    class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public override bool Equals(object obj)
        {
            if (obj is Person other)
                return Name == other.Name;

            return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }
    }

    class Book
    {
        public string Title { get; set; }

        public Book(string title)
        {
            Title = title;
        }

        public override bool Equals(object obj)
        {
            if (obj is Book other)
                return Title == other.Title;

            return false;
        }

        public override int GetHashCode()
        {
            return Title.GetHashCode();
        }

        public override string ToString()
        {
            return Title;
        }
    }

    static void Main(string[] args)
    {
        LinkedList<string> words = new LinkedList<string>();

        words.Add("Hello");
        words.Add("World");

        Console.WriteLine(words.Contains("Hello"));
        Console.WriteLine(words.Contains("-"));

        words.Remove("Hello");
        words.Print();

        LinkedList<Person> people = new LinkedList<Person>();

        Person p1 = new Person("Anna");
        Person p2 = new Person("Maria");

        people.Add(p1);
        people.Add(p2);

        Console.WriteLine(people.Contains(new Person("Anna"))); 

        people.Remove(p1);
        people.Print();

        LinkedList<Book> books = new LinkedList<Book>();

        Book b1 = new Book("1984");
        Book b2 = new Book("Brave New World");

        books.Add(b1);
        books.Add(b2);

        Console.WriteLine(books.Contains(new Book("1984"))); 

        books.Remove(b2);
        books.Print(); 

    }
}

