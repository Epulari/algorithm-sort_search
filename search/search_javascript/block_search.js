/**
 * Created by Epulari T on 2018/8/14.
 */


/**
 * 分块查找-数组已经是需要的结构
 * 块间有序，块内无序
 *
 * @para = arr 数组
 * @para = key 关键字
 * @para = blen 块大小
 */
function BlockSearch(arr, key, blen) {
	var len = arr.length;

	//序列的个数需要向上取整
	var num = Math.ceil(len / blen);
	console.log("序列个数：" + num);

	//temp为二维数组，按顺序存放块
	//minmax存放每个序列的最小值和最大值
	var temp = new Array(num), minmax = new Array(2 * num);
	//将最小值和最大值依次放入数组中，前半部分为最小值，后半部分为最大值
	for (var i = 0; i < num; i++) {
		temp[i] = arr.slice(i * blen, (i + 1) * blen);
		minmax[i] = Math.min.apply(null, temp[i]);
		minmax[i + num] = Math.max.apply(null, temp[i]);
	}
	console.log("序列数组：")
	console.log(temp);
	console.log("最小值最大值：" + minmax);

	//使用二分查找找到关键值属于的块索引
	var indexblock = BinarySearchBlock(minmax, key, num);
	if(indexblock != -1) {
		//使用二分查找找到关键值在块内的索引
		var indexnum = BinarySearchNum(temp[indexblock], key);
		if(indexnum != -1) {
			return indexnum + indexblock   * blen;
		}
	}
	return -1;
}

var arr = [7, 22, 23, 24, 26, 27, 28, 32, 33, 38, 53, 54, 78];
var index = BlockSearch(arr, 53, 4);
console.log("查找成功：" + index);
var index = BlockSearch(arr, 52, 4);
console.log("查找失败：" + index);
/**
 * result
	序列个数： 4
	序列数组：
	[ [ 7, 22, 23, 24 ],
	  [ 26, 27, 28, 32 ],
	  [ 33, 38, 53, 54 ],
	  [ 78 ] ]
	最小值最大值：7,26,33,78,24,32,54,78
	查找成功：10

	序列个数：4
	序列数组：
	[ [ 7, 22, 23, 24 ],
	  [ 26, 27, 28, 32 ],
	  [ 33, 38, 53, 54 ],
	  [ 78 ] ]
	最小值最大值：7,26,33,78,24,32,54,78
	查找失败：-1
 */

/**
 * 使用二分查找找到关键值属于的块索引
 *
 * @para = arr 数组
 * @para = key 关键字
 * @para = num 块个数
 */
function BinarySearchBlock(arr, key, num) {
	var len = arr.length;
	var low = 0, high = num - 1, mid;
	while(low <= high && high < len) {
		mid = Math.floor((low + high) / 2);
		if(arr[mid] <= key && arr[mid + num] >= key) {
			return mid;
		}
		else if(arr[mid] > key) {
			high = mid - 1;
		}
		else {
			low = mid + 1;
		}
	}
	return -1;
}
/**
 * 使用二分查找找到关键值在块内的索引
 *
 * @para = arr 数组
 * @para = key 关键字
 */
function BinarySearchNum(arr, key) {
	var len = arr.length;
	var low = 0, high = len - 1, mid;
	while(low <= high && high < len) {
		mid = Math.floor((low + high) / 2);
		if(arr[mid] == key) {
			return mid;
		}
		else if(arr[mid] > key) {
			high = mid - 1;
		}
		else {
			low = mid + 1;
		}
	}
	return -1;
}