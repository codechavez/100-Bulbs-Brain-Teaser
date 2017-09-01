# 100-Bulbs-Brain-Teaser
This is a simple solution to the 100 Bulbs brain teaser done in C#

Visit http:codechavez.com

100 Bulbs brain teaser is a very popular exercise that senior or lead likes to present to the interviewee in order to measure solving problem skills and how the candidate response to pressure. So, the exercise goes like this

You have 100 bulbs all align in a row  and you have 100 people waiting in line. Person 1 goes and flips all switches turning all bulbs ON. Person 2, goes and flip switches 2,4,6,8,10...etc turning those bulbs OFF. Person 3 comes and flips switches 3,6,9,12...etc tuning bulbs off except Bulb No. 6 which now is ON. So, what's the final number of bulbs that are ON after all 100 people take their turn?
First, you will realized that is a loop, well, actually 2 loops one for 100 people and the other for 100 bulbs (switches).  

for each person till 100

     for each bulb till 100
  
Second, you will find that the second person flip switches in multiples of 2, example, 2,4,6,8,10,12,14,16,18,20...etc. The same happen with the third person it flips switches in multiples of 3, example, 3,6,9,12,15,18,21...etc. The same pattern repeats for all the other iterations. 


How do we know that a number is multiple of another number?


we use '%' symbol if you using C#. It returns the remainder of a division. For example 4 divided by 2 is 1 but its remainder is 0, other example is 2 divided by 5 with a remainder of 2. This example tell us that 4 is multiple of 2 and 2 is not multiple of 5.

Reminder:  A number cannot be divided by 0.

With all this information in mind, I drafted a firs attend to solve this brain teaser using C#.

var bulbs = new bool[bulb];

for (int p = 1; p <= people; p++)
   for (int b = p; b <= bulb; l++)
      if (b % p == 0)
         bulbs[b - 1] = !bulbs[b - 1];
Now, as you may noticed bulb and people are meant to be input variables, so you can enter 100 people for 100 bulbs or 50 people for 100 bulbs or 100 people for 50 bulbs, this way it makes the solution more generic but you can fix the solution to 100.

You also noticed that the starting point of the loop is not 0 but 1 this is because a number cannot be divided by 0 so we start with 1. The solution for the access the correct index is to subtracts 1 as it shows in the code above.

We set the second loop to start with the current person, therefore we do "l = p".

The if statement confirms that the bulb (b) is a multiple of the current person (p). 

bulbs[b - 1] = !bulbs[b - 1];  assigns the opposite that it has at the moment. Meaning if index 6 was ON (true) this statement will assign the opposition (NOT, in C# is ! ) which is false, in our case would be OFF.

Now, This is as far a can go by helping you solve this brain teaser, but for a full code sample visit my github at http://codechavez.com/#/100_bulbs_brain_teaser



Share the knowledge!
