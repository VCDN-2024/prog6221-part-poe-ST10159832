[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/9yYOuv2_)


Following the feedback i received, I significantly improved my assignment. Initially, the DisplayTotalCalories method displayed a message if the total calories 
exceeded 300, however this capability was not implemented utilizing the requisite delegates and events. To overcome this, I implemented delegate definitions and 
events to ensure event-driven communication across classes. In the Recipe class, I defined a delegate and an event, which was triggered when the calorie 
restriction was surpassed. This event was subsequently handled in the RecipeProcess class, which improved code decoupling and modularity. In addition, I updated 
the README by including resources from VCLearn, resulting in a full digital guide. This guide now contains thorough instructions on how to use the app and enter 
recipe information.

Prog Poe part 2 Recipe app The recipe app is designed and developed to provide users with software that will allow them to enter as many recipes as they wish too 
as well as enter the type of ingredients the recipe will require, the quantity, food group and calories of the ingredients.
visual studio 2022 is the IDE that is used to develop the recipe app, this software must be downloaded from google, chrome or any other trusted internet browser. 
To download the software, you will need to open up an internet browser of yor choice, in the search bar, type ‘visual studio 2022 download’, upon searching you 
will see the results and in specific you are looking for ‘visual studio 2022 IDE – Programming tool software’ that is provided by Microsoft. Clicking on that will 
direct you to the Microsoft page that will allow you to download the software, you will see a drop down menu with ‘download visual studio’ on it, click the drop 
down menu and choose ‘community 2022’. Upon selection you will notice in the top right corner something is downloading, this is the visual studio software set up, 
if you do not see this go to your download and it should be the download at the top, selecting this will bring up a pop that asks for permission to set up the 
software and if you trust the software, you will have agree and trust the download before setting up the software, you will then see a pop up saying visual studio 
installer, clicking on agree allows you to install the software on your laptop or desktop. Upon completion of the installation, you will need to choose your 
workloads that you want on visual studio, I have selected .netframe as it is what I need to build the project. After choosing the workload you may choose 
individual components, language packs and installation location. Once completed you have successfully set up visual studio code 2022 and can now create you first 
project. You will be presented with the start window in which you select create new project, you will be directed to a page that requires you to select your 
preferred template, I have selected console app and C# and my template and language, thereafter you can select the version of .net that you want to use, I have 
selected .net 8.0, once done you are finally required to name your project and then you are able to code your project. In the program.cs page which is your main 
page you can code directly onto there or create other internal classes and enter your code there and just call it in the main page(program.cs), in my project I 
created many different internal classes and called these classes in other classes if I had to by, for example I used ‘ClassOne classone = new ClassOne’ to call 
ClassOne in ClassTwo, you could do this wherever you need to and this basically makes your code more neater and understandable to other coders, this falls under 
good coding practises. The use of methods is to create different types of functionality in your project without getting confused and makes code easier to work with 
and understand, method names are usually very descriptive and tell you what the method does, you can call these methods in the main page of the project or in any 
other page that you created, I have a method class called ‘CalculateTotalCalories’ and this method basically calculates the total calories in a recipe and can 
display if the user wants to. Error handling basically notifies the user that there is a problem with the input and tells them what type of input Is expected, 
there is error handling throughout my code as it is also good coding practises. The unit test are implemented to ensure that the methods created function as they 
are suppose to and unit testing is a good way for developers to test their code. To execute code or the program users can select the green play button that is 
placed at the top of the screen in the middle, next to the green play button will have the name of the project and scrolling over the name will give you a message 
saying ‘run’, this allows user to run the app and allows developers to ensure the app works before publishing it


For the third phase of this project, we switched from a terminal program to a graphical user interface (GUI) built with Windows Presentation Foundation. While it 
is feasible to move some or all of the functionality from the console application to the WPF application, I elected to rewrite it since I found it to be less 
complicated and more manageable. This new WPF application has a variety of forms that execute critical functions within the program, resulting in an improved user 
interface. All of the command line application's existing functionality has been kept and upgraded. Additionally, a new function has been added that allows users to filter the list of recipes. 
