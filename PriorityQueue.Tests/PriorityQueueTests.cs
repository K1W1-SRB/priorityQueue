using NUnit.Framework;
using PriorityQueue;

namespace PriorityQueue.Tests
{
    [TestFixture]
    public class PriorityQueueTests
    {
        private const int Capacity = 5;

        [Test]
        public void SortedArrayPriorityQueue_ShouldAddAndRetrieveInOrder()
        {
            var queue = new SortedArrayPriorityQueue<Person>(Capacity);

            queue.Add(new Person("Alice"), 3);
            queue.Add(new Person("Bob"), 1);
            queue.Add(new Person("Charlie"), 2);

            Assert.That(queue.Head().ToString(), Is.EqualTo("Alice"));   // Priority 3
            queue.Remove();
            Assert.That(queue.Head().ToString(), Is.EqualTo("Charlie"));  // Priority 2
            queue.Remove();
            Assert.That(queue.Head().ToString(), Is.EqualTo("Bob"));     // Priority 1
        }

        [Test]
        public void UnsortedArrayPriorityQueue_ShouldAddAndRetrieveByPriority()
        {
            var queue = new UnsortedArrayPriorityQueue<Person>(Capacity);

            queue.Add(new Person("Alice"), 2);
            queue.Add(new Person("Bob"), 1);
            queue.Add(new Person("Charlie"), 3);

            Assert.That(queue.Head().ToString(), Is.EqualTo("Charlie"));   // Highest priority
            queue.Remove();
            Assert.That(queue.Head().ToString(), Is.EqualTo("Alice"));
            queue.Remove();
            Assert.That(queue.Head().ToString(), Is.EqualTo("Bob"));
        }

        [Test]
        public void UnsortedLinkedPriorityQueue_ShouldRetrieveInPriorityOrder()
        {
            var queue = new UnsortedLinkedPriorityQueue<Person>(Capacity);

            queue.Add(new Person("Zoe"), 5);
            queue.Add(new Person("Alice"), 1);
            queue.Add(new Person("Eve"), 3);

            Assert.That(queue.Head().ToString(), Is.EqualTo("Zoe"));   // Highest priority
            queue.Remove();
            Assert.That(queue.Head().ToString(), Is.EqualTo("Eve"));
            queue.Remove();
            Assert.That(queue.Head().ToString(), Is.EqualTo("Alice"));
        }

        [Test]
        public void SortedLinkedPriorityQueue_ShouldKeepCorrectOrder()
        {
            var queue = new SortedLinkedPriorityQueue<Person>(Capacity);

            queue.Add(new Person("Tom"), 4);
            queue.Add(new Person("Bob"), 2);
            queue.Add(new Person("Anna"), 3);

            Assert.That(queue.Head().ToString(), Is.EqualTo("Tom"));    // Highest priority
            queue.Remove();
            Assert.That(queue.Head().ToString(), Is.EqualTo("Anna"));
            queue.Remove();
            Assert.That(queue.Head().ToString(), Is.EqualTo("Bob"));
        }

        [Test]
        public void HeapPriorityQueue_ShouldRespectPriorityOrder()
        {
            var queue = new HeapPriorityQueue<Person>(Capacity);

            queue.Add(new Person("Emma"), 5);       // Highest priority
            queue.Add(new Person("Liam"), 1);       // Lowest priority
            queue.Add(new Person("Sophia"), 3);

            Assert.That(queue.Head().ToString(), Is.EqualTo("Emma"));   // Priority 5
            queue.Remove();
            Assert.That(queue.Head().ToString(), Is.EqualTo("Sophia"));  // Priority 3
            queue.Remove();
            Assert.That(queue.Head().ToString(), Is.EqualTo("Liam"));   // Priority 1
        }

        [Test]
        public void Queue_ShouldThrowOverflowException()
        {
            var queue = new SortedArrayPriorityQueue<Person>(Capacity);

            for (int i = 0; i < Capacity; i++)
            {
                queue.Add(new Person($"Person{i}"), i + 1);
            }

            Assert.Throws<QueueOverflowException>(() =>
                queue.Add(new Person("Overflow"), 10));
        }

        [Test]
        public void Queue_ShouldThrowUnderflowException()
        {
            var queue = new UnsortedArrayPriorityQueue<Person>(Capacity);

            Assert.Throws<QueueUnderflowException>(() => queue.Remove());
        }

        [Test]
        public void IsEmpty_ShouldReturnCorrectStatus()
        {
            var queue = new UnsortedLinkedPriorityQueue<Person>(Capacity);

            Assert.That(queue.IsEmpty(), Is.True);

            queue.Add(new Person("John"), 1);
            Assert.That(queue.IsEmpty(), Is.False);

            queue.Remove();
            Assert.That(queue.IsEmpty(), Is.True);
        }
    }
}
