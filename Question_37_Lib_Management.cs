/*
Question 37
Lib Management

Description
Book Library Management System (C# Console Application)
Introduction
This project demonstrates a simple Book Library Management System using C#. 
It is a console-based application where an Admin can manage books (CRUD operations)
and Users can browse and search books. The project uses in-memory storage with Generic 
Collections and also demonstrates the use of dynamic objects in C#.

Objective
The main objective of this project is to:
- Understand CRUD operations using Generic Collections
- Learn how to use List<T> as in-memory storage
- Apply dynamic keyword usage in C#
- Implement search and filter operations
- Design a beginner-friendly real-world console application

Requirements
Software Requirements:
- Windows 10/11
- .NET SDK 6.0 or above
- Visual Studio / VS Code

Functional Requirements:
- Admin can Add, Update, Delete, and View books
- User can browse all books
- User can search books by name
- User can search books by publisher
- User can view highest priced book
- User can view lowest priced book

Use Case Summary
Actors:
1. Admin
2. User

Admin Use Cases:
- Add Book
- Update Book
- Delete Book
- View All Books

User Use Cases:
- Browse Books
- Search Book by Name
- Search Book by Publisher
- View Highest Price Book
- View Lowest Price Book

Test Cases
Test Case 1: Add Book
Input: Book details
Expected: Book added to list

Test Case 2: Update Book
Input: Book ID and updated data
Expected: Book details updated

Test Case 3: Delete Book
Input: Book ID
Expected: Book removed from list

Test Case 4: Search by Name
Input: Book name
Expected: Matching books displayed

Test Case 5: Search by Publisher
Input: Publisher name
Expected: Matching books displayed

Test Case 6: Highest Price Book
Expected: Book with maximum price displayed

Test Case 7: Lowest Price Book
Expected: Book with minimum price displayed

Expected Result Set
- Admin can successfully manage books using CRUD operations
- User can browse and search books efficiently
- Highest and lowest priced books are correctly identified
- Data is stored and retrieved using Generic Collections
- dynamic keyword is used to store flexible book objects

Conclusion
This Book Library Management System provides a strong foundation for understanding collections, CRUD operations, and dynamic objects in C#. It closely represents real-world library systems while remaining simple and beginner-friendly. This project can be extended further by adding file storage, database integration, or a UI.
*/