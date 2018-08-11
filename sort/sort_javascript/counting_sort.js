/**
 * Created by Epulari T on 2018/8/11.
 */


/**
 *计数排序
 *桶排序思想-求和计数：使用一个额外的数组，映射关系为f(x)=x-min，即其中第i-min个元素是待排序数组中值等于i的元素的个数，知道了数组中比x小的元素的个数，就可以直接把x放到第（x+1）个位置上，即元素索引为x
 *
 * @para = arr 数组
 */
function CountingSort(arr) {
	var len = arr.length;
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

	//c[arr[i] - min]的索引arr[i] - min代表了arr[i]，因为每一个数字减去一定的数字值都是不一样的
    //即映射关系为f(x)=x-min，第一个桶即为最小值所在的桶，桶（数组）长度为k，减小了内存的占用
    //某值出现一次，则对应索引的值增加1
    //每个元素值对应c[]的索引，因此所有元素值就被排序了
	var k = max - min + 1;
	//初始化每个元素值为0的额外数组
	var temp = Array.apply(null, Array(k)).map(function(item, key) {
	    return 0;
	});
	for(var i = 0; i < len; i++) {
		temp[arr[i] - min] += 1;
	}
	console.log("每个元素个数统计：" + temp);

	//计算每个元素值出现的次数与比它小的所有元素值出现的次数和
	for(var i = 1; i < k; i++) {
		temp[i] += temp[i - 1];
	}
	console.log("每个元素值及比它值小的所有元素的个数统计：" + temp);

	//排序
	var newarr = [];
	//倒序增加稳定性
	for(var i = len - 1; i >=0; i--) {
		//c[arr[i] - min]的索引arr[i] - min代表了arr[i]，值代表了arr[i]出现的次数与比它小的所有元素值出现的次数和（可以认为其他与a[i]的值相等的元素a[j]也是小于a[i]的元素，这样便于理解）
        //因此比当前arr[i]小的元素的个数为这个和减去1，这个结果就是元素arr[i]的索引
		newarr[--temp[arr[i] - min]] = arr[i];
	}
	console.log(newarr);

	return newarr;
}

var arr = [7, 26, 53, 22, 32, 28, 38, 23, 24, 54, 27, 78, 33];
console.log("计数排序1:");
CountingSort(arr);

/**
 * result
数组最小值：7
数组最大值：78
每个元素个数统计：1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,0,1,1,1,0,0,0,1,1,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1
每个元素值及比它值小的所有元素的个数统计：1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,3,4,4,5,6,7,7,7,7,8,9,9,9,9,9,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,11,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,12,13
[ 7, 22, 23, 24, 26, 27, 28, 32, 33, 38, 53, 54, 78 ]
 */


/**
 *计数排序2
 *桶排序思想-求和计数：使用一个额外的数组，映射关系为f(x)=x，即其中第i个元素是待排序数组中值等于i的元素的个数，知道了数组中比x小的元素的个数，就可以直接把x放到第（x+1）个位置上，即元素索引为x
 *
 * @para = arr 数组
 */
function CountingSort2(arr) {
	var len = arr.length;
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

	//根据最大值max初始化每个元素值为0的额外数组，数组最大索引值为max，则数组长度为max+1
	var temp = Array.apply(null, Array(max + 1)).map(function(item, key) {
	    return 0;
	});

	//统计数组每个数的个数
	for(var i = 0; i < len; i++) {
		var index = arr[i];
		temp[index] += 1;
	}
	console.log("每个元素个数统计：" + temp);

	//知道了数组中比x小的元素的个数，就可以直接把x放到（x+1）的位置上
	var newarr = new Array(len);
	newarr[0] = min;
	for(var i = min + 1, j = 1; i < max + 1; i++) {
		//每在新数组中添加一个索引，原数组中索引对应的值就减1
		if (temp[i] !== 0) {
			//方法一：计算比当前元素i小的元素的个数，即为元素i在有序数组中的下标
			//与外层循环后注释了的循环关联，此处只记录第i个元素在某个位置，即每个元素只在数组中放置一次，后面注释了的循环进行补充
			//newarr[eval(temp.slice(min, i).join("+"))] = i;

			//方法二：计算比当前元素i小的元素的个数，即为元素i在有序数组中的下标，然后根据元素i的个数依次向后填充元素i
			for(var j = 0; j < temp[i]; j++) {
				var index = eval(temp.slice(min, i).join("+"));
				newarr[index++] = i;
			}
		}
	}
	//上面循环中每个元素只放置一次，则如果某个元素有n个，当前元素后面就会有n-1个undefined，需要补充完整
	// for(var i = 1; i < len; i++) {
	// 	if(newarr[i] === undefined) {
	// 		newarr[i] = newarr[i - 1];
	// 	}
	// }
	console.log(newarr);

	return newarr;
}

var arr = [7, 26, 53, 22, 32, 28, 38, 23, 24, 54, 27, 78, 33];
console.log("计数排序2:");
CountingSort2(arr);

/**
 * result
数组最小值：7
数组最大值：78
每个元素个数统计：0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,0,1,1,1,0,0,0,1,1,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1
[ 7, 22, 23, 24, 26, 27, 28, 32, 33, 38, 53, 54, 78 ]
 */


/**
 *计数排序3
 *桶排序思想-依次输出：使用一个额外的数组，映射关系为f(x)=x，即其中第i个元素是待排序数组中值等于i的元素的个数，据索引i的值依次在新数组中展开索引i
 *
 * @para = arr 数组
 */
function CountingSort3(arr) {
	var len = arr.length;
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
console.log("计数排序3:");
CountingSort3(arr);

/**
 * result
数组最小值：7
数组最大值：78
每个元素个数统计：0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,0,1,1,1,0,0,0,1,1,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1
[ 7, 22, 23, 24, 26, 27, 28, 32, 33, 38, 53, 54, 78 ]
 */

