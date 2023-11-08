# Labs

## Lab01: Threading

In the starter-folder you will find a WPF application with four textboxes.
In the upper three textboxes a user can enter a number.
After pressing the button a calculation should start which will put the sum of the squares of those numbers
in the fourth textbox.
The calculation should be performed with the function in the SlowMath class that came with the starter files.

### Exercise 1: Keep the UI responsive

#### SingleTextBox

We will start with a simple version of this problem: We will calculate only the square of the number
in the first textbox (using the SlowMath class) and will put the result in the lower textbox.

Requirements:

- Make sure that the UI remains responsive, which means that during the calculations the window can be moved, minimized or maximized.
- The solution is thread safe
- We will use the Thread-class for our solution, so we will create our own threads.
- We will use the `Dispatcher` of the ResultTextBox to get the results on the screen.

#### MultipleTextBoxes

Now we get to the rest of the problem:
We will calculate the sum of the squares of the three numbers from the upper 3 textboxes (using the SlowMath class)
and we will put the result in the lower textbox.

Requirements:

- Make sure that the UI remains responsive
- The calculation must not take much more time than the calculation of 1 square only.
- The solution is thread safe
- We will use the Thread-class for our solution, so we will create our own threads.
- We will use the `Dispatcher` of the ResultTextBox to get the results on the screen.

### Exercise 2: SynchronizationContext

#### SingleTextBox

The same assignment as in exercise 1, but now we will use the `SynchronizationContext` of the UI-Thread
to get the results on the screen.

#### MultipleTextBox:

Also with the multiple textboxes we will use the `SynchronizationContext` of the UI-Thread to get the results
on the screen.

### Exercise 3: BackgroundWorker

#### SingleTextBox

The same assignment as in the previous exercises, but in this case we will not create our own threads.
We will use the `BackgroundWorker` to make sure the the UI remains responsive while the calculation takes place.

MultipleTextBox:
For calculation of the numbers in 3 textboxes, we need 3 BackgroundWorkers.
Make the solution work for all 3 textboxes with BackgroundWorkers.

### Exercise 4: ThreadPool

#### SingleTextBox

The same assignment again, but now we will use the ThreadPool,
so we will not create our own threads and not use the BackgroundWorker.

#### MultipleTextBox

Also in the case of multiple textboxes, we will use threads from the ThreadPool to the calculations.

## Lab02: Tasks and Parallel

### Exercise 1: Tasks

#### SingleTextBox:

We will start with a simple version of this problem:
We will calculate only the square of the number in the first textbox (using the SlowMath class)
and will put the result in the lower textbox.

Requirements:

- Make sure that the UI remains responsive, which means that during the calculations the window can be moved,
  minimized or maximized.
- The solution is thread safe
- We will use the `Task` class for our solution, so we will not create our own threads.

#### MultipleTextBox:

Now we get to the rest of the problem: We will calculate the sum of the squares of the three numbers
from the upper 3 textboxes (using the SlowMath class) and we will put the result in the lower textbox.

Requirements:

- Make sure that the UI remains responsive
- The calculation must not take much more time than the calculation of 1 square only.
- The solution is thread safe
- We will use the `Task` class for our solution, so we will not create our own threads.

### Exercise 2: Parallel class

This exercise is about using the Parallel class, so it is not useful to start with only one TextBox,
so we will only do the exercise with multiple textboxes.
We will use the `Parallel` class to offload the calculation of the squares to background threads.

### Exercise 3: PLINQ

In this exercise, again only the multiple textboxes, we will use PLINQ to perform the calculation

### Exercise 4: CountDownEvent

Again, only useful for multiple textboxes.
In this exercise we will go back to the solution of exercise 4 of lab01 where we used the ThreadPool
to execute the calculations. In that case we needed a counter to keep track of the number of finished calculations.
In this exercise we will use the CountDownEvent instead of a counter.

### Exercise 5: Barrier

Instead of the CountDownEvent we will use a Barrier to make sure all calculations have finished
when we show the result.

## Lab03: Async

### Exercise 1: SquareAsync

#### SingleTextBox:

Add an awaitable method SquareAsync() to the SlowMath class.
This method is the asynchronous version of the existing Square method.
Calculate the square of the value in the upper textbox, using SquareAsync(),
and put the result in the lower textBox. Use async/await.

Requirements:

- Make sure that the UI remains responsive, which means that during the calculations the window can be moved,
  minimized or maximized.
- The solution is thread safe

#### MultipleTextBox:

Use the SquareAsync() to calculate the squares of all 3 textboxes and put the sum in the ResultTextBox.
Use async/await and make sure that the solution is thread safe and that the total time of the calculation
is not more than the calculation of 1 square.

### Exercise 2: SquareAsync2()

SlowMath contains BeginXXX and EndXXX.
Use these methods to create an awaitable method SquareAsync2().
Calculate the square of the value in the upper textbox, using SquareAsync2(),
and put the result in the lower textBox.

### Exercise 3: Async Enumerator

In this exercise we will create a method called GetSquaresAsync() that returns an IAsyncEnumerable<int>.
This method returns an async enumerator that enumerates the calculated squares (using SquareAsync).
Make sure that when the user clicks the button, await foreach is used to consume the async enumerator.
Again the UI must not freeze and the total time of the calculation must not be more than the calculation of 1 square.
