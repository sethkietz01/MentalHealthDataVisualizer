# Mental Health Data Visualizer

Provides an interactive data visualization platform for mental health data from the 2024 National Survey on Drug Use and Health to easily identify trends and patterns.

---

**Technology Stack:**

* **Backend & Logic:** C# / ASP.NET Core (Razor Pages)
* **Data Visualization:** Chart.js (Open-source JavaScript library)
* **Database Management:** Microsoft SQL Server 2022 Express (managed via SSMS and T-SQL)

# Project Preview
**Tables view**
![Tables View](MentalHealthDataVisualizer/Screenshots/Table%20View.png)
The landing page, also the table view page, displays the data in a table format. The table may be sorted by any column ascending or descending, for example sorted from highest to lowest tally. Currently, only the results of Table 6.1A from the results
of the 2024 National Survey on Drug Use and Health are in the database.

**Bar Charts View**
![Bar Charts View](MentalHealthDataVisualizer/Screenshots/Bar%20Chart%20View.png)

# Project Plan
This project uses an Agile development methodology by iteratively implementing new features. This section provides the planned features to be implemented.

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
