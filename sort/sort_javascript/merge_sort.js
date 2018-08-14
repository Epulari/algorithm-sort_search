/**
 * Created by Epulari T on 2018/8/9.
 */




/**
 * 归并排序
 * 依次选出数组最小的数进行重新排列构建为有序数组。先使每个子序列有序，再使子序列段间有序，将已有序的子序列合并，得到完全有序的序列
 */

/**
 * 归并排序-“治”
 * 合并相邻有序子序列
 *
 * @para = left 左数组
 * @para = right 右数组
 */
function MergeArray(left, right) {
	var arr = [];
	//两数组都有元素时
	while(left.length && right.length) {
		if(left[0] <= right[0]) {
			arr.push(left.shift());
		}
		else {
			arr.push(right.shift());
		}
	}
	//合并后的序列为arr与剩下的左数组或右数组的结合
	arr = arr.concat(left, right);
	console.log(arr);
	return arr;
}


/**
 * 归并排序-分1
 * 使用递归对数组进行分治，直到每个序列只有一个元素
 *
 * @para = arr 数组
 */
function MergeSort(arr) {
	var len = arr.length;
	//判断数组长度，如果当前传入的数组只有一个元素就结束递归
	if (len < 2) {
		return arr;
	}
	//选取中间元素为基准元素
	var mid = Math.floor(len / 2);
	var left = arr.slice(0, mid), right = arr.slice(mid);
	return MergeArray(MergeSort(left), MergeSort(right)); //递归
}

var arr = [7, 26, 53, 22, 32, 28, 38, 23, 24, 54, 27, 78, 33];
console.log("归并排序1:");
MergeSort(arr);

/**
 * result
	左数组的左数组的右数组的左右数组合并结果（左数组的左数组的左数组只有一个元素，不操作）
	[ 26, 53 ]
	左数组的左数组的左右数组合并结果
	[ 7, 26, 53 ]
	左数组的右数组的右数组的左右数组合并结果（左数组的右数组的左数组只有一个元素，不操作）
	[ 28, 32 ]
	左数组的右数组的左右数组合并结果
	[ 22, 28, 32 ]
	左数组的左右数组合并结果
	[ 7, 22, 26, 28, 32, 53 ]
	右数组的左数组的右数组的左右数组合并结果（右数组的左数组的左数组只有一个元素，不操作）
	[ 23, 24 ]
	右数组的左数组的左右数组合并结果
	[ 23, 24, 38 ]
	右数组的右数组的左数组的左右数组合并结果
	[ 27, 54 ]
	右数组的右数组的右数组的左右数组合并结果
	[ 33, 78 ]
	右数组的右数组的左右数组合并结果
	[ 27, 33, 54, 78 ]
	右数组的左右数组合并结果
	[ 23, 24, 27, 33, 38, 54, 78 ]
	最后的合并结果
	[ 7, 22, 23, 24, 26, 27, 28, 32, 33, 38, 53, 54, 78 ]
 */


/**
 * 归并排序-分2
 * 使用迭代对数组进行分治
 *
 * @para = arr 数组
 */
function mergeSort(arr) {
	var len = arr.length;
	//判断数组长度，如果当前传入的数组只有一个元素就结束递归
	if (len < 2) {
		return arr;
	}

	//把数组每一个元素变成一个数组：归并排序是从元素个数为1的序列开始的
	var temp = [];
	for (var i = 0; i < len; i++) {
		temp.push([arr[i]]);
	}
	//占位元素，如果数组长度为奇数，需要与最后一个元素进行比较匹配
	temp.push([]);

	//maxindex = Math.floor((maxindex + 1) / 2)或者maxindex = temp.length - 1都可以
	//由于是2i和2i+1进行比较，因此2i的值应该小于最后一个元素的索引，而不是数组的长度
	//在第一次进入循环时，len的值是arr的长度，但实际上temp的长度还要加上占位元素，因此len的值是temp的最后一个元素的索引
	for (var maxindex = len; maxindex > 1; maxindex = temp.length - 1) {
		//从左至右依次对相邻两个数组排序并合并
		//数组长度为偶数时，相邻元素结合后，2i的值等于长度值，虽然还剩下占位元素，但不满足循环条件则结束循环
		//数组长度为奇数时，相邻元素结合后，2i的值小于长度值，剩下最后一个元素和占位元素，依旧进入循环进行比较，然后2j的值大于长度值，结束循环
		//占位元素必须存在，否则数组长度为奇数时，最后一个元素temp[2*i]存在，但与之比较的temp[2*i+1]不存在
		for (var i = 0; 2 * i < maxindex; i++) {
			temp[i] = MergeArray(temp[2 * i], temp[2 * i + 1]);
		}
		//只留下合并后的元素
		temp.length = i;

		//占位元素，如果数组长度为奇数，需要与最后一个元素进行比较匹配
		temp[i] = [];
	}
	return temp[0];
}

var arr = [7, 26, 53, 22, 32, 28, 38, 23, 24, 54, 27, 78, 33];
console.log("归并排序2:");
mergeSort(arr);

/**
 * result
	maxindex=arr.length=13时的循环，数组长度为奇数，末尾元素与占位元素合并，结果len=7+新的占位元素=8：
	[ 7, 26 ]
	[ 22, 53 ]
	[ 28, 32 ]
	[ 23, 38 ]
	[ 24, 54 ]
	[ 27, 78 ]
	[ 33 ]
	maxindex=temp.length-1=7时的循环，结果len=3+新的占位元素=5：
	[ 7, 22, 26, 53 ]
	[ 23, 28, 32, 38 ]
	[ 24, 27, 54, 78 ]
	[ 33 ]
	len=temp.length-1=4时的循环，结果len=2+新的占位元素=3：
	[ 7, 22, 23, 26, 28, 32, 38, 53 ]
	[ 24, 27, 33, 54, 78 ]
	maxindex=temp.length-1=2时的循环，结果len=1+新的占位元素=2：
	[ 7, 22, 23, 24, 26, 27, 28, 32, 33, 38, 53, 54, 78 ]
	上面结果temp有两个元素，首元素是有序序列，尾元素是占位元素，首元素即为结果
 */