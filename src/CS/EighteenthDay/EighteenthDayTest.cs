using NUnit.Framework;
using EighteenthDay;

namespace EighteenthDay.Tests
{
    [TestFixture]
    public class SolutionTests
    {
        [Test]
        public void PushCharacterTest()
        {
            Solution s = new Solution();
            s.PushCharacter('d');
            char d = s.PopCharacter();
            Assert.AreEqual('d', d);
        }

        [Test]
        public void EnqueueCharacterTest()
        {
            Solution s = new Solution();
            s.EnqueueCharacter('d');
            char d = s.DequeueCharacter();
            Assert.AreEqual('d', d);
        }

        [Test]
        public void PopCharacterTest()
        {
            Solution s = new Solution();
            s.PushCharacter('d');
            char d = s.PopCharacter();
            Assert.AreEqual('d', d);
        }

        [Test]
        public void DequeueCharacterTest()
        {
            Solution s = new Solution();
            s.EnqueueCharacter('d');
            char d = s.DequeueCharacter();
            Assert.AreEqual('d', d);
        }

        [Test]
        public void MainTest()
        {
            // read the string s.
            string s = "abracadabra";
//            string s = "racecar";

            // create the Solution class object p.
            Solution obj = new Solution();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.PushCharacter(c);
                obj.EnqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.PopCharacter() != obj.DequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Assert.Pass($"The word, {s}, is a palindrome.");
            }
            else
            {
                Assert.Pass($"The word, {s}, is not a palindrome.");
            }
        }
    }
}
