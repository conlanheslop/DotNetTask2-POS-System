# .NET POS system

### 31927 - Application Development with .NET
##### University of Technology Sydney


## **Project Overview**
This is our groups submission for Assignment 2.

### Our Group:
- Ali Bonagdaran (PrinceAlii)
- Ian Tsun (RinreiRay)
- Conlan Heslop (conlanheslop)

---

## **Tech Stack**

- **Programming Language**: C#
- **Framework**: .NET 6.0
- **UI Framework**: Windows Forms 
- **Database**: SQLite
- **ORM**: Entity Framework Core
- **Unit Testing Framework**: NUnit 3.13.2
- **Source Control**: GitHub

---

## **Dependencies and Versions**

It's advised that you use these specifc dependency versions as the latest versions may not be compatible with .NET 6.0

| Dependency                   | Version      | Purpose                                     |
|------------------------------|--------------|---------------------------------------------|
| .NET                         | 6.0          | Application framework for WinForms          |
| Entity Framework Core        | 6.0.0        | ORM for SQLite database operations          |
| Microsoft.Data.Sqlite        | 6.0.0        | SQLite database provider for EF Core        |
| NUnit                        | 3.13.2       | Unit testing framework                      |
| Microsoft.NET.Test.Sdk       | 17.6.3       | Test SDK for running unit tests             |

---

## **Installation and Setup**

### **Prerequisites**
1. Install **.NET 6.0 SDK**: [Download Here](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
2. Install **Visual Studio 2022** with **Windows Forms and .NET Development** workload.
3. Install **DBeaver (optional)** for manual database inspection:  


## Important
Please ensure data.db's "Copy to Output Directory" property is set to "Copy Always"

If you are experiencing database / EF troubles you should delete everything in the /Db and 
/Migrations directories and run the following in a CMD / terminal in the project directory.

```bash
dotnet ef migrations add InitialData
dotnet ef database update
```


### **Cloning the Repository**
```bash
git clone https://github.com/your-repository/pos-system.git
cd pos-system
