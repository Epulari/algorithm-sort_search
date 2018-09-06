/**
 * Created by Epulari T on 2018/8/17.
 */

/**
 * 斐波那契查找-迭代法
 * 根据斐波那契数列将序列分成两半，再依次将中间值及子序列与关键字对比
 *
 * @para = arr 数组
 * @para = key 关键字
 */
function FibonacciSearch(arr, key) {
	var len = arr.length;

	//根据数组长度创建斐波那契数列1,1,2,3,...(前面添加一个0不影响)
	var fibonacci = [];
	fibonacci.push(0);
	fibonacci.push(1);
	for(var i = 1; fibonacci[i] <= len ; i++) {
		fibonacci.push(fibonacci[i] + fibonacci[i - 1]);
	}
	console.log("斐波那契数列：" + fibonacci);

	//根据斐波那契数列扩展数组
	var k = fibonacci.length - 1, newlen = fibonacci[k] - 1;
	for(var i = len; i < newlen; i++) {
		arr.push(arr[len - 1]);
	}
	console.log("扩展后的数组：" + arr);

	//查找
	var low = 0, high = newlen - 1, mid;
	while(low <= high && high < newlen) {
		mid = low + (fibonacci[k - 1] - 1);
		if(arr[mid] == key) {
			console.log("mid-k：" + mid + "-" + k);
			if(mid < newlen) {
				return mid;
			}
			else {
				//若mid>=len则说明是扩展的数值,返回n-1
				return len -1;
			}
		}
		else if(arr[mid] > key) {
			//待查找的元素在[low,mid-1]范围内
			high = mid - 1;
			//范围[low,mid-1]内的元素个数为F(k-1)-1个，可以迭代地应用斐波那契查找
			k -= 1;
		}
		else {
			//待查找的元素在[mid+1,hign]范围内
			low = mid + 1;
			//范围[mid+1,high]内的元素个数为F(k-2)-1个，可以迭代地应用斐波那契查找
			//元素个数计算：新数组长度- 左序列个数 - mid元素 = newlen -（F(k-1) - 1) - 1 = (F(k) - 1) - F(k-1) = F(k) - F(k-1) - 1=F(k-2) - 1
			k -= 2;
		}
		console.log("low-high-k：" + low + "-" + high + "-" + k);
	}
	return -1;
}

var arr = [7, 22, 23, 24, 26, 27, 28, 32, 33, 38, 53, 54, 78];
console.log("斐波那契查找1：");
var index = FibonacciSearch(arr, 53);
console.log("查找成功：" + index);
var index = FibonacciSearch(arr, 52);
console.log("查找失败：" + index);

/**
 * result
	斐波那契数列：0,1,1,2,3,5,8,13,21
	扩展后的数组：7,22,23,24,26,27,28,32,33,38,53,54,78,78,78,78,78,78,78,78
	low-high-k：0-11-7
	low-high-k：8-11-5
	mid-k：10-5
	查找成功：10
	斐波那契数列：0,1,1,2,3,5,8,13,21
	扩展后的数组：7,22,23,24,26,27,28,32,33,38,53,54,78,78,78,78,78,78,78,78
	low-high-k：0-11-7
	low-high-k：8-11-5
	low-high-k：8-9-4
	low-high-k：10-9-2
	查找失败：-1
 */


/**
 * 斐波那契查找-递归法
 * 根据斐波那契数列将序列分成两半，再依次将中间值及子序列与关键字对比
 */
/**
 * 递归函数
 * 根据斐波那契数列进行分割
 *
 * @para = arr 扩展后的数组
 * @para = key 关键字
 * @para = low 数组最小索引值
 * @para = high 数组最大索引值
 * @para = fibonacci 斐波那契数列
 * @para = k 斐波那契数列索引
 * @para = len 原数组长度
 */
function FibonacciS(arr, key, low, high, fibonacci, k, len) {
	var newlen = arr.length, mid;
	if(low <= high && high < newlen) {
		mid = low + (fibonacci[k - 1] - 1);
		if(arr[mid] == key) {
			console.log("mid-k：" + mid + "-" + k);
			if(mid < newlen) {
				return mid;
			}
			else {
				//若mid>=len则说明是扩展的数值,返回n-1
				return len -1;
			}
		}
		else if(arr[mid] > key) {
			//待查找的元素在[low,mid-1]范围内
			high = mid - 1;
			//范围[low,mid-1]内的元素个数为F(k-1)-1个，可以递归地应用斐波那契查找
			k -= 1;
			console.log("low-high-k：" + low + "-" + high + "-" + k);
			//return FibonacciS(arr, key, low, high, fibonacci, k, len);
			//arguments的callee属性是一个指针，指向拥有这个arguments对象的函数
			return arguments.callee(arr, key, low, high, fibonacci, k, len);
		}
		else {
			//待查找的元素在[mid+1,hign]范围内
			low = mid + 1;
			//范围[mid+1,high]内的元素个数为F(k-2)-1个，可以递归地应用斐波那契查找
			//元素个数计算：新数组长度- 左序列个数 - mid元素 = newlen -（F(k-1) - 1) - 1 = (F(k) - 1) - F(k-1) = F(k) - F(k-1) - 1=F(k-2) - 1
			k -= 2;
			console.log("low-high-k：" + low + "-" + high + "-" + k);
			//return FibonacciS(arr, key, low, high, fibonacci, k, len);
			//arguments的callee属性是一个指针，指向拥有这个arguments对象的函数
			return arguments.callee(arr, key, low, high, fibonacci, k, len);
		}
	}
	return -1;
}
//创建斐波那契数列、扩展原数组、调用递归函数
function FibonacciSearch2(arr, key) {
	var len = arr.length;

	//根据数组长度创建斐波那契数列1,1,2,3,...(前面添加一个0不影响)
	var fibonacci = [];
	fibonacci.push(0);
	fibonacci.push(1);
	for(var i = 1; fibonacci[i] <= len ; i++) {
		fibonacci.push(fibonacci[i] + fibonacci[i - 1]);
	}
	console.log("斐波那契数列：" + fibonacci);

	//根据斐波那契数列扩展数组
	var k = fibonacci.length - 1, newlen = fibonacci[k] - 1;
	for(var i = len; i < newlen; i++) {
		arr.push(arr[len - 1]);
	}
	console.log("扩展后的数组：" + arr);

	//递归
	var index = FibonacciS(arr, key, 0, newlen - 1, fibonacci, k, len);
	return index;
}

var arr = [7, 22, 23, 24, 26, 27, 28, 32, 33, 38, 53, 54, 78]
console.log("斐波那契查找2：");
var index = FibonacciSearch2(arr, 53);
console.log("查找成功：" + index);
var index = FibonacciSearch2(arr, 52);
console.log("查找失败：" + index);

/**
 * result
	斐波那契数列：0,1,1,2,3,5,8,13,21
	扩展后的数组：7,22,23,24,26,27,28,32,33,38,53,54,78,78,78,78,78,78,78,78
	low-high-k：0-11-7
	low-high-k：8-11-5
	mid-k：10-5
	查找成功：10
	斐波那契数列：0,1,1,2,3,5,8,13,21
	扩展后的数组：7,22,23,24,26,27,28,32,33,38,53,54,78,78,78,78,78,78,78,78
	low-high-k：0-11-7
	low-high-k：8-11-5
	low-high-k：8-9-4
	low-high-k：10-9-2
	查找失败：-1
 */