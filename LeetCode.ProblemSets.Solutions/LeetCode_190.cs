public class LeetCode_190
{
    public uint reverseBits(uint n)
    {
        var mask = new uint[]
        {
            0x55555555,
            0x33333333,
            0x0f0f0f0f,
            0x00ff00ff
        };

        n = n >> 1 & mask[0] | (n & mask[0]) << 1;
        n = n >> 2 & mask[1] | (n & mask[1]) << 2;
        n = n >> 4 & mask[2] | (n & mask[2]) << 4;
        n = n >> 8 & mask[3] | (n & mask[3]) << 8;
        n = n >> 16 | (n << 16);
        return n;
    }
}