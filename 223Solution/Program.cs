public class Solution {
    public static int Main(string[] args)
    {
        return 0;
    }

    public int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2) {
        int aArea = GetArea(ax1, ay1, ax2, ay2);
        int bArea = GetArea(bx1, by1, bx2, by2);
        int cArea = 0;

        if (Overlap(ax1, ay1, ax2, ay2, bx1, by1, bx2, by2))
        {
            int cx1 = Math.Max(ax1, bx1);
            int cy1 = Math.Max(ay1, by1);
            int cx2 = Math.Min(ax2, bx2);
            int cy2 = Math.Min(ay2, by2);

            cArea = GetArea(cx1, cy1, cx2, cy2);
        }

        return (aArea + bArea - cArea);
    }

    private bool Overlap(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2)
    {
        if (ax1 > bx2 ||
            bx1 > ax2 ||
            ay1 > by2 ||
            by1 > ay2)
        {
            return false;
        }
        else
        {
            return true;
        }    
    }

    private int GetArea(int x1, int y1, int x2, int y2)
    {
        int length = x2 - x1;
        int height = y2 - y1;

        return length * height;
    }
}