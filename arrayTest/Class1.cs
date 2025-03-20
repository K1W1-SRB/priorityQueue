using NUnit.Framework;
using PriorityQueue;

namespace PriorityQueue.Tests
{
    [TestFixture]
    public class UnsortedLinkedPriorityQueueTests
    {
        private UnsortedLinkedPriorityQueue<string> queue;

        [SetUp]
        public void Setup()
        {
            queue = new UnsortedLinkedPriorityQueue<string>(10);
        }

        [Test]
        public void Add_ShouldAddItemToQueue()
        {
            queue.Add("Task A", 1);
            queue.Add("Task B", 5);

            Assert.That(queue.Head(), Is.EqualTo("Task B"));
        }

        [Test]
        public void Remove_ShouldRemoveHighestPriorityItem()
        {
            queue.Add("Low", 1);
            queue.Add("Medium", 2);
            queue.Add("High", 3);

            queue.Remove();

            Assert.That(queue.Head(), Is.EqualTo("Medium"));
        }

        [Test]
        public void IsEmpty_ShouldReturnTrueForEmptyQueue()
        {
            Assert.That(queue.IsEmpty(), Is.True);
        }

        [Test]
        public void IsEmpty_ShouldReturnFalseWhenQueueHasItems()
        {
            queue.Add("Test", 1);
            Assert.That(queue.IsEmpty(), Is.False);
        }
    }
}
