# 📋 PRG281 - Business Management System

> A console-based C# business management application featuring inventory control, cash management, user authentication, and security - built with modular, single-responsibility design.

## 📋 About

This project was developed as part of the **PRG281 module** at Belgium Campus ITversity. It is a purely console-driven application that simulates a real-world business management system, covering core areas like stock inventory, cash handling, and secure user login.

The codebase is organized into focused, single-purpose modules — each `.cs` file handling one concern — reflecting clean code principles and good software design habits.

## ✨ Features

- 🔐 **User Authentication** - secure login system before accessing the app
- 🛡️ **Security Module** - access control and input validation
- 📦 **Inventory Management** - add, view, and manage stock items
- 💵 **Cash Module** - handle cash transactions and calculations
- 🎨 **ASCII Art & Animations** - polished console UI with visual flair
- 📋 **Menu System** - clean, navigable console menu

## 🛠️ Built With

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white)

## 🏗️ Project Structure

```
PRG281_Project/
├── Program.cs              # Entry point — app startup
├── Menu.cs                 # Console menu navigation
├── LoginDisplay.cs         # Login UI and flow
├── Security.cs             # Authentication & access control
├── InventoryManager.cs     # Inventory business logic
├── Inventory.cs            # Inventory data model
├── CashModule.cs           # Cash transaction handling
├── Animation.cs            # Console animations
├── ASCII.cs                # ASCII art for UI
└── PRG281_Project.csproj   # Project configuration
```

## 🚀 Getting Started

### Prerequisites

- Windows / macOS / Linux
- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later recommended)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)

### Run the Project

```bash
# Clone the repository
git clone https://github.com/Rivan-Maritz/PRG281_Project.git

# Navigate into the project folder
cd PRG281_Project/PRG281_Project

# Run the application
dotnet run
```

Or open `PRG281_Project.sln` in Visual Studio and press **F5**.

## 🎮 How to Use

1. **Launch** the application in your console
2. **Log in** using your credentials at the login screen
3. **Navigate** the menu to access different modules:
   - View and manage inventory stock
   - Handle cash transactions
   - Review security settings
4. **Exit** cleanly from the main menu

## 👤 Author

**Rivan Maritz**
- GitHub: [@Rivan-Maritz](https://github.com/Rivan-Maritz)
- LinkedIn: [rivan-maritz-93755a3ab](https://linkedin.com/in/rivan-maritz-93755a3ab)

## 📄 License

This project was created for academic purposes at Belgium Campus ITversity.
