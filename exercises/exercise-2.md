# Exercise 2

1. Following the pattern of exercise 1 and using the provided parts, create a page named `CarToolPage` in the `ToolsApp.Components.CarTool` namespace that displays a table of cars. Each car row should display the following attributes of a car:

- Id: int
- Make: string
- Model: string
- Year: int

Wire the page into the menu system.

2. In addition to the data columns, add an additional column with a header named "Actions".

3. In each row's action column, place a delete button. When the delete button is clicked, remove the car from the table.

4. Create another page named `CarDetailPage` in the `ToolsApp.Components.CarTool` namespace that displays all of the details of a single car: id, make, model, year, color, and price. You may layout the details however you like.

The id of the car to display is passed in via a URL path segment. Beneath the car details provide a button, that when clicked, returns the user to the Car Tool page.

5. Here is a list of the provided parts:

- Car Interfaces, Car Business Model, Car Data Model
- Link to Cars Data service
- Partial Car Table component

Review the provided parts, and put the puzzle together.

6. Ensure it works!

