# Digital Diary  
**Lab 3 - CS 222: Advanced Object-Oriented Programming**

## 📌 Project Description and Features
The **Digital Diary** is a modular, console-based application that allows users to write, view, and search diary entries using file handling in C#. All diary entries are stored in a local text file (`diary.txt`).

### ✨ Features:
- 📓 Write a new diary entry (timestamped)
- 📂 View all diary entries
- 🔍 Search entries by specific date (`YYYY-MM-DD`)
- 📁 Stores data in a file (`diary.txt`) for persistence

---

## 🔄 How OOP Principles Are Used
- **Encapsulation**: File handling logic and the file path are encapsulated in the `Diary` class, hidden from the main program.
- **Abstraction**: The main program interacts with the diary through a clean, simple public method interface (`WriteEntry`, `ViewAllEntries`, `SearchByDate`).

---

## ▶️ Instructions on Running the App
1. Open the project in Visual Studio or your preferred C# IDE.
2. Ensure `Program.cs` and `Diary.cs` are in the same project.
3. Press `F5` or run the application.
4. Use the menu to:
   - `1` Write a new entry
   - `2` View all entries
   - `3` Search entries by date
   - `4` Exit

✅ The application automatically creates a `Diary` folder in the project directory to store entries.

---

## 🗂 File Structure
/Lab_3__Balmes_Gonda_Rivera_StaTeresa
│
├── Program.cs              // Main menu and user interaction
├── Diary.cs                // Diary class: file operations
├── Diary/                 
│   └── diary.txt           // Automatically created log of entries
└── README.md               // This file
---

## 🧪 Sample Output
--- Digital Diary Menu ---

1. Write a New Entry
2. View All Entries
3. Search Entry by Date (YYYY-MM-DD)
4. Exit
  
Choose an option: 1 
Enter your diary entry: Finished Lab 3!

--- Digital Diary Menu --- 

1. Write a New Entry
2. View All Entries
3. Search Entry by Date (YYYY-MM-DD)
4. Exit

Choose an option: 2 
2025-04-24 18:42:15 - Finished Lab 3!

--- Digital Diary Menu --- 

1. Write a New Entry
2. View All Entries
3. Search Entry by Date (YYYY-MM-DD)
4. Exit

Choose an option: 3
Enter date to search (YYYY-MM-DD): 2025-04-24
2025-04-24 18:42:15 - Finished Lab 3!

--- Digital Diary Menu --- 

1. Write a New Entry
2. View All Entries
3. Search Entry by Date (YYYY-MM-DD)
4. Exit

Choose an option: 4

Exiting diary. Goodbye!

---

## 👨‍💻 Team Members

- Balmes, Genrique Sean Arkin D.
- Gonda, Paul Raimiel C.
- Rivera, Irish D.
- Sta. Teresa, David Kalel D.

---

## 🙏 Acknowledgement
Special thanks to our CS 222 instructor, Ms. Fatima Marie P. Agdon, for guiding us in our AOOP Course.
