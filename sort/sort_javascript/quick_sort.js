/**
 * Created by Epulari T on 2018/8/2.
 */


/**
 * 快速排序
 * 在待排序数据中选出一个元素（通常为第一个元素、最后一个元素或中间元素）作为基准
 * 将其他元素与基准元素进行比较进而分成两部分，一部分比基准大，一部分比基准小
 * 然后对这两部分分别按相同方法继续排列，直到每个部分只有1个数
 *
 * 在每轮排序里定义左数组和右数组，并分别对其进行排序，然后连接两个数据和关键值
 *
 * @para = arr 数组
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
	//输出每一次排列的结果
	console.log(left.concat(key, right));
	//return  QuickSort(left).concat(key).concat(QuickSort(right)); //递归
	//arguments的callee属性是一个指针，指向拥有这个arguments对象的函数
	return arguments.callee(left).concat(key).concat(arguments.callee(right));
}

var arr = [7, 26, 53, 22, 32, 28, 38, 23, 24, 54, 27, 78, 33];
console.log(QuickSort(arr));

/**
 * result
	第一次排列，输入原数组，选择基准7，则左数组1为空，右数组1为没有7的原数组，输出左数组1+7+右数组1，即原数组：
	[ 7, 26, 53, 22, 32, 28, 38, 23, 24, 54, 27, 78, 33 ]
	第一次执行递归，第二次排列，左数组进行排列，输入左数组1，数组为空，返回到递归语句
	第一次执行递归，第二次排列，右数组进行排列，输入右数组1，数组为没有7的原数组，选择基准26，左数组2和右数组2分别有值，输出左数组2+26+右数组2：
	[ 22, 23, 24, 26, 53, 32, 28, 38, 54, 27, 78, 33 ]
	第二次执行递归，第三次排列，左数组2进行排列，输入左数组2，选择基准22，则左数组3为空，右数组3为没有22的左数组2，输出左数组3+22+右数组3，即左数组2：
	[ 22, 23, 24 ]
	按照上面的方式依次进行排列，每次得到结果后只要结果中有左数组就向深处排列左数组，直到不存在左数组了再排列右数组
	[ 23, 24 ]
	[ 32, 28, 38, 27, 33, 53, 54, 78 ]
	[ 28, 27, 32, 38, 33 ]
	[ 27, 28 ]
	[ 33, 38 ]
	[ 54, 78 ]
	[ 7, 22, 23, 24, 26, 27, 28, 32, 33, 38, 53, 54, 78 ]
 */