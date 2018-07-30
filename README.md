# 排序和搜索算法

## 排序算法
排序算法 | 平均时间复杂度 | 最好情况 | 最坏情况 | 空间复杂度 | 排序方式 | 基本思想 | 稳定性
---- | ---- | ---- | ---- | ---- | ---- | ---- | ----
冒泡排序 | O(n<sup>2</sup>) | O(n) | O(n<sup>2</sup>) | O(1) | In-place | 交换排序 | 稳定
快速排序 | O(nlogn) | O(nlogn) | O(n<sup>2</sup>) | O(nlogn) | In-place | 交换排序 | 不稳定
插入排序 | O(n<sup>2</sup>) | O(n) | O(n<sup>2</sup>) | O(1) | In-place | 插入排序 | 稳定
希尔排序 | O(nlogn) | O(nlog<sup>2</sup>n) | O(nlog<sup>2</sup>n) | O(1) | In-place | 插入排序 | 不稳定
选择排序 | O(n<sup>2</sup>) | O(n<sup>2</sup>) | O(n<sup>2</sup>) | O(1) | In-place | 选择排序 | 不稳定
堆排序 | O(nlogn) | O(nlogn) | O(nlogn) | O(1) | In-place | 选择排序 | 不稳定
归并排序 | O(nlogn) | O(nlogn) | O(nlogn) | O(n) | Out-place | 归并排序 | 稳定
基数排序 | O(n*k) | O(n*k) | O(n*k) | O(n+k) | Out-place | 基数排序 | 稳定
计数排序 | O(n+k) | O(n+k) | O(n+k) | O(k) | Out-place | 计数排序 | 稳定
桶排序 | O(n+k) | O(n+k) | O(n<sup>2</sup>) | O(n+k) | Out-place | 桶排序 | 稳定

### 冒泡排序 Bubble Sort
**基本思想：**  
　　比较相邻的两个数，如果前者比后者大，则进行交换，每一轮排序后最后一个元素必然是最大的数。（如果数是按列排列，则较大的数下沉，较小的数冒起来。）  
**算法步骤：**  
　　1) 比较第1个和第2个元素，如果前者比后者大，则交换它们；  
　　2) 在上面的结果上比较第2个和第3个元素，如果前者比后者大，则交换它们；  
　　3) 按照上面的方式依次比较相邻元素，完成后最后的元素是最大的数；  
　　4) 排除上面结果的最后一个元素后重复上面的过程，直到没有任何一对数字需要比较。  
**时间复杂度：**  
　　最佳情况：T(n) = O(n)，当输入的数据已经是正序时；  
　　最差情况：T(n) = O(n<sup>2</sup>)，当输入的数据是反序时  
　　平均情况：T(n) = O(n<sup>2</sup>)  

### 快速排序 Quick Sort

### 插入排序 Insertion Sort

### 希尔排序 Shell Sort

### 选择排序 Selction Sort

### 堆  排序 Heap Sort

### 归并排序 Merge Sort

### 基数排序 Radix Sort

## 搜索算法