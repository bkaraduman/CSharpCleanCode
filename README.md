# CSharpCleanCode
I walk you through common code smells found in C# programs and shows you how to refactor them. Refactoring is changing the design of the existing code without changing its external behaviour.

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
