# The C# Player's Guide - Extra Projects

## Project 1: Character Sheet Builder
- Topics Covered: Variables, Types, Console I/O, Methods, Conditionals, Properties 
- Overview: Create a program that asks the user for character details (name, age, class, stats), calculates derived values (e.g., attack power), and prints a formatted character sheet. 
- Core Features: 
  - Input: string, int, double
  - Method for computing AttackRating()
  - Validation (e.g., stat total must not exceed 100)
  - Use of properties with validation
  - Enum for class types (Warrior, Mage, Rogue)
  - Start After:
    - Chapter 6 (Type System)
    - Chapter 7 (Math)
    - Chapter 13 (Methods)
  - You’ll need:
    - Basic input/output
    - Variables and types
    - Simple calculations and encapsulation
- *Comments*
  - *The book has not yet covered Enums, but it isn't that hard*
  - *Not sure what "properties" it's talking about in the validation part. We have not covered Classes and properties*
  - *I will use the stats: Strength, Dexterity, Power and Charisma*

Project 2: Dungeon Map Renderer Topics Covered: Arrays, Loops, Console Color, Enums, Pattern Matching Overview: Render a 2D dungeon map in the console using characters and colors. Let the user place walls, rooms, and symbols. Core Features: • 2D char[,] array to represent the map • Colorize symbols using ANSI escape codes (\e) • Display with Console.SetCursorPosition • Use enums for tile types • Optional: Save/load to a file Start After: • Chapter 8 (Console 2.0) • Chapter 11 (Looping) • Chapter 12 (Arrays) • Chapter 33 (Managing Larger Programs – optional) You’ll need: • Console cursor manipulation • 2D arrays • Basic rendering logic

Project 3: Battle Simulator Topics Covered: Inheritance, Interfaces, Polymorphism, Records, Delegates Overview: Create a text-based battle simulator with warriors, mages, and archers each having unique abilities and strategies. Core Features: • Base Fighter class with Attack(), Defend() methods • Derived classes override behavior • Interface ISpecialMove • Use delegate to define and plug in strategies • Use records for immutable battle results log Start After: • Chapter 25 (Inheritance) • Chapter 26 (Polymorphism) • Chapter 27 (Interfaces) • Chapter 36 (Delegates) You’ll need: • Polymorphic behaviors • Strategy patterns via delegates • Dynamic behavior through interfaces

Project 4: Personal Finance Tracker Topics Covered: File I/O, Static Classes, Records, Tuples, Properties, Exception Handling Overview: Track income and expenses, categorize them, generate reports, and save/load to a file. Core Features: • Transaction record with amount, date, category • Monthly summaries using GroupBy • Command-based interface for adding/removing data • Use static utility class for formatting • Exception handling for file operations and input Start After: • Chapter 39 (Files) • Chapter 35 (Error Handling) • Chapter 20 (Properties) • Chapter 30 (Generics) – optional for reusable components You’ll need: • Record-based data storage • File persistence • User input and validation • Exception handling for resilience

Project 5: RPG Quest Engine Topics Covered: Inheritance, Interfaces, Events, Delegates, Enums, JSON Serialization Overview: Create a simple quest system where players can accept, complete, and chain quests with rewards and branching logic. Core Features: • Quest base class with derived types (Fetch, Kill, Escort) • Interface IRewardable • Delegate OnQuestComplete for callbacks • Enum for quest difficulty • Save/load quest state from JSON (simulate persistence) Start After: • Chapter 23 (Design Principles) • Chapter 25–27 (OOP: Inheritance, Interfaces) • Chapter 36 (Delegates) • Optional: Chapter 29 (Records), Chapter 39 (Files) You’ll need: • OOP composition • Dynamic behaviors through events and interfaces • Record types for results • Delegate callbacks for quest completion

Project 6: Inventory Manager with Search Topics Covered: Classes, Lists, LINQ, Pattern Matching, File I/O Overview: Create a program to manage inventory items, with add, remove, search, sort, and filter functionality. Core Features: • Use List where Item is a class with Name, Type, Value • Search by name with LINQ • Filter by item type using pattern matching • Save/load items to/from a text file • Use optional parameters in lambda-based filters Start After: • Chapter 18 (Classes) • Chapter 27 (Interfaces) • Chapter 32 (Useful Types – especially List) • Chapter 42 (LINQ / Query Expressions) You’ll need: • Collections (like List) • File I/O • Pattern matching and object filtering with LINQ

Project 7: Recipe Recommendation System Topics Covered: LINQ, Collections, Files, Delegates, Pattern Matching, Records Overview: Build an app that recommends recipes based on available ingredients, diet preferences, and calories. Core Features: • Load recipe data from a JSON/text file • Filter recipes with LINQ queries • Use pattern matching on food types • Use delegates for flexible filtering logic • Define recipes as record types Start After: • Chapter 32 (Useful Types) • Chapter 34 (Methods Revisited – optional/named/default) • Chapter 35 (Error Handling) • Chapter 42 (LINQ Queries) You’ll need: • LINQ and filtering • Delegates for search criteria • File reading/writing • Optionally: record types and pattern matching


Project 8: Henge Explorer (C# 13 Tie-in Project)
Topics Covered: Tuples, Records, ANSI Console, Object-Oriented Design, Events
Overview:
Inspired by The Henges of Elegedd, this game lets players explore and interact with magical structures using console graphics and classes.
Core Features:
    • Henge class with location, symbol, and color
    • Use of ANSI escape codes to render in color
    • Tuples to represent map coordinates
    • Movement logic using arrow keys
    • Custom event when a player discovers a Henge
    • Advanced: Multiplayer turn-based support
Start After:
    • Chapter 8 (Console 2.0 – for ANSI codes and colors)
    • Chapter 17 (Tuples)
    • Chapter 23 (Object-Oriented Design)
    • C# 13 Expansion – “The Henges of Elegedd” challenges
You’ll need:
    • Cursor positioning
    • Object arrays
    • Use of color escape codes
    • Lightweight OOP skills


Project 9: Networked Chat Console
Topics Covered: Async/Await, Events, Delegates, Threads, Console I/O, Error Handling
Overview:
Build a local network chat client/server in the console using TCP. Focus on multi-threading, input handling, and robust code.
Core Features:
    • Async TCP client/server (localhost)
    • Console input/output with separate thread
    • Delegate-based message handlers
    • Graceful exception handling
    • Optional: Save chat log to a file
Start After:
    • Chapter 43 (Threads) – if in your edition
    • Async/Await concepts from modern C#
    • C# 12–13 knowledge optional but helpful
You’ll need:
    • Async TCP client/server
    • Console read/write on threads
    • Delegate-based handling


Project 10: Game Modding System
Topics Covered: Reflection, Interfaces, Dynamic Loading, Delegates, Files
Overview:
Design a plugin/modding system where mods (DLLs) can be dynamically loaded at runtime and define new behaviors.
Core Features:
    • Use Assembly.LoadFrom() to load external mod libraries
    • Mods implement IMod interface
    • Dynamically invoke methods with delegates
    • Allow runtime configuration of loaded features
    • Log mod loading errors with try/catch
Start After:
    • All core chapters complete
    • Extra: Reflection (not covered in main book but part of advanced C# topics)
    • Comfortable with dynamic code execution and abstraction
 You’ll need:
    • Plugin loading with Assembly.LoadFrom()
    • Delegates, interfaces
    • File-based modular architecture
    • Error handling and fallback logic


