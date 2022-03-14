# CSharpCleanCode
I walk you through common code smells found in C# programs and shows you how to refactor them. Refactoring is changing the design of the existing code without changing its external behaviour.

In the solution explorer you will see some examples about how clean code should be and how refactoring is done! In the solution folders you will see bad code and under Refactoring folder you will see clean code!

Thanks for star :) 

# Comments

* Never write version comments. For example;
  
  // Prior to v1.3 <br>
  if(isDeleted) 
  {
  }
  
  Just imagine for a second if someone joins that team or wants to maintain that application three years down the track, does he or she really care about every single thing that happened over various versions of that application?
  I think not! You do not need to write comments like that are completely useless.
  
  Another example:
  
  // 1 Jul 2000 - Batuhan Karaduman : .... <br>
  // 3 Dec 2003 - Batuhan Karaduman : .... <br>
  
   so you open a file and the first page on your screen is just comments, the dates, the name of people who made changes and the type of change they made. So essentially, you have to scroll down until you see the actual code. Again, this is completely useless these days. We use version control systems.
   
   If someone is interested to see who made what change when they can always look at the log or history of the repository.
   
* Never comment deleted code! Just delete it! We use version control systems! We can always pull it back from source code repo!

 // public class Team <br>
 // { <br>
 // }
 
 
 * Good comment is TODO comment!
 
 So we don't want to get distracted and change our focus. So we just leave a comment there as a ToDo comment. And later, when we get back to that part of code, we can see what was happening before and fix the problem when we write it.
  
 In a nutshell:
 
 <blockquote>
  * Do not write comments, re-write your code! <br/>
  * Don't explain "Whats" (the obvious) <br/>
  * Explain "Whys" and "hows" <br/>
  </blockquote>

# Magic Numbers

if(status == 1) // 1 means draft <br/>
{ <br/>
  // do smth <br/>
} <br/>
else if(status == 2) // 2 means lodged <br/>
{ <br/>
  // do smth <br/>
} <br/>

I, as a reader of this code, have no idea what 1, 2 represents! What is 1? What is 2? How are they different? What does code do for what? This kind of magic numbers make code hard to read, hard to understand and hard to change. And this is something that we should avoid at all times. And never write comment next to these numbers!

So what I want you to take away from this lecture is to avoid magic numbers at all times, either extract them into a constant or use an enumeration if you're going to use them in multiple places.

 <blockquote>
  * Use contants or enums! <br/>
  </blockquote>

# Variable Declarations on the Top

In the old days, in the 70s and 80s, it was common to declare variables on top of the method and I think there were technical reasons behind that. But these days, we don't have that problem anymore and we shouldn't really declare our variables on the top of a method.

In fact, we should declare them where we need them. What's the reason behind that? Imagine you ask your friend, how was your day?

Your friend says, I started my day with a coffee.
I went out.
It was beautiful and sunny.
Outside the world population is six billion.

What your friend was talking about his day and how it was going. And all of a sudden he says the world population is six billion just doesn't make sense. There is a bit of disconnection here.

And as clean coders, we want to minimize the brainpower used by the readers of our code to the minimum. So what I want you to take away from this section is to declare your variables close to their use it.

# Duplicated Code

When you duplicate code, if you need to change it, you need to make that change in multiple places. Plus duplicated code makes your code noisy and hard to understand. There is a principle called DRY which stands for don't repeat yourself.

The DRY principle states that every piece of knowledge must have a single, unambiguous, authoritative representation within a system.

The implication from this principle is often deemed to be avoiding code duplication. While it’s true that in most cases following DRY means the elimination of repeatable code, the principle itself is not about code duplication.

# Long Methods

What do I mean by a long method, a long method is one that is more than 10 lines of code, you might be saying really we have methods that are 50 lines of code and there is nothing wrong with them. Well, just because you're comfortable reading a 50 line method does not mean every other developer is comfortable doing so. In fact, on a scientific level, we humans can keep up to seven things at a time in our conscious mind, which means when we read a method that is 50 lines of code or hundred lines of code or two hundred lines of code, we have to keep track of a lot of things from the top of the method to the bottom. 

So there are essentially three problems with long methods, they're hard to understand are to change and hard to reuse.

Now, the question is, how do I know which lines belong to what method?

How do I know which lines should I take out?

Well, we have a principle called cohesion, which means things that are related should be together and things that are not related should not be together.

So what I want you to take away from this lecture is to keep your methods short, less than 10 lines and ideally five lines, even a meaningful names.

When you have a method that is only five lines or less than 10 lines, it's very likely that that method is doing only one thing. And this way you can give it a proper name that reveals the intent, which means you don't need to write comments to explain your methods. But if a method is 20 lines or 15 lines or 200 lines, which I have seen many of them.

How can you name that method?

It becomes really hard because that method is being too many things again, whenever you're dealing with long methods. Remember the cohesion principle, find the lines that are really related to each other and extract them into a separate method. And as you're extracting these methods, see if those methods all belong to that class, if a method doesn't fit their, move it out, put it in a separate class and remember all that comes with practice and experience.

# Long Parameter List

Another common cold smell is a method with long parameter lists, the more parameters we have for a method, the harder it gets to understand that method and its intention.

Sample:

CheckUserEmails(null, 1, true, false, DateTime.Now);

One true false daytime talk.
Now, what do these arguments represent?
What is now, what is one?
What is true?
What is false?

We cannot tell without having a look at the implementation of that method. I know that a method like that, every time you want to call it, we have to pass so many arguments. So not only that method is hard to understand, but it's also hard to use.

So what I want you to take away from this lecture is to limit the number of parameters of your methods to three. When you have three parameters, you're pretty much on the edge.  More than three parameters, most of the time is a code smell, and you need to get rid of unnecessary parameters or encapsulate the logically related ones into a class.

# Nested Conditionals

So basically what I mean by that is a piece of code that looks like this. You have a bunch of if else, if else, and a switch in the middle and perhaps a loop.

if(a)<br>
{
if(b)
{
if(c)
{
...
}
else
{}
}
}
}...

So the problem with this nested conditionals is they make programs hard to read, are to change, hard to understand and hard to test. The more nested conditionals we have, the more execution patterns we have, which means we need various combinations of values in order to test a method. Avoid using nested statements. 

# OutputParameters

So in this example, I have a method called Get Customers, which takes a page index and returns the list of customers in that page, but it also has a second parameter, which is an output parameter, and that returns the total number of customers in the database. So the problem here is in order for me to call this method, I have to declare and initialize a variable like count and then pass it along with the out modifier to this method that looks ugly. Plus, naturally, we think of data going inside a function and coming out.

It doesn't quite make sense to parse the data in and come out from the arguments. Now this problem can get worse if you have two or more output parameters.

int count = 0; <br>
var customers = GetCustomers (pageIndex, out count);
<br>

Instead of using out keywords, create a response class and use this methodology. Return an object from a method instead.

# PoorMethodSignatures

So basically, what I mean by that is it's like you have a method called get customer, but the parameter it guess it's an airplane which is actually not an airplane object.

Orange GetCustomer (int airplane);

It's an integer. And what that method returns is not a customer. It's an orange.

Check the return type, Check the method name, check the parameters.

# PoorNames

Poor names is one of the most common code smells I have seen over my experience. Some examples;

SqlDataReader dr1;
SqlConnection c;
int od;
void Button1_Click();
class Temp{}
string cr;

Do you understand what are these names and what do they do? This is a symptom of code smell. Your code should be so clean and intention revealing so that the reader does not have to go somewhere else to understand what is happening there.

Solution;

* Not too short, not too long!
* Meaningful
* Reveal intention
* Chosen from problem domain

# SwitchStatements

Switch statements are popular amongst programmers who are not familiar with object oriented programming, so they're used to doing things in a procedural way, which means calling functions and functions and functions and passing arguments around.

But an object oriented programming with thinking objects as opposed to functions and objects are about data and behavior, not just behavior. You can find this example in the solution explorer (under SwitchStatements folder)

Solution
* Replace them with polymorphic dispatch
* Use push Member down refactoring
