/**
 * Created by Epulari T on 2018/8/13.
 */

/**
 *顺序查找-不考虑重复
 *依次扫描每个元素并与关键字比较
 * @para = arr 数组
 */
function SequenceSearch(arr, key) {
	var len = arr.length;
	//索引一定不会为负
	for(var i = 0; i < len; i++) {
		if(arr[i] == key) {
			return i;
		}
	}
	return -1;
}

var arr = [7, 26, 53, 22, 32, 28, 38, 23, 24, 54, 27, 78, 33];
console.log(SequenceSearch(arr, 28));

/**
 * result
	5
 */
