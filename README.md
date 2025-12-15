# Mental Health Data Visualizer

Provides an interactive data visualization platform for mental health data from the 2024 National Survey on Drug Use and Health to easily identify trends and patterns.

---

**Technology Stack:**

* **Backend & Logic:** C# / ASP.NET Core (Razor Pages)
* **Data Visualization:** Chart.js (Open-source JavaScript library)
* **Database Management:** Microsoft SQL Server 2022 Express (managed via SSMS and T-SQL)

# Project Context
The National Survey on Drug Use and Health is an annual survey conducted nationwide in the United States that reports crucial data on the use of illicit drugs and mental health disorders in the general populace. While this data in table form is invaluable, it can be difficult to compare and visualize the data. This project aims to solve this issue by taking table data and organizing it into graphs including bar charts, doughnut charts, and scatter plots, to easily identify key information, patterns and trends in the data. This provides clear and concise data visualization for use by data analysts to easily draw conclusions from the data, rather than parsing through large tables.

# Project Preview
**Tables view**
![Tables View](MentalHealthDataVisualizer/Screenshots/Table%20View.png)
The landing page, also the table view page, displays the data in a table format. The table may be sorted by any column ascending or descending, for example sorted from highest to lowest tally. Currently, only the results of Table 6.1A from the results
of the 2024 National Survey on Drug Use and Health are in the database.

**Bar Charts View**
![Bar Charts View](MentalHealthDataVisualizer/Screenshots/Bar%20Chart%20View.png)

**Doughnut Charts View**
![Doughnut Charts View](MentalHealthDataVisualizer/Screenshots/Doughnut%20Chart%20View.png)

# Project Management
This project is managed using an Agile development methodology (Kanban) through Jira to track feature implementation as Epics, Stories and Tasks.
![Jira Board View](MentalHealthDataVisualizer/Screenshots/Jira%20Board.png)

# Project Plan
This section provides the planned features to be implemented.

1.  **Dynamic Data Filtering**
    * **Reason:** To ensure efficient data retrieval, security, and performance when handling complex queries.
    * **Action:** Implement filtering logic using T-SQL Stored Procedures and parameterized queries to optimize performance and mitigate SQL Injection risks.

2.  **More Chart Types**
    * **Reason:** To provide additional visualizations of NSDUH data.
    * **Action:** Introduce donut charts, scatter plots, etc. via Chart.js.
  
3.  **Export to CSV**
    * **Reason:** To allow a compatilbe format for exporting filtered or unfiltered data for use in a spreadsheet.
    * **Action:** Implement client-side logic using JavaScript/Chart.js to extract the table data into a downloadable CSV file.

4.  **Cloud Hosting on Azure Web Apps**
    * **Reason:** To provide a reliable, scalable, and professional hosting environment.
    * **Action:** Migrate the application to be hosted on Azure Web Apps and secure the database connection string using Azure Key Vault.
  
5.  **CI/CD Pipeline Integration**
    * **Reason:** To automate the software release lifecycle Source -> Build -> Test -> Deploy.
    * **Action:** Configure a GitHub Actions workflow to run unit tests on code commits and automatically deploy successful builds to the Azure Web App.
