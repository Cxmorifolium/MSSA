/* rotate array in place 90 degrees
[ 1 2 3 ]    [ 1 4 7 ]    [ 7 4 1 ]
[ 4 5 6 ] => [ 2 5 8 ] => [ 8 5 2 ]
[ 7 8 9 ]    [ 3 6 9 ]    [ 9 6 3 ]
Original =>  transpose => reverse
Ah yes, matrix math coming in handy.
Method? No. Ofc there's no builtin method like python for transpose lol
But at least there's array.reverse
transpose is  [i, j] to [j, i]

I phoned a friend: Hashmap 
var rotated = new Dictionary<(int, int), int>(); // where tuple: <(row, column>, value at that position)
        
        foreach (var kvp in matrix)
        {
            var (i, j) = kvp.Key; // original matrix position
            // All in one step
            rotated[(j, size-1-i)] = kvp.Value;
        }

but wait--- it's not in place lol. dang. gotta write it out then use array.reverse method
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // Tested it on leetcode instead
    }

    static void Rotate(int[][] matrix)
    {
        // Basically a slightly more advance version from a previous array swap in place problem
        // TRANSPOSE
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j =  i + 1; j < matrix.length; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }
        
        //REVERSE
        for (int i = 0; i < matrix.Length; i++)
        {
            Array.Reverse(matrix[i]);
        }

    }
}