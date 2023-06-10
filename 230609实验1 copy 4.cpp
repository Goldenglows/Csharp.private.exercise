#include <stdio.h>
#include <stdlib.h>

#define MAX_N 10000

void counting_sort(int nums[], int n) {
    // 声明计数数组，并全部初始化为0
    int count[MAX_N] = {0};

    int i;

    // 统计每一个元素出现的次数
    for (i = 0; i < n; i++) {
        count[nums[i]]++;
    }

    // 输出每个元素出现的总次数
    int cur_count = 0;  // 当前数字的出现总次数
    for (i = 0; i < MAX_N; i++) {
        cur_count += count[i];
        if (count[i] > 0) {
            printf("%d ", cur_count);
        }
    }
    printf("\n");

    // 对于计数数组中的每一项，计算不大于该项的数字一共有多少个
    for (i = 1; i < MAX_N; i++) {
        count[i] += count[i - 1];
    }

    // 声明排序后的数组，并从后向前依此将每个元素加入rrr该位置上（因为相同元素会存在数组的后面）
    int *result = (int *)malloc(sizeof(int) * n);
    for (i = n - 1; i >= 0; i--) {
        result[--count[nums[i]]] = nums[i];
    }

    // 输出排序后的结果
    for (i = 0; i < n; i++) {
        printf("%d ", result[i]);
    }
    printf("\n");

    // 释放动态分配的内存
    free(result);
}


int main() {
    int n;
    scanf("%d", &n);
    int i;
    int nums[MAX_N];
    for (i = 0; i < n; i++) {
        scanf("%d", &nums[i]);
    }

    counting_sort(nums, n);

    return 0;
}


