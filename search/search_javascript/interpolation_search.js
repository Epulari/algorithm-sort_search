/**
 * Created by Epulari T on 2018/8/14.
 */

/**
 * 插值查找-迭代法
 * 改进的折半查找，mid计算方式不同
 *
 * @para = arr 数组
 * @para = key 关键字
 */
function InterpolationSearch(arr, key) {
	var len = arr.length;
	var low = 0, high = len - 1, mid;
	while(low <= high && high < len) {
		//使用复杂的四则运算定义中间值索引

		// //方法一：由于Math.floor对任何数都向下取整，当key不存在时，分母可能出现负数，则出现mid<low的情况，因而第一个if条件必须进行判断
		// var mid = Math.floor(low + (high - low) * (key - arr[low]) / (arr[high] - arr[low]));
		// if(mid < low) {
		// 	console.log("low-mid-high：" + low + "-" + mid + "-" + high);
		// 	return -1;
		// }
		// else if ...// //方法一：由于Math.floor对任何数都向下取整，当key不存在时，分母可能出现负数，则出现mid<low的情况，因而第一个if条件必须进行判断
		// var mid = Math.floor(low + (high - low) * (key - arr[low]) / (arr[high] - arr[low]));
		// if(mid < low) {
		// 	console.log("low-mid-high：" + low + "-" + mid + "-" + high);
		// 	return -1;
		// }
		// else if ...

		//方法二：对后面的分数计算结果取整，正数向下取整，负数向上取整
		var mid = low + parseInt((high - low) * (key - arr[low]) / (arr[high] - arr[low]));

		if(arr[mid] == key) {
			console.log("mid：" + mid);
			return mid;
		}
		else if(arr[mid] > key) {
			high = mid - 1;
			console.log("low-high：" + low + "-" + high);
		}
		else {
			low = mid + 1;
			console.log("low-high：" + low + "-" + high);
		}
	}
	return -1;
}

var arr = [7, 22, 23, 24, 26, 27, 28, 32, 33, 38, 53, 54, 78];
console.log("插值查找1：");
console.log("查找成功");
var index = InterpolationSearch(arr, 53);
console.log(index);
console.log("查找失败");
var index = InterpolationSearch(arr, 52);
console.log(index);

/**
 * result
	查找成功
	low-high：8-12
	low-high：10-12
	mid：10
	10
	查找失败
	low-high：8-12
	low-high：10-12
	low-mid-high：10-9-12
	-1
 */


/**
 * 插值查找-递归法
 * 改进的折半查找
 *
 * @para = arr 数组
 * @para = key 关键字
 * @para = low 数组最小索引值
 * @para = high 数组最大索引值
 */
function InterpolationSearch2(arr, key, low, high) {
	var len = arr.length;
	if(low <= high && high < len) {
		//使用复杂的四则运算定义中间值索引

		// //方法一：由于Math.floor对任何数都向下取整，当key不存在时，分母可能出现负数，则出现mid<low的情况，因而第一个if条件必须进行判断
		// var mid = Math.floor(low + (high - low) * (key - arr[low]) / (arr[high] - arr[low]));
		// if(mid < low) {
		// 	console.log("low-mid-high：" + low + "-" + mid + "-" + high);
		// 	return -1;
		// }
		// else if ...

		//方法二：对后面的分数计算结果取整，正数向下取整，负数向上取整
		var mid = low + parseInt((high - low) * (key - arr[low]) / (arr[high] - arr[low]));

		if(arr[mid] == key) {
			console.log("mid：" + mid);
			return mid;
		}
		else if(arr[mid] > key) {
			high = mid - 1;
			console.log("low-high：" + low + "-" + high);
			//return InterpolationSearch2(arr, key, low, high);
			//arguments的callee属性是一个指针，指向拥有这个arguments对象的函数
			return arguments.callee(arr, key, low, high);
		}
		else {
			low = mid + 1;
			console.log("low-high：" + low + "-" + high);
			//return InterpolationSearch2(arr, key, low, high);
			//arguments的callee属性是一个指针，指向拥有这个arguments对象的函数
			return arguments.callee(arr, key, low, high);
		}
	}
	return -1;
}

var arr = [7, 22, 23, 24, 26, 27, 28, 32, 33, 38, 53, 54, 78]
console.log("插值查找2：");
console.log("查找成功");
var index = InterpolationSearch2(arr, 53, 0, arr.length - 1);
console.log("查找失败");
var index = InterpolationSearch2(arr, 52, 0, arr.length - 1);
console.log(index);

/**
 * result
	查找成功
	low-high：8-12
	low-high：10-12
	mid：10
	查找失败
	low-high：8-12
	low-high：10-12
	low-mid-high：10-9-12
	-1
 */