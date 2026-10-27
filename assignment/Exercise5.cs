using System;
using System.Collections.Generic;
using System.Text;
namespace assignment;

public class Exercise5
{
    public static void Run()
    {
        Queue<string> documents = new Queue<string>();

        // 1. Enqueue five documents
        documents.Enqueue("Report.pdf");
        documents.Enqueue("Invoice.pdf");
        documents.Enqueue("Letter.docx");
        documents.Enqueue("Resume.pdf");
        documents.Enqueue("Photo.jpg");

        // 2. Print queue and Count
        Console.WriteLine("Queue: " + string.Join(", ", documents));
        Console.WriteLine("Count: " + documents.Count);

        // 3. Peek at the next document
        Console.WriteLine("Next document: " + documents.Peek());

        // 4. Process the queue
        while (documents.Count > 0)
        {
            string document = documents.Dequeue();
            Console.WriteLine("Printing: " + document);
        }

        // 5. TryDequeue on an empty queue
        bool success = documents.TryDequeue(out string nextDocument);

        Console.WriteLine("TryDequeue succeeded: " + success);
        Console.WriteLine("Document: " + (nextDocument ?? "No document"));
    }
}
