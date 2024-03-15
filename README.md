README for DryIoc Console Application Example
Introduction
This project is a simple console application that demonstrates how to use the DryIoc library for dependency injection in .NET. 
Think of it like assembling a model airplane or setting up a sports team where each part or player has a specific role. 
Instead of manually connecting each piece or assigning player roles every time, we use a system (DryIoc) that automatically figures out what goes where. 
This way, we ensure our airplane is ready to fly or our team is set to play efficiently and without errors.

Getting Started
Installation: Make sure you have the .NET SDK installed on your computer.
Creating the Project: Open your terminal or command prompt, navigate to where you want your project, and run:

dotnet new console -n DryIoc_Poc
cd DryIoc_Poc
Adding DryIoc: Run the following command to add DryIoc to your project:
dotnet add package DryIoc.dll

How It Works
The Players (Interfaces and Implementations): We define roles for our team, like a goalie or striker in soccer, through interfaces and their implementations. For example, we have an IService role and a Service player who knows how to perform that role.
The Coach (DryIoc Container): DryIoc acts like our coach, knowing which player fits which role. When the game starts (our program runs), DryIoc picks the right player for the right position.
The Game (Running the Program): When we run our program, DryIoc ensures our Service player is doing their job by calling the Serve method, akin to scoring a goal or flying our model airplane successfully.
Code Snippets
Here's a quick look at our main players:

IService (Role):
public interface IService
{
    void Serve();
}


Service (Player):
public class Service : IService
{
    public void Serve()
    {
        Console.WriteLine("Service Called");
    }
}

Program.cs (The Game Plan):
using DryIoc;
using System;
namespace DryIocExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container();
            container.Register<IService, Service>();

            var service = container.Resolve<IService>();
            service.Serve();
        }
    }
}


Running the Application
To get the game going, simply run:
dotnet run

You'll see "Service Called" as an output, meaning our player (Service) performed exactly as expected, thanks to our coach (DryIoc).

Conclusion
Using DryIoc is like having an expert coach for setting up a sports team or assembling a model airplane. It ensures each part or player is exactly where they need to be, leading to a successful game or flight.
