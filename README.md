# Twitter Clone - ASP.NET Core

A Twitter (X)-style backend built step by step with ASP.NET Core as part of an ASP.NET learning course. The project currently focuses on the domain model and the first API controller endpoints.

---

## Project Status

> Work in progress. Several endpoints are currently demo implementations and do not persist data yet.

| Layer | Status |
|---|---|
| Domain Layer | In progress: entities and basic business rules are present |
| API / Presentation Layer | Initial controllers and routes are present |
| Application Layer | Not started |
| Infrastructure Layer | Not started |
| Authentication (JWT) | Route authorization attributes are present; authentication is not configured |
| Database / Persistence | Not started; responses are in-memory or placeholders |
| Real-time (SignalR) | Not started |

---

## 🏗️ Architecture

The solution is currently split into a domain project, an ASP.NET Core API project, and a test project. The Application and Infrastructure layers are planned but do not exist yet.

```
TwitterClone/
│
├── TwitterClone.Domain/          # Core entities and domain rules
├── TwitterClone.Api/             # ASP.NET Core controllers and Swagger setup
└── TwitterClone.Test/            # Early domain experiments/tests
```

---

## Domain Layer

The domain project contains entities with encapsulated state, constructors, and validation methods. Shared entity metadata includes `Id` and `CreatedAt`.

### Current entities and rules

- `User`: first name, last name, email, follow/unfollow and notification tracking
- `Tweet`: author, content, and `CanBeLiked()`; content cannot be empty or exceed **200 characters**
- `Follow`: prevents a user from following themselves
- `Like`: connects a user and a tweet
- `Bookmark`: connects a user and a saved tweet
- `Retweet`: connects a user and a tweet, with an optional comment up to 280 characters
- `Message`: prevents self-messaging, rejects empty content, and supports marking as read
- `Notification` and notification subclasses: unread state, message validation, and mark-as-read behavior

## API Progress

The API project targets .NET 8 and currently includes these controller areas:

- `Users`: list, create, read by ID, and update demo endpoints
- `Tweets`: sample tweet listing endpoint
- `Follows`: follow, unfollow, follower/following, request, and status routes
- `Likes`: like, unlike, status, count, and liked-tweets routes
- `Bookmarks`: add, remove, clear, list, and status routes
- `Retweets`: create, list, delete, and status routes
- `Messages`: send, list, read, delete, and mark-as-read routes
- `Notifications`: list, unread, read, delete, and mark-all-as-read routes

Swagger/OpenAPI is enabled in the Development environment. Most controller actions currently return sample messages, empty responses, or placeholder values because repositories, services, and persistence have not been added yet.

---

## 🛠️ Tech Stack

| Technology | Purpose |
|---|---|
| **ASP.NET Core 8** | Web framework |
| **C# 12** | Programming language |
| **.NET 8** | Runtime |
| **Entity Framework Core** | Planned persistence layer |
| **SQL Server** | Planned database |
| **JWT Bearer Auth** | Planned authentication |
| **SignalR** | Planned real-time messaging |
| **Domain-Driven Design** | Current domain modeling approach |

---

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/) with C# extension

### Clone the Repository

```bash
git clone https://github.com/TahmidulAhad/twitter-clone.git
cd twitter-clone
```

### Build the Solution

```bash
cd TwitterClone
dotnet build
```

### Run the Project

```bash
dotnet run --project TwitterClone.Api
```

When running in Development, open the Swagger URL printed by ASP.NET Core to inspect the available routes.

---

## 📚 Step-by-Step Build Log

Each commit in this repo represents a learning step:

| Step | What Was Built |
|---|---|
| Step 1 | Solution setup and Domain project created |
| Step 2 | ASP.NET Core API project and Swagger configured |
| Step 3 | Initial domain entities and validation rules added |
| Step 4 | Controller route skeletons added for users, tweets, follows, likes, bookmarks, retweets, messages, and notifications |

---

## 📂 Project Structure (Current)

```
twitter-clone/
├── README.md
└── TwitterClone/
    ├── TwitterClone.slnx
    ├── TwitterClone.Api/
    │   ├── Controllers/
    │   ├── Program.cs
    │   └── TwitterClone.Api.csproj
    ├── TwitterClone.Domain/
    │   ├── Entities/
    │   └── TwitterClone.Domain.csproj
    └── TwitterClone.Test/
        └── Class10.cs
```

---

## 🎯 Planned Features

- [ ] Add Application and Infrastructure projects
- [ ] Add DTOs, services, repositories, and dependency injection
- [ ] Add Entity Framework Core and SQL Server persistence
- [ ] Implement real user registration and JWT authentication
- [ ] Implement persisted tweets, likes, retweets, bookmarks, and follows
- [ ] Build a user feed from followed users
- [ ] Connect direct messages and notifications to persisted data
- [ ] Add automated unit and integration tests
- [ ] Add real-time notifications with SignalR
- [ ] Search users and tweets
- [ ] User profile with bio & profile picture
- [ ] Trending hashtags

---

## 🤝 Contributing

This is a course project, but feedback and suggestions are welcome!

1. Fork the repository
2. Create your feature branch: `git checkout -b feature/your-feature`
3. Commit your changes: `git commit -m 'Add some feature'`
4. Push to the branch: `git push origin feature/your-feature`
5. Open a Pull Request

---

## 📄 License

No license file has been added yet.

---

## 👨‍💻 Author

**Md. Tahmidul Alam Ahad**
📫 Reach me on [GitHub](https://github.com/TahmidulAhad)

---

> ⭐ If you find this project helpful for learning ASP.NET Core, please give it a star!
