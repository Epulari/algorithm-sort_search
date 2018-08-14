/**
 * Created by Epulari T on 2018/8/13.
 */


/**
 *顺序查找-不考虑重复
 *依次扫描每个元素并与关键字比较
 * @para = arr 数组
 * @para = key 关键字
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

var arr = [7, 22, 23, 24, 26, 27, 28, 32, 33, 38, 53, 54, 78];
console.log(SequenceSearch(arr, 53));

/**
 * result
	10
 */
