using NUnit.Framework;
using NUnit.Framework.Legacy;
using PriorityQueue;

namespace PriorityQueueTests
{
    [TestFixture]
    public class PriorityQueueTests
    {
        private UnsortedArrayPriorityQueue<string> unsortedArrayQueue;
        private SortedLinkedPriorityQueue<string> sortedLinkedQueue;
        private UnsortedLinkedPriorityQueue<string> unsortedLinkedQueue;
        private HeapPriorityQueue<string> heapQueue;

        [SetUp]
        public void Setup()
        {
            unsortedArrayQueue = new UnsortedArrayPriorityQueue<string>(5);
            sortedLinkedQueue = new SortedLinkedPriorityQueue<string>();
            unsortedLinkedQueue = new UnsortedLinkedPriorityQueue<string>();
            heapQueue = new HeapPriorityQueue<string>(5);
        }

        [Test]
        public void Test_AddAndHead_UnsortedArrayPriorityQueue()
        {
            unsortedArrayQueue.Add("A", 1);
            unsortedArrayQueue.Add("B", 2);
            ClassicAssert.AreEqual("B", unsortedArrayQueue.Head());  // Highest priority
        }

        [Test]
        public void Test_Remove_UnsortedArrayPriorityQueue()
        {
            unsortedArrayQueue.Add("A", 1);
            unsortedArrayQueue.Add("B", 2);
            unsortedArrayQueue.Remove();
            ClassicAssert.AreEqual("A", unsortedArrayQueue.Head());  // Next highest priority
        }

        [Test]
        public void Test_QueueUnderflowException()
        {
            Assert.Throws<QueueUnderflowException>(() => unsortedArrayQueue.Head());
        }

        [Test]
        public void Test_QueueOverflowException()
        {
            unsortedArrayQueue.Add("A", 1);
            unsortedArrayQueue.Add("B", 2);
            unsortedArrayQueue.Add("C", 3);
            unsortedArrayQueue.Add("D", 4);
            unsortedArrayQueue.Add("E", 5);

            Assert.Throws<QueueOverflowException>(() => unsortedArrayQueue.Add("F", 6));
        }
    }
}
