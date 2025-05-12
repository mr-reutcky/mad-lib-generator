# Mad Lib Generator

**Mad Lib Generator** is a C# console application that allows users to create humorous and personalized stories by filling in blanks with various word types. This project demonstrates the use of object-oriented programming principles and user interaction in a console environment.

## Features

- **Interactive Story Creation**: Prompts users to input words of various types (nouns, verbs, adjectives, etc.) to fill in the blanks of a story template.
- **Randomized Templates**: Supports multiple story templates selected at random for varied experiences.
- **User-Friendly Interface**: Simple console-based interface for easy interaction.

## Project Structure

```
mad-lib-generator/
├── MadLibGenerator.sln
├── MadLibGenerator.csproj
├── Program.cs
├── Templates/
│   ├── Template1.txt
│   ├── Template2.txt
│   └── ...
├── bin/
└── obj/
```

## Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

### Running the Application

1. **Clone the Repository**:

   ```bash
   git clone https://github.com/mr-reutcky/mad-lib-generator.git
   cd mad-lib-generator
   ```

2. **Build the Solution**:

   ```bash
   dotnet build
   ```

3. **Run the Application**:

   ```bash
   dotnet run
   ```

## Usage

Upon running the application, you'll be prompted to enter various words (nouns, verbs, adjectives, etc.). These words will be inserted into a story template to create a unique and often humorous story.

Example usage:

```csharp
Console.WriteLine("Enter a noun:");
string noun = Console.ReadLine();

Console.WriteLine("Enter a verb:");
string verb = Console.ReadLine();

Console.WriteLine("Enter an adjective:");
string adjective = Console.ReadLine();

// ... additional prompts

Console.WriteLine("Once upon a time, there was a " + adjective + " " + noun + " who loved to " + verb + ".");
```

## Contributing

Contributions are welcome! If you'd like to add new features or improve existing ones, please fork the repository and submit a pull request.

## License

This project is open-source and available under the [MIT License](LICENSE).
