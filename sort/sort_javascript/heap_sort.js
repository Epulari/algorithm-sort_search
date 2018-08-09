/**
 * Created by Epulari T on 2018/8/7.
 */

/**
 *堆排序
 *依次选出数组最小的数并放到新数组中，新数组为有序数组
 *
 * @para = arr 数组
 */
function HeapSort(arr) {
	var len = arr.length;
	if (len < 2) {
		return;
	}
	var temp = 0;
	//外层循环：一轮比较。每次交换首尾元素值，只有1个元素时跳出循环
	for (var k = 0; k < len - 1; len--) {
		//内层循环：从下向上，从右至左调整位置，构建大顶堆。堆顶为最大值，最大的非叶子节点索引为len/2-1
		//js里，所有的数都是浮点型，所以用 num1/num2 得出的数是浮点数，而非整数
		for(var i = Math.floor(len / 2) - 1; i > -1; i--) {
			//节点i的左子节点2i+1和右子节点2i+2
			var left = 2 * i + 1, right = 2 * i + 2;
			//假设左右子节点大的值的索引maxindex为left，左节点一定存在
			var maxindex = left;
			//选择左右子节点中大的节点
			if(right < len) {
				maxindex = arr[left] >= arr[right] ? left : right;
			}
			//判断父节点与子节点大小并交换
			if(arr[maxindex] > arr[i]) {
				temp = arr[i];
				arr[i] = arr[maxindex];
				arr[maxindex] = temp;
			}
		}
		//交换堆顶和堆尾元素
		temp = arr[0];
		arr[0] = arr[len - 1];
		arr[len - 1] = temp;

		console.log(arr);
	}
}

var arr = [7, 26, 53, 22, 32, 28, 38, 23, 24, 54, 27, 78, 33];
HeapSort(arr);

/**
 * result
[ 33, 54, 7, 24, 26, 53, 38, 23, 22, 32, 27, 28, 78 ]
[ 28, 33, 53, 24, 32, 7, 38, 23, 22, 26, 27, 54, 78 ]
[ 27, 33, 28, 24, 32, 7, 38, 23, 22, 26, 53, 54, 78 ]
[ 26, 33, 27, 24, 32, 7, 28, 23, 22, 38, 53, 54, 78 ]
[ 22, 26, 28, 24, 32, 7, 27, 23, 33, 38, 53, 54, 78 ]
[ 23, 22, 28, 24, 26, 7, 27, 32, 33, 38, 53, 54, 78 ]
[ 27, 26, 23, 24, 22, 7, 28, 32, 33, 38, 53, 54, 78 ]
[ 7, 26, 23, 24, 22, 27, 28, 32, 33, 38, 53, 54, 78 ]
[ 22, 7, 23, 24, 26, 27, 28, 32, 33, 38, 53, 54, 78 ]
[ 7, 22, 23, 24, 26, 27, 28, 32, 33, 38, 53, 54, 78 ]
[ 7, 22, 23, 24, 26, 27, 28, 32, 33, 38, 53, 54, 78 ]
[ 7, 22, 23, 24, 26, 27, 28, 32, 33, 38, 53, 54, 78 ]
 */