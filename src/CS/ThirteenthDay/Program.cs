using System;
using System.Collections.Generic;
using System.IO;
abstract class Book
{

    protected String title;
    protected String author;

    public Book(String t, String a)
    {
        title = t;
        author = a;
    }
    public abstract void display();
}

//Write MyBook class

class MyBook : Book {
    protected int price;
    public MyBook(String t, String a, int p) : base(t, a)
    {
        this.title = t;
        this.author = a;
        this.price = p;
    }

    public override void display()
    {
        string str = $"Title: {this.title}\nAuthor: {this.author}\nPrice: {this.price}\n";
        Console.WriteLine(str);
    }
}

class ThirteenthDay
{
    static void Main(String[] args)
    {
        String title = Console.ReadLine();
        String author = Console.ReadLine();
        int price = Int32.Parse(Console.ReadLine());
        Book new_novel = new MyBook(title, author, price);
        new_novel.display();
    }
}
