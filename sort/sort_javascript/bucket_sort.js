/**
 * Created by Epulari T on 2018/8/10.
 */


/**
 *桶排序
 *对数字进行排序，不考虑负数，不考虑小数点
 *
 * @para = arr 数组
 */
//放入桶内和放回数组
function BucketInOut(arr, len, digit) {
	//定义十个桶，每个桶也是一个数组，构成二维数组
	var temp = new Array(10);
	for(var i = 0; i < 10; i++) {
		temp[i] = [];
	}

	//将arr中的元素值依次放入对应桶中
	for(var i = 0; i < len; i++) {
		//个位数：a/1%10；十位数：a/10%10；百位数：a/100%10……则中间的digit=10^n决定取哪一位
		var n = Math.floor(arr[i] / digit %  10);
		temp[n].push(arr[i]);
	}
	console.log("桶内：" + temp);

	//将桶内元素依次放回到数组中
	for(var i = 0, k = 0; i < 10; i++) {
		var blen = temp[i].length;
		if(blen !== 0) {
			for(var j = 0; j < blen; j++) {
				arr[k++] = temp[i][j];
			}
		}
	}
	console.log("桶外：" + arr);

	return arr;
}

//桶排序
function BucketSort(arr) {
	var len = len = arr.length;
	if(len < 2) {
		return arr;
	}

	//获取数组中最大的位数
	var digit = 0;
	for(var i = 0; i < len; i++) {
		var this_digit = Math.floor(arr[i]).toString().length;
		if (this_digit > digit) {
			digit = this_digit;
		}
	}

	//依次进行个位桶排序，十位桶排序，……
	for (var i = 0; i < digit; i++) {
		//个位数：a/1%10；十位数：a/10%10；百位数：a/100%10……则中间的cal_digit=10^n决定取哪一位
		var cal_digit = Math.pow(10, i);
		BucketInOut(arr, len, cal_digit);
	}

	return arr;
}

var arr = [7, 26, 53, 22, 32, 28, 38, 23, 24, 54, 27, 78, 33];
BucketSort(arr);

/**
 * result
桶内：,,22,32,53,23,33,24,54,,26,7,27,28,38,78,
桶外：22,32,53,23,33,24,54,26,7,27,28,38,78
桶内：7,,22,23,24,26,27,28,32,33,38,,53,54,,78,,
桶外：7,22,23,24,26,27,28,32,33,38,53,54,78
 */