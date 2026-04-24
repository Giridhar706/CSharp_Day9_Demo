# StudentDashboardAsync

# 📊 Student Dashboard - Asynchronous Data Fetching System (C#)

## 🚀 Project Overview

This project demonstrates how to use **Asynchronous Programming in C#** using `async` and `await` to build a simple **Student Dashboard System**.

The system fetches:

* Student Details
* Marks
* Attendance

All data is fetched **asynchronously** to improve performance and avoid blocking execution.

---

## 🎯 Objective

* Understand `async` and `await`
* Execute multiple tasks in parallel
* Simulate real-world data fetching (API/Database)
* Improve application responsiveness

---

## ⚙️ Features

* ✅ Uses `async` and `await`
* ✅ Executes multiple tasks using `Task.WhenAll()`
* ✅ Simulates delay using `Task.Delay()`
* ✅ Takes user input
* ✅ Handles exceptions using `try-catch`
* ✅ Demonstrates non-blocking execution

---

## 🛠️ Technologies Used

* C#
* .NET Console Application
* Task-based Asynchronous Programming (TAP)

---

## 📂 Project Structure

```
StudentDashboardAsync/
│── Program.cs
│── StudentDashboardAsync.csproj
```

---

## ▶️ How to Run the Project

### 🔹 Using Visual Studio

1. Open Visual Studio
2. Click on **Create New Project**
3. Select **Console App (.NET)**
4. Replace `Program.cs` with the provided code
5. Click **Run (▶)**

---

## 💡 How It Works

1. User enters student details
2. System starts loading data
3. Multiple async methods run **in parallel**
4. Results are displayed together after completion

---

## 🔄 Async Methods Used

* `GetStudentDetailsAsync()`
* `GetMarksAsync()`
* `GetAttendanceAsync()`

Each method:

* Simulates delay using `Task.Delay()`
* Returns data using `Task<string>`

---

## ⚡ Key Concepts

### 🔹 async

Marks a method as asynchronous

### 🔹 await

Waits for a task to complete without blocking the program

### 🔹 Task.WhenAll()

Runs multiple tasks **concurrently**

---

## 🧪 Sample Output

```
===== Student Dashboard System =====
Enter Student Name: Giridhar
Marks (%): 85
Attendance (%): 92

Loading data... Please wait...

===== Dashboard Result =====
Student Name: Giridhar
Marks: 85%
Attendance: 92%
```

---

## ⚠️ Note

* Marks and attendance may be randomly generated (simulation)
* This mimics real-world API/database calls

---

## 📈 Future Enhancements

* 🔹 Add real API integration
* 🔹 Add database support
* 🔹 Add UI (Web or Desktop)
* 🔹 Compare Sync vs Async performance

---

## 👩‍💻 Author

  Giridhar Gopal

---

## ⭐ Conclusion

This project clearly demonstrates how asynchronous programming improves:

* Performance
* Responsiveness
* User experience

It is especially useful for real-world applications like:

* Web apps
* APIs
* Data dashboards

---
