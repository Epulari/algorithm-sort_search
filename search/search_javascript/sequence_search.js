/**
 * Created by Epulari T on 2018/8/13.
 */


/**
 * 顺序查找-不考虑重复
 * 依次扫描每个元素并与关键字比较
 *
 * @para = arr 数组
 * @para = key 关键字
 */
function SequenceSearch(arr, key) {
	var len = arr.length;
	//索引一定不会为负
	var k = 0;
	for(var i = 0; i < len; i++) {
		if(arr[i] == key) {
			console.log("比较第" + ++k + "次");
			return i;
		}
		++k;
	}
	console.log("比较第" + k + "次");
	return -1;
}

var arr = [7, 22, 23, 24, 26, 27, 28, 32, 33, 38, 53, 54, 78];
console.log("查找成功： " + SequenceSearch(arr, 53));
console.log("查找失败： " + SequenceSearch(arr, 52));
/**
 * result
	比较第11次
	查找成功： 10
	比较第13次
	查找失败： -1
 */
