# Mental Health Data Visualizer

Provides an interactive data visualization platform for mental health data from the 2024 National Survey on Drug Use and Health to easily identify trends and patterns.

---

# Getting Started
The most recent publish may be viewed here: https://mentalhealthdatavisualizer-fwfvb5afb3bwdjbb.canadacentral-01.azurewebsites.net

Please note that this application is hosted on Azure using the free tier (F1), which has strict limitations. The app will likely have to cold start, which may take a while to start up, and is limited to 1 hour of usage per day. Therefore it may be possible that this limit has been exceeded and the app will no longer function until the daily limit resets.

# Technology Stack

* **Backend & Logic:** C# / ASP.NET Core (Razor Pages)

  I chose Razor Pages because this project does not require complex back-end logic, and Razor Pages are simpler than MVC architecture. I also wanted to get experience with Razor Pages, as my other projects frequently use MVC.
* **Data Visualization:** Chart.js (Open-source JavaScript library)

  I chose Chart.js because it is an easy and powerful open-source library that allows for highly-customizable and diverse charts that I am already familiar with from my other projects.
* **Database Management:** Microsoft Azure SQL Server (managed via SSMS, T-SQL)

  I chose Microsoft SQL products because it seemed like a logical choice given the use of other Microsoft products (.NET, Azure App Services).

# Project Context
The National Survey on Drug Use and Health is an annual survey conducted nationwide in the United States that reports crucial data on the use of illicit drugs and mental health disorders in the general populace. While this data in table form is invaluable, it can be difficult to compare and visualize the data. This project aims to solve this issue by taking table data and organizing it into graphs including bar charts, doughnut charts, and scatter plots, to easily identify key information, patterns and trends in the data. This provides clear and concise data visualization for use by data analysts to easily draw conclusions from the data, rather than parsing through large tables.

# Project Preview
**Tables view**
![Tables View](MentalHealthDataVisualizer/Screenshots/Table%20View.png)
The landing page, also the table view page, displays the data in a table format. The table may be sorted by any column ascending or descending, for example sorted from highest to lowest tally. Currently, only the contents of Table 6.1A from the results
of the 2024 National Survey on Drug Use and Health are in the database.

**Bar Charts View**
![Bar Charts View](MentalHealthDataVisualizer/Screenshots/Bar%20Chart%20View.png)

**Doughnut Charts View**
![Doughnut Charts View](MentalHealthDataVisualizer/Screenshots/Doughnut%20Chart%20View.png)

**Scatter Charts View**
![Scatter Charts View](MentalHealthDataVisualizer/Screenshots/Scatter%20Chart%20View.png)

# Project Management
This project is managed using an Agile development methodology (Kanban) through Jira to track feature implementation as Epics, Stories and Tasks.
![Jira Board View](MentalHealthDataVisualizer/Screenshots/Jira%20Board.png)

# Project Plan
This section provides the planned features to be implemented.

1. **Mobile Optimization**
   * **Reason:** To ensure smooth compatibility with mobile devices.
   * **Action:** Implement grid systems using bootstrap, swap pixel measurements for rems, ensure proper content widths.
   
2.  **Dynamic Data Filtering**
    * **Reason:** To ensure efficient data retrieval, security, and performance when handling complex queries.
    * **Action:** Implement filtering logic using T-SQL Stored Procedures and parameterized queries to optimize performance and mitigate SQL Injection risks.
  
3.  **CI/CD Pipeline Integration**
    * **Reason:** To automate the software release lifecycle Source -> Build -> Test -> Deploy.
    * **Action:** Configure a GitHub Actions workflow to run unit tests on code commits and automatically deploy successful builds to the Azure Web App.
