# TableValleyMunicipalApp

## Overview

The Table Valley Municipal App is a Windows Forms application built in Visual Studio 2022 to strengthen communication between citizens and the municipality.
The app enables residents to report issues, stay informed about local events, and track municipal responses.
It promotes transparency, accountability, and active community participation in local governance.

### Features
#### 🧾 Report an Issue

Submit issues such as water leaks, power outages, or road damage.

Attach optional images or documents for supporting evidence.

Each report includes a category, location, and description.

Issues are dynamically displayed using a custom-built Linked List for efficient data traversal and management.

#### 📅 Stay Informed (Local Events)

View upcoming municipal and community events such as clean-ups, safety meetings, and cultural activities.

Add new events with details such as name, date, category, location, and description.

Use the search bar to find events by keyword or category.

Sort events by date, name, or category.

Uses a Dictionary, Queue, and Set to efficiently manage event listings and filtering.

#### 🚦 Track Progress (New in Part 3 (POE) )

Citizens can now track the progress of reported issues in real-time.

Each request is stored in a Binary Search Tree (BST) for fast searching and sorting by ID.

Urgent requests are managed using a custom Priority Queue that displays high-priority issues first.

A Graph structure maps relationships between service requests and municipal departments (e.g., Roads, Water, Sanitation).

Allows searching by Request ID, viewing all active reports, and analyzing relationships visually.

### 🔍 Search, Sort, and Manage

All data displays update dynamically in real time.

Visual feedback is provided when users add, search, or sort content.

Consistent status messages guide users through actions (success, warnings, or errors).

### 🎨 Consistent and Accessible Design

A clean, intuitive interface using a lavender and cream theme for calm visual balance.

Consistent design language across all pages.

UI uses GroupBoxes, FlowLayoutPanels, and color-coded buttons for clear navigation.

Tooltips and labels guide users before they click, improving accessibility and user understanding.

## How It Works

Report Issues – Citizens log issues with location, category, and description.
Stay Informed – Users can view or add local events, search for specific events, and sort them.
Track Progress – View all reported issues, search by Request ID, or analyze departmental relationships.
Data Storage – All features rely on custom-built data structures (Linked List, Dictionary, Queue, BST, Graph, Priority Queue).
Feedback & Interaction – The app dynamically updates forms and provides user-friendly messages for every action.
--
Project Structure
Folder	Purpose
Forms	| Contains all Windows Forms for Issue Reporting, Local Events, and Track Progress.
Models	| Data models representing service requests and events.
DataStructures	| Custom-built classes such as BinarySearchTree, PriorityQueue, Graph, and LinkedList.
Program.cs	| Application entry point that initializes and runs the main form.

### Technologies Used
- .NET Framework / Windows Forms (C#)
- Custom Data Structures: Linked List, Queue, Dictionary, Binary Search Tree (BST), Priority Queue, Graph
- Visual Studio 2022

--

🧩 Part 2 Additions

- Added a fully functional Stay Informed (Local Events) page.
- Implemented search and sort functionality with real-time updates.
- Added visual feedback and tooltips for better user experience.
- Enhanced branding with Table Valley Municipality logo and consistent theme.
- Fixed Part 1 bugs and improved navigation between pages.
- Recorded a video demonstration showcasing all new and existing features.

--

🏗️ Part 3 Additions

- Implemented Track Progress Form for viewing and managing reported issues.
- Integrated multiple advanced data structures:
- Binary Search Tree (BST): For searching service requests by ID.
- Priority Queue: For sorting issues by urgency or priority level.
- Improved form navigation and error handling.
- Added sample data population for testing and demo purposes.
- Fixed namespace and designer issues for better modular structure.
- Ensured user-friendly status messages throughout the app.
- Integrated Part 2 feedback on clarity, naming conventions, and UI consistency.
- Added a Project Completion Report section and updated this README for rubric compliance.

🧠 Data Structure Explanation
Data Structure	Usage	Benefit
Linked List	Stores and displays reported issues dynamically.	Allows fast traversal and easy insertion/removal.
Dictionary	Manages events by category/date.	Enables efficient search and retrieval.
Queue	Handles event submission order.	Maintains FIFO structure for user inputs.
Binary Search Tree	Stores service requests by ID.	Enables efficient searching and sorting operations.
Priority Queue	Prioritizes urgent municipal issues.	Ensures critical tasks are addressed first.
Graph	Represents connections between issues and departments.	Visually maps data relationships for reporting.

--

### 🛠️ Changelog (from Part 1 → Part 3)
Version	Update Summary
1.0 (Part 1)	Basic “Report an Issue” functionality added.
2.0 (Part 2)	Added Local Events, search & sort features, enhanced UI.
3.0 (Part 3)	Added Track Progress form, advanced data structures (BST, Priority Queue, Graph), bug fixes, new UI enhancements, and comprehensive documentation.
💬 Project Completion Report

#### Timeline:
Part 1: March–April – Issue Reporting Form
Part 2: May–June – Local Events with Search & Sort
Part 3: October–November – Track Progress, advanced data structures, and final submission

Challenges & Solutions:

Namespace errors: Fixed by unifying namespaces under TableValleyMunicipalApp.DataStructures.
Designer conflicts: Reconnected missing event handlers.
Data structure integration: Refactored for clarity and modularity.

### 🎓 Key Learnings

Gained deeper understanding of data structure implementation in real-world systems.
Improved modular coding, debugging, and UI design in Windows Forms.
Learned to apply Queue, Dictionary, and Tree algorithms to solve practical municipal problems.
Enhanced understanding of software project documentation and academic integrity practices.

### 💡 Technology Recommendations
Recommendation	Justification
Deploy on Azure Cloud	Offers scalability and centralized database storage for municipal use.
Integrate REST APIs	Allows citizens to report issues from web or mobile.
Add Push Notifications	Keeps users updated on status changes (using Firebase).
Introduce Data Analytics Dashboard	Helps municipalities visualize service trends.

## 🧾 Academic Integrity

All external materials and concepts have been properly referenced.
Code implementation and structure are original and attributed where applicable.
AI tools (such as GitHub Copilot and ChatGPT) were used only for syntax correction, debugging, and documentation refinement — not for automated assignment generation.
## Links
- **GitHub Repository:** [TableValleyMunicipalApp](https://github.com/VCCT-PROG7312-2025-G1/TableValleyMunicipalApp-ST10045251)  
- **YouTube Demonstration:** [Watch Here](https://youtu.be/IpwxbRDbCE4)
  
## References
Displayed in the Poject Completion Report.
