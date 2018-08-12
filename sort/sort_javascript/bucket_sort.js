/**
 * Created by Epulari T on 2018/8/11.
 */


/**
 *桶排序
 *映射关系f(x)=Math.pow(x, 1 / 2)
 *
 * @para = arr 数组
 */
function BucketSort(arr) {
	var len = arr.length;
	if(len < 2) {
		return arr;
	}

	//设置映射关系为根号x：f(x) = Math.pow(x, 1 / 2)，并求出其中的最大最小值
	var reciprocal = [];
	var min = arr[0], max = arr[0], temp;
	for (var i = 0; i < len; i++) {
		temp = Math.pow(arr[i], 1 / 2);
		reciprocal.push(temp);
		if (min > temp) {
			min = temp;
		}
		else if (max < temp) {
			max = temp;
		}
		else {}
	}
	console.log("平方根：" + reciprocal);
	console.log("数组最小值：" + min);
	console.log("数组最大值：" + max);

	//设置桶的数量为max向上取整，也可以设置桶的数量为max-min+1，则arr[max-i]可以代表arr[i]
	var tlen = Math.ceil(max), temp = new Array(tlen);
	for(var i = 0; i < tlen; i++) {
		temp[i] = [];
	}
	//根据映射关系找到桶下标，将对应的原数组值放入桶中
	for(var i = 0; i < len; i++) {
		temp[Math.floor(reciprocal[i])].push(arr[i]);
	}
	console.log("桶内元素：");
	console.log(temp);

	//对桶内元素进行快排，并依次将桶内元素添加到新数组中（根据根号关系可以知道序号小的桶内元素一定小于序号大的桶内元素）
	var newarr = [];
	for(var i = 0; i < tlen; i++) {
		if(temp[i].length !== 0) {
			temp[i] = QuickSort(temp[i]);
			console.log("第" + i + "个桶内快排：" + temp[i]);

			for(var j = 0; j < temp[i].length; j++) {
				newarr.push(temp[i][j]);
			}
		}
	}
	console.log("排序结果：" + newarr);
}

var arr = [7, 26, 53, 22, 32, 28, 38, 23, 24, 54, 27, 78, 33];
BucketSort(arr);

/**
 * result
平方根：2.6457513110645907,5.0990195135927845,7.280109889280518,4.69041575982343,5.656854249492381,5.291502622129181,6.164414002968977,4.795831523312719,4.898979485566356,7.3484692283495345,5.196152422706632,8.831760866327848,5.744562646538029
数组最小值：2.6457513110645907
数组最大值：8.831760866327848
桶内元素：
[ [],
  [],
  [ 7 ],
  [],
  [ 22, 23, 24 ],
  [ 26, 32, 28, 27, 33 ],
  [ 38 ],
  [ 53, 54 ],
  [ 78 ] ]
第2个桶内快排：7
第4个桶内快排：22,23,24
第5个桶内快排：26,27,28,32,33
第6个桶内快排：38
第7个桶内快排：53,54
第8个桶内快排：78
排序结果：7,22,23,24,26,27,28,32,33,38,53,54,78
 */

function QuickSort(arr) {
	var len = arr.length;
	//判断数组长度，如果当前传入的数组只有一个元素就结束递归
	if (len < 2) {
		return arr;
	}
	//定义基准元素的左侧数组和右侧数组
	var left = [];
	var right = [];
	//选择基准元素，这里选择数组的首元素
	var key = arr[0];
	//依次判断每个元素与基准元素值的大小，小则放到左侧，大则放到右侧，等则随便放，这里放在右侧
	for (var i = 1; i < len; i++) {
		if(arr[i] < key) {
			left.push(arr[i]);
		}
		else {
			right.push(arr[i]);
		}
	}
	return  QuickSort(left).concat(key).concat(QuickSort(right)) //递归
}