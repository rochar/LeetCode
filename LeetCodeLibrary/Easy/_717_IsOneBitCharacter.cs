namespace LeetCodeLibrary.Easy
{
    public class _717_IsOneBitCharacter
    {
        public bool IsOneBitCharacter(int[] bits)
        {
            var size = bits.Length;
            var lastIsOneCharacter = true;
            var currentIndex = 0;
            while (currentIndex < size)
            {
                switch (bits[currentIndex])
                {
                    case 1:
                        currentIndex += 2;
                        lastIsOneCharacter = false;
                        break;
                    case 0:
                        currentIndex++;
                        lastIsOneCharacter = true;
                        break;
                }
            }

            return lastIsOneCharacter;
        }
    }
}