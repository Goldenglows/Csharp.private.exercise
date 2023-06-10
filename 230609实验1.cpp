#include <stdio.h>
#include <stdlib.h>

#define MAX_NUM 100000

int main() {
    int m;
    scanf("%d", &m); // 输入数组长度

    int i;
    int nums[m];
    for (i = 0; i < m; i++) {
        scanf("%d", &nums[i]); // 输入数组元素
    }

    int dist[MAX_NUM + 1] = {0}; // 分布值数组，存放每个元素出现的次数
    for (i = 0; i < m; i++) {
        dist[nums[i]]++; // 统计每个元素出现的次数
    }

    for (i = 1; i <= MAX_NUM; i++) {
        dist[i] += dist[i - 1]; // 对分布值数组进行前缀和，表示每个元素应该排在第几个位置
    }

    int sorted[m];
    for (i = m - 1; i >= 0; i--) { // 倒序遍历原数组，从后往前填充排序结果数组
        sorted[dist[nums[i]] - 1] = nums[i];
        dist[nums[i]]--; // 将分布值减一，使得相同元素能够排在不同的位置
    }

    printf("%d", dist[0]); // 输出分布值数组
    for (i = 1; i <= MAX_NUM; i++) {
        printf(" %d", dist[i]);
    }
    printf("\n");

    printf("%d", sorted[0]); // 输出排序结果数组
    for (i = 1; i < m; i++) {
        printf(" %d", sorted[i]);
    }
    printf("\n");

    return 0;
}