# Exercise 1

1. Execute the following steps within the project structure we have created. Place the parts of the program in the projects you think best. The purpose of each project is as follows:

- ToolsApp.Core - use for things like interfaces that are referenced by many of the project
- ToolsApp.Models - the models returned by the data access code and consumed by the components
- ToolsApp.Data - provides services for in-memory and database data
- ToolsApp.Component - provides components that are called from the pages in the web project
- ToolsApp.Web - the Blazor Server web app

2. Create a page the displays a list of colors. Each color in the list should display name and hexcode of the color. For each list item, display a delete button. When the delete button is clicked, remove the color from the list. Above the list should be header that displays 'Color Tool'.

3. Construct a simple form to collect new color data. When the form is submitted display the color in the list.

4. The program should be more than one component. In your solution, demonstrate how to organize UI parts into component tree. Ideally, 2-3 new components should be created for this exercise.

5. The data for the application should be managed within the context of service. The data will be purely in-memory (such as a list object), no database data. Ideally, the data service will be coded in the data project.

6. Get as much done as you can. We will review the entire exercise at the end.

Raise you hand under the following conditions:

- If you finish, raise your hand
- If you are no longer making forward progress after 5 mins...