# CSharp-Console-Project-File-I-O

A console-based C# application developed using .NET 10.0.  
This project demonstrates file handling (File I/O), exception handling, and menu-driven user interaction in a console environment.

---

## 📌 Project Overview

The application allows users to interact with a text file (`history.txt`) through a menu system. Users can:

- View file content
- Add new text data
- Replace existing file data
- Append data to file
- Exit the program safely

It also includes input validation and exception handling to ensure smooth execution.

---

## 🛠 Technologies Used

- C#
- .NET 10.0 SDK
- System.IO (File Handling)

---

## 📂 Project Structure

```bash
C-Console-Project-File-I-O/
│── Program.cs
│── history.txt (auto-created if needed)
│── C-Console-Project-File-I-O.csproj
│── README.md
```

---

## ▶️ How to Run

### Clone the Repository

```bash
git clone <your-repository-url>
```

### Navigate to Project Folder

```bash
cd C-Console-Project-File-I-O
```

### Run the Application

```bash
dotnet run
```

---

## 💻 Sample Output

```text
1. View File
2. Add Text
3. Exit
Choose Option: 2

Enter Text: Hello World

1. Replace Old Data
2. Add With Old Data
3. Exit
Choose: 2

New Data Added!
```

---

## 🎯 Learning Objectives

- Understanding File I/O in C#
- Using `File.ReadAllLines()`
- Using `File.WriteAllLines()` and `File.AppendAllLines()`
- Menu-driven console applications
- Input validation using `TryParse()`
- Exception handling using `try-catch`
- Working with loops and conditional logic

---

## 👨‍💻 Author

Seam  
Full-stack Developer

---
