# MultiDbCrudDemo – Multiple Database CRUD Application

## Project Overview
**MultiDbCrudDemo** is an ASP.NET Core MVC application that demonstrates how to perform
**CRUD (Create, Read, Update, Delete) operations using multiple databases** in a single project.


---

## 🎯 Key Features
- Multiple database connections in one project
- Separate DbContext for each database
- Full CRUD operations
- Clean MVC architecture
- Production-style implementation

---

## 🛠️ Technologies Used
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Razor Views
- Dependency Injection

---

## 🗄️ Databases Used
| Database | Purpose |
|--------|--------|
| ProductDb | Manage products |
| UserDb | Manage users |

Each database is accessed using its own `DbContext`.

---

## 📂 Project Structure
```

MultiDbCrudDemo/
│
├── Controllers/
│   ├── ProductsController.cs
│   └── UsersController.cs
│
├── Data/
│   ├── ProductDbContext.cs
│   └── UserDbContext.cs
│
├── Models/
│   ├── Product.cs
│   └── User.cs
│
├── Views/
│   ├── Products/
│   │   ├── Index.cshtml
│   │   ├── Create.cshtml
│   │   └── Edit.cshtml
│   │
│   ├── Users/
│   │   ├── Index.cshtml
│   │   ├── Create.cshtml
│   │   └── Edit.cshtml
│
└── README.md

```

---

## 🔄 CRUD Operations
### Products
- Create Product
- View Product List
- Edit Product
- Delete Product (POST – no delete page)

### Users
- Create User
- View User List
- Edit User
- Delete User (POST – no delete page)

---

<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/73dd825e-f412-4535-9a86-1edd9088621a" />
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/38a6bb9e-53a9-439f-a81a-5fb4f17f38ed" />
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/60dd62c4-da64-46ec-9423-d5d374325838" />
<img width="1920" height="1080" alt="image" src="https://github.com/user-attachments/assets/3651f0fb-fda7-48de-b91f-b139b4a7ea17" />


---

## ▶️ How It Works
1. Each controller uses its own DbContext
2. Separate databases are configured in `appsettings.json`
3. Dependency Injection injects correct DbContext
4. Views perform CRUD using Razor & MVC pattern

---

## 🚀 How to Run the Project
1. Clone the repository
2. Configure connection strings for both databases
3. Run database migrations
4. Start the application
5. Access:
   - `/Products`
   - `/Users`

---










