using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problem8
{
    internal class MergeTwoSortedArrays
    {
        public static void Run()
        {
            int[] nums1 = {1,7};
            int[] nums2 = {2,9,10};
            if (nums1.Length == 0 && nums2.Length == 0)
            {
                Console.WriteLine("Both arrays are empty");
            }
            else
            {
                int[] result = Merge(nums1, nums2);
                Console.WriteLine("The Merged array: ");


                foreach (int i in result)
                {
                    Console.Write($"{i} ");
                }
            }

            }

        

        static int[] Merge(int[] a, int[] b)
        {

            int l1 = a.Length;
            int l2 = b.Length;

     
            int[] result = new int[l1 + l2];

            if (l1 < 0)
            {
                return b;
            }
            else if (l2 < 0)
            {
                return a;
            }
           
            int i, j ,k;
            i = j = k = 0;
            while (i < l1 && j < l2)
            {
                if (a[i] < b[j])
                {
                    result[k++] = a[i++];
                   
                }
                else
                {
                   
                        result[k++] = b[j++];
                     
                    
                }
            }
            while (i < l1)
            {
                result[k++] = a[i++];
               

            }
            while (j < l2)
            {
                result[k] = b[j];
                k++;
                j++;
               

            }

            return result;


        }
 
    
    
    
    }//end of class
}//end of namespace
