using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following values and priorities: {"One1", 1},{"Five1", 5},
    // {"Five2", 5},{"Seven1", 7},{"Two1", 2},{"Five3", 5},{"Four1", 4},{"Three1", 3} and dequeue 
    // the item with the highest priority.
    // Expected Result: "Five1"
    // Defect(s) Found: The conditional statement within the Dequeue method did not take into 
    // consideration for FIFO where two or more items have the highest values. Additionally, 
    // there is no mechanism to remove this item from the queue once determined.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("One1", 1);
        priorityQueue.Enqueue("Five1", 5);
        priorityQueue.Enqueue("Five2", 5);
        priorityQueue.Enqueue("Seven1", 7);
        priorityQueue.Enqueue("Two1", 2);
        priorityQueue.Enqueue("Five3", 5);
        priorityQueue.Enqueue("Four1", 4);
        priorityQueue.Enqueue("Three1", 3);

        var expectedResult = "Seven1";
        var actualResult = priorityQueue.Dequeue();
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    // Scenario: Create a queue with the following values and priorities: {"One1", 1},{"Five1", 5},
    // {"Five2", 5},{"One2", 1},{"Two1", 2},{"Five3", 5},{"Four1", 4},{"Three1", 3} and dequeue 
    // the item with the highest priority.
    // Expected Result: "Five1"
    // Defect(s) Found: The conditional statement within the Dequeue method did not take into 
    // consideration for FIFO where two or more items have the highest values. Additionally, 
    // there is no mechanism to remove this item from the queue once determined.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("One1", 1);
        priorityQueue.Enqueue("Five1", 5);
        priorityQueue.Enqueue("Five2", 5);
        priorityQueue.Enqueue("One2", 1);
        priorityQueue.Enqueue("Two1", 2);
        priorityQueue.Enqueue("Five3", 5);
        priorityQueue.Enqueue("Four1", 4);
        priorityQueue.Enqueue("Three1", 3);

        var expectedResult = "Five1";
        var actualResult = priorityQueue.Dequeue();
        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    // Scenario: Try to get the highest PriorityItem value from an empty queue
    // Expected Result: Exception should be thrown with appropriate error message.
    // Defect(s) Found: No defect was found here.
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue has no PriorityItems.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }
    // Add more test cases as needed below.
}