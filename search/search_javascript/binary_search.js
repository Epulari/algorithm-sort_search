/**
 * Created by Epulari T on 2018/8/14.
 */

/**
 * 二分查找-迭代法
 * 根据首尾元素的索引值将序列分成两半，再依次将中间值及子序列与关键字对比
 *
 * @para = arr 数组
 * @para = key 关键字
 */
function BinarySearch(arr, key) {
	var len = arr.length;
	var low = 0, high = len - 1, mid;
	while(low <= high && high < len) {
		//中间元素为首元素索引与尾元素索引和的平均值
		//为了防止溢出，使用位运算(right - left) >> 1替代(low + high) / 2，又使用(right - left) >>> 1替代(right - left) >> 1
		mid = Math.floor((low + high) / 2);
		if(arr[mid] == key) {
			console.log("mid：" + mid);
			return mid;
		}
		else if(arr[mid] > key) {
			high = mid - 1;
		}
		else {
			low = mid + 1;
		}
		console.log("low-high：" + low + "-" + high);
	}
	return -1;
}

var arr = [7, 22, 23, 24, 26, 27, 28, 32, 33, 38, 53, 54, 78];
console.log("二分查找1：");
var index = BinarySearch(arr, 53);
console.log("查找成功：" + index);
var index = BinarySearch(arr, 52);
console.log("查找失败：" + index);

/**
 * result
	查找成功
	low-high：7-12
	low-high：10-12
	low-high：10-10
	mid：10
	查找失败
	low-high：7-12
	low-high：10-12
	low-high：10-10
	low-high：10-9
 */


/**
 * 二分查找-递归法
 * 根据首尾元素的索引值将序列分成两半，再依次将中间值及子序列与关键字对比
 *
 * @para = arr 数组
 * @para = key 关键字
 * @para = low 数组最小索引值
 * @para = high 数组最大索引值
 */
function BinarySearch2(arr, key, low, high) {
	var len = arr.length;

	if(low <= high && high < len) {
		//中间元素为首元素索引与尾元素索引和的平均值
		//为了防止溢出，使用位运算(right - left) >> 1替代(low + high) / 2，又使用(right - left) >>> 1替代(right - left) >> 1
		var mid = Math.floor((low + high) / 2);
		if(arr[mid] == key) {
			console.log("mid：" + mid);
			return mid;
		}
		else if(arr[mid] > key) {
			high = mid - 1;
			console.log("low-high：" + low + "-" + high);
			return BinarySearch2(arr, key, low, high);
		}
		else {
			low = mid + 1;
			console.log("low-high：" + low + "-" + high);
			return BinarySearch2(arr, key, low, high);
		}
	}
	return -1;
}

var arr = [7, 22, 23, 24, 26, 27, 28, 32, 33, 38, 53, 54, 78]
console.log("二分查找2：");
var index = BinarySearch2(arr, 53, 0, arr.length - 1);
console.log("查找成功：" + index);
var index = BinarySearch2(arr, 52, 0, arr.length - 1);
console.log("查找失败：" + index);

/**
 * result
	查找成功：
	low-high：7-12
	low-high：10-12
	low-high：10-10
	mid：10
	查找失败：
	low-high：7-12
	low-high：10-12
	low-high：10-10
	low-high：10-9
 */