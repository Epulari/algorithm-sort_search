/**
 * Created by Epulari T on 2018/8/2.
 */


/**
 *插入排序1
 *一组乱序数据，设定前一半是已排好序的数，将剩余的数依次在已排好序的数中从后向前扫描找到对应位置并插入
 *如果待插入的元素与有序序列中的某个元素相等，则插入到相等元素后面
 *这个算法需要反复把已排好顺序的元素逐步向后挪动，为新元素提供插入空间
 *
 *每轮内部比较时，将待排元素与前一个比较，如果待排元素小，则交换两元素值，依次交换到满足条件为止
 *
 * @para = arr 数组
 */
function InsertionSort(arr) {
	var len = arr.length;
	if(len < 2) {
		return arr;
	}
	//外层循环：一轮比较。每次已排序列多一个元素，i代表已排序列元素的最大索引，最开始只有一个元素arr[0]
	for(var i = 0; i < len - 1; i++) {
		//内层循环：进行每轮的单个元素比较。待排元素为已排元素的下一个值arr[i + 1]，即arr[j]，将之与已排元素进行比较并交换
		for (var j = i + 1; j > 0; j--) {
			//如果待排元素小于已排序数则交换两个数
			if (arr[j] < arr[j - 1]) {
				var temp = arr[j - 1];
				arr[j - 1] = arr[j];
				arr[j] = temp;
			}
			//待排元素不小于已排序数说明已完成本轮排序，跳出循环
			else {
				break;
			}
		}
		console.log(arr);
	}
	return arr;
}

var arr = [7, 26, 53, 22, 32, 28, 38, 23, 24, 54, 27, 78, 33];
console.log("插入排序1:");
InsertionSort(arr);

/**
 * result
[ 7, 26, 53, 22, 32, 28, 38, 23, 24, 54, 27, 78, 33 ]
[ 7, 26, 53, 22, 32, 28, 38, 23, 24, 54, 27, 78, 33 ]
[ 7, 22, 26, 53, 32, 28, 38, 23, 24, 54, 27, 78, 33 ]
[ 7, 22, 26, 32, 53, 28, 38, 23, 24, 54, 27, 78, 33 ]
[ 7, 22, 26, 28, 32, 53, 38, 23, 24, 54, 27, 78, 33 ]
[ 7, 22, 26, 28, 32, 38, 53, 23, 24, 54, 27, 78, 33 ]
[ 7, 22, 23, 26, 28, 32, 38, 53, 24, 54, 27, 78, 33 ]
[ 7, 22, 23, 24, 26, 28, 32, 38, 53, 54, 27, 78, 33 ]
[ 7, 22, 23, 24, 26, 28, 32, 38, 53, 54, 27, 78, 33 ]
[ 7, 22, 23, 24, 26, 27, 28, 32, 38, 53, 54, 78, 33 ]
[ 7, 22, 23, 24, 26, 27, 28, 32, 38, 53, 54, 78, 33 ]
[ 7, 22, 23, 24, 26, 27, 28, 32, 33, 38, 53, 54, 78 ]
 */


/**
 *插入排序2
 *一组乱序数据，设定前一半是已排好序的数，将剩余的数依次在已排好序的数中从后向前扫描找到对应位置并插入
 *如果待插入的元素与有序序列中的某个元素相等，则插入到相等元素后面
 *这个算法需要反复把已排好顺序的元素逐步向后挪动，为新元素提供插入空间
 *
 *每轮内部比较时，将待排元素与已排序数比较，如果待排元素小于已排序数，则将已排序数向后移位，直到待排元素大于或等于某已排元素，则将待排元素放入到该元素后的空位
 *
 * @para = arr 数组
 */
function InsertionSort2(arr) {
	var len = arr.length;
	if(len < 2) {
		return arr;
	}
	//外层循环：一轮比较。每次已排序列多一个元素，i代表已排序列元素的最大索引，最开始只有一个元素arr[0]
	for(var i = 1; i < len; i++) {
		//待排元素
		var current = arr[i];
		//j为已排元素，最大取值为待排元素上一位
		var j = i - 1;
		//内层循环：进行每轮的单个元素比较。待排元素与已排元素从后向前依次进行比较，并向后移位，待排元素不小于已排序数说明已完成本轮排序，跳出循环
		while(j >=0 && current < arr[j]) {
			arr[j + 1] = arr[j];
			j--;
		}
		//当不进入while循环内部时，避免同一个元素赋值给自身
		if (j + 1 !== i) {
			arr[j + 1] = current;
		}
		console.log(arr);
	}
	return arr;
}

var arr = [7, 26, 53, 22, 32, 28, 38, 23, 24, 54, 27, 78, 33];
console.log("插入排序2:");
InsertionSort2(arr);

/**
 * result
[ 7, 26, 53, 22, 32, 28, 38, 23, 24, 54, 27, 78, 33 ]
[ 7, 26, 53, 22, 32, 28, 38, 23, 24, 54, 27, 78, 33 ]
[ 7, 22, 26, 53, 32, 28, 38, 23, 24, 54, 27, 78, 33 ]
[ 7, 22, 26, 32, 53, 28, 38, 23, 24, 54, 27, 78, 33 ]
[ 7, 22, 26, 28, 32, 53, 38, 23, 24, 54, 27, 78, 33 ]
[ 7, 22, 26, 28, 32, 38, 53, 23, 24, 54, 27, 78, 33 ]
[ 7, 22, 23, 26, 28, 32, 38, 53, 24, 54, 27, 78, 33 ]
[ 7, 22, 23, 24, 26, 28, 32, 38, 53, 54, 27, 78, 33 ]
[ 7, 22, 23, 24, 26, 28, 32, 38, 53, 54, 27, 78, 33 ]
[ 7, 22, 23, 24, 26, 27, 28, 32, 38, 53, 54, 78, 33 ]
[ 7, 22, 23, 24, 26, 27, 28, 32, 38, 53, 54, 78, 33 ]
[ 7, 22, 23, 24, 26, 27, 28, 32, 33, 38, 53, 54, 78 ]
 */