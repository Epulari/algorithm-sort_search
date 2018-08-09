/**
 * Created by Epulari T on 2018/8/9.
 */


/**
 *计数排序
 *使用一个额外的数组，其中第i个元素是待排序数组中值等于i的元素的个数
 *
 * @para = arr 数组
 */
function CountingSort(arr) {
	var len = len = arr.length;
	if(len < 2) {
		return arr;
	}

	//获取数组的最小值和最大值
	var min = arr[0], max = arr[0];
	for(var i = 1; i < len; i++) {
		if (min > arr[i]) {
			min = arr[i];
		}
		else if (max < arr[i]) {
			max = arr[i];
		}
		else {}
	}
	console.log("数组最小值：" + min);
	console.log("数组最大值：" + max);

	//根据最大值max初始化额外数组，数组最大索引值为max，则数组长度为max+1
	var temp = Array.apply(null, Array(max + 1)).map(function(item, key) {
	    return 0;
	});

	//统计数组每个数的个数
	for(var i = 0; i < len; i++) {
		var index = arr[i];
		temp[index] += 1;
	}
	console.log("每个元素个数统计：" + temp);

	//根据索引i的值依次在新数组中展开索引i
	var newarr = [];
	for(var i = min; i < max + 1; i++) {
		//每在新数组中添加一个索引，原数组中索引对应的值就减1
		while(temp[i] !== 0) {
			newarr.push(i);
			temp[i] -= 1;
		}
	}
	console.log(newarr);

	return newarr;
}

var arr = [7, 26, 53, 22, 32, 28, 38, 23, 24, 54, 27, 78, 33];
CountingSort(arr);

/**
 * result
数组最小值：7
数组最大值：78
每个元素个数统计：0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,0,1,1,1,0,0,0,1,1,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1
[ 7, 22, 23, 24, 26, 27, 28, 32, 33, 38, 53, 54, 78 ]
 */