//Zionn Showers
//9-21-2026
//Mini Challenge # 11 - API Beginnings
//I basically looked back at the original code to see how I could input the same code but into an API format. I made the user input have the ability to enter their name, add two numbers together, say the time they wake up, compare the size of numbers, and do a MadLib.

## Peer Review
Reviewer: Callen Thomason
+ The hello firstname lastname works very well, but the url is a little long. I can see you want to give the user instuctions, but it would probably be simpler to have ("firstNameLastName/{firstName}/{LastName})
+ AddTwoNumbers works very well, and has validation which is great. The route name feels very long again. A shorter name would probably help with user interation. Your if statment can also be shorted by removing the "== true" on both sides. 
+ The time you woke up works as intended. String interpolation looks great. I think the route could be less complicated, but it works. 

/----------Part 2---------------/

+ I would have liked to see you go through the other projects and add ActionResults and return Ok() to them. 
+ Your ActionResult<> for add2nums and compare2nums works very well. Your tryparse to check if a number was input is perfect. 
+ All the programs still work as intended, great job!
