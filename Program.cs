//*****************************************************************************
//** 81. Search in Rotated Sorted Array II                          leetcode **
//*****************************************************************************
//** A rotated path with shadows cast by twins,
//** Where ordered halves and ambiguity begin.
//** We split by mid and test which side is true,
//** And trim the edge till target comes to view.
//*****************************************************************************

bool search(int* nums, int numsSize, int target) {
    int l = 0;
    int r = numsSize - 1;
    int mid;

    while (l < r)
    {
        mid = (l + r) >> 1;

        if (nums[mid] > nums[r])
        {
            if (nums[l] <= target && target <= nums[mid])
            {
                r = mid;
            }
            else
            {
                l = mid + 1;
            }
        }
        else if (nums[mid] < nums[r])
        {
            if (nums[mid] < target && target <= nums[r])
            {
                l = mid + 1;
            }
            else
            {
                r = mid;
            }
        }
        else
        {
            r--;
        }
    }

    return nums[l] == target;
}