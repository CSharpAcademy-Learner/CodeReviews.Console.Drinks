# Drinks

A console-based application that gets and shows data from TheCocktailDB API.

## How It Works

The application calls TheCocktailDB API to initially show drink categories, the user selects a category and then the application shows a list of drinks in that category. When selecting a drink, the app will show details and an image of that drink.

### What Was Easy?

A lot of the concepts were carried on from previous projects, mainly menus with Spectre Console.

### What Was Hard

This was the first project that called an API, so getting to grips with that.

### What I Learned

In previous projects, I copied some code I found online without really understanding it all, for example displaying a table in the console. For this project, I tried to fully understand all the code I used. This included calling the API, a simplified version of printing a table and looping through the properties and values of an object.

### Notes

In all my projects, I try to make the UI simple and easy to use and not to exit the app unless the user explicitly wants to. In the project, I put all the models in a single 'Model.cs' file, this was because I knew I wouldn't need many models, I'm fully aware that this probably isn't best pratice.
