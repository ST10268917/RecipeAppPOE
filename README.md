RECIPE APP: 
-------------------------------------------------
Welcome to the Recipe App, your ultimate culinary companion! This intuitive app lets you input your favorite recipes, beautifully display them in a clear, organized format, effortlessly scale them according to different serving sizes and search for your favourite recipes. Whether you're cooking for one or preparing a feast, our app makes it simple to adjust ingredient quantities with precision. Experience the joy of stress-free cooking with all your recipes just a tap away!

Getting Started
----------------------------------------------------------
Follow these steps to compile and run the program:
Prerequisites
--------------------------------------------------------
Before you start, make sure you have the following installed on your computer:
•	Visual Studio
•	Git : https://github.com/VCDN-2024/prog6221-part-1-ST10268917.git 
Installation
1.	Clone the GitHub repository to your local machine using Git. Open your command-line terminal and run the following command:
bashCopy code
git clone https://github.com/VCDN-2024/prog6221-part-1-ST10268917.git
2.	Open Visual Studio.
3.	Click "File" > "Open" > "Project/Solution."
4.	Navigate to the directory where you cloned the repository.
5.	Select the RecipeApp-POE.sln solution file and click "Open."
6.	Once the project is open, build the solution by clicking "Build" > "Build Solution" in Visual Studio.

Feedback implemented from Part 1:
--------------------------------------
In response to feedback received after part 1 of our project, significant enhancements were made to the Recipe App's functionality and code structure. Most notably, the scaling feature was refined to ensure that recipe quantities adjust based on their most recently modified values rather than the original measurements. For example, if a recipe initially calls for 1 cup of milk and is then doubled to 2 cups, a subsequent tripling will now correctly adjust it to 6 cups, rather than incorrectly reverting to 3 cups. This improvement allows for more intuitive and practical use of the scaling function, particularly in scenarios involving multiple adjustments.

Additionally, the code organization within the project has been optimized for better maintainability and clarity. The methods previously located before the Main[] method of Program.cs have been moved to after the Main[] method. Moreover, some of the methods which were originally in Program.cs  have been transferred to the Recipe class. This restructuring allows for a cleaner Main[] method and promotes a more modular approach by encapsulating recipe-related functionalities within the Recipe class itself. This shift not only enhances the readability of the code but also improves its overall architectural design.

Feedback implemented from Part 2:
-------------------------------------------
In response to the feedback from Part 2, I made changes to my code so that the calories for each ingredient are  displayed when displaying the full recipe. 

USAGE 
-------------------
Once the app has run, the main menu of the program will be displayed. The menu has nine options which are outlined below:
1. Enter a recipe
2. Display recipe
3. Scale recipe
4. Reset quanitities to original values
5. Clear recipe
6. Exit application
7. Search by ingredient
8. Search by food group
9. Search by maximum calories

![image](https://github.com/ST10268917/RecipeAppPOE/assets/128280096/157b6b5b-0ad3-4b4b-9760-1dbb48a135fb)

The user should select what they want to do

We will go through each of these options one-by-one


OPTION 1: ENTER A RECIPE
-------------------------------------------------

![image](https://github.com/ST10268917/RecipeAppPOE/assets/128280096/ac56c424-111a-4b60-beec-9c044eae44d3)

Start by entering the name, the number of ingredients and the number of steps for the recipe. If invalid inputs are entered, you will get a pop-up message informing you.

![image](https://github.com/ST10268917/RecipeAppPOE/assets/128280096/3d620726-5cc0-4891-8d6f-351651a078c6)
Thereafter enter the releavant details for each ingredient. The unit of measurements and food groups are displayed in combo boxes. When you pick a food group, 
you get a corresponding description about that food group. 

![image](https://github.com/ST10268917/RecipeAppPOE/assets/128280096/5a69cb98-70c9-48d0-8c4e-16fc06d10b69)
Once all the ingredients have been entered, you will be informed with a message box. If the number of calories exceeds 300 calories, you will be alerted and informed.

![image](https://github.com/ST10268917/RecipeAppPOE/assets/128280096/84f96d6d-dfa6-4110-bb95-6b35b489d309)
Thereafter enter the description for each step. Once all steps have been entered, you will get a message saying the recipe has been successfully saved.


OPTION 2: DISPLAY RECIPE
-------------------------------------------------
![image](https://github.com/ST10268917/RecipeAppPOE/assets/128280096/136149fa-b4da-49a0-afc3-ca2cbb38ee1e)
![image](https://github.com/ST10268917/RecipeAppPOE/assets/128280096/4c929b59-608c-45a7-bbf1-f10250d51367)

Select the recipe you wish to display from the combo box drop-down list. The recipes are shown in alphabetical order with other important details. The full recipe is displayed in a user-friendly format 
and you can tick off the steps as you complete them.

OPTION 3: SCALE RECIPE
-------------------------------------------------
Select the recipe you wish to scale from the combo box.  Choose how you want to scale the recipe: 'half', 'double' or 'triple' depending on how they want to scale the recipe. Once the recipe has been scaled, the scaled recipe will be displayed.

The example image below shows scaling a recipe by 'half':
![image](https://github.com/ST10268917/RecipeAppPOE/assets/128280096/9c57eb92-07c8-4958-ac7e-f9b203317110)

The example image below shows scaling a recipe by 'double':
![image](https://github.com/ST10268917/RecipeAppPOE/assets/128280096/02a04cfc-e82c-431e-af56-4aaed3dcc045)

The example image below shows scaling a recipe by 'triple':
![image](https://github.com/ST10268917/RecipeAppPOE/assets/128280096/d70f0e63-0714-48e3-b5eb-0e699cf03aed)

NOTE: Units of measurement are changed accordingly when scaling. In the example shown below, 8 tablespoons of milk when doubled, becomes 16 tablespoons of milk. The system does the conversion and changes this to 1 cup of milk beacuse 16 tablespoons = 1 cup. 
![image](https://github.com/ST10268917/RecipeAppPOE/assets/128280096/51fde7ed-95da-430a-b53a-b535e848eb0e)


OPTION 4: RESET QUANTITIES TO ORIGINAL VALUES
-------------------------------------------------
Select the recipe to reset. The quantities reset to their original values. Once reset, the recipe will be displayed.
![image](https://github.com/ST10268917/RecipeAppPOE/assets/128280096/bfbbee72-e479-43b4-9177-ebed3e4c15dc)


OPTION 5: CLEAR RECIPE
-------------------------------------------------
![image](https://github.com/ST10268917/RecipeAppPOE/assets/128280096/caa8887f-753a-4bfb-a47a-34ca6dfc43d5)
![image](https://github.com/ST10268917/RecipeAppPOE/assets/128280096/d8f7a900-a70b-47af-9054-82f5ba055d9d)

Select the recipe you want to clear and that recipe will be removed from the collection of recipes. After selecting the recipe to clear, you are asked to confirm whether
you want to clear the recipe and the recipe is only cleared if you click on 'Yes'.

OPTION 6: EXIT APPLICATION
-------------------------------------------------
![alt text](image-5.png)
You can exit the app by clicking on this button.

OPTION 7: SEARCH BY INGREDIENT
-------------------------------------------------
![image](https://github.com/ST10268917/RecipeAppPOE/assets/128280096/71f60310-f078-46ce-9e16-36d4ce9d95c9)
Enter the name of an ingredient and the app will filter through all the recipes and display the names of the recipes that have that ingredient.

OPTION 8: SEARCH BY FOOD GROUP
-------------------------------------------------
![image](https://github.com/ST10268917/RecipeAppPOE/assets/128280096/e8a2235b-8534-4fee-8017-ebd20f268378)
Select a food group and the app will filter through all the recipes and display the names of the recipes that have that food group.

OPTION 9: SEARCH BY MAXIMUM CALORIES
-------------------------------------------------
![image](https://github.com/ST10268917/RecipeAppPOE/assets/128280096/e0d41825-82df-4687-8a1d-917fbae14bd5)

![image](https://github.com/ST10268917/RecipeAppPOE/assets/128280096/a66f72fc-06c6-4cdb-b3cf-c4cb2f159a65)
Enter a maximum number of caloies and the app will filter through all the recipes and display the names of the recipes that have calories less than or equal to that amount.

Note: For all the search functionalities above, if a recipe with that criteria is not found, a pop-up will show to inform.

LINK TO GITHUB REPOSITORY:
-------------------------------------------------
https://github.com/VCDN-2024/prog6221-part-1-ST10268917.git

Note: I used the same repository from part 1 and part 2 for my part 3 submission



