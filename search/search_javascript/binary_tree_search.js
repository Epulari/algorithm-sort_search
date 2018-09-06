/**
 * Created by Epulari T on 2018/8/14.
 */


/**
 * 二叉树查找-迭代法
 * 数组已构成二叉查找树
 * 构建二叉查找树，左子树小于根节点，右子树大于根节点，依次比较
 *
 * @para = arr 数组
 * @para = key 关键字
 */
function BinaryTreeSearch(arr, key) {
	var len = arr.length;

	//i为二叉树父节点索引，k为比较次数
	var i = 0, k = 0;
	while(i < len) {
		console.log("第" + ++k + "次比较：i-" + i + " arr[i]-" + arr[i]);
		if(arr[i] == key) {
			return i;
		}
		else if(arr[i] > key) {
			//左子节点
			i = 2 * i + 1;
		}
		else {
			//右子节点
			i = 2 * i + 2;
		}
	}
	return -1;
}

var arr = [32, 24, 54, 22, 27, 38, 78, 7, 23, 26, 28, 33, 53];
console.log("二叉树查找1：");
console.log("查找成功： " + BinaryTreeSearch(arr, 53));
console.log("查找失败： " + BinaryTreeSearch(arr, 52));

/**
 * result
	第1次比较：i-0 arr[i]-32
	第2次比较：i-2 arr[i]-54
	第3次比较：i-5 arr[i]-38
	第4次比较：i-12 arr[i]-53
	查找成功： 12
	第1次比较：i-0 arr[i]-32
	第2次比较：i-2 arr[i]-54
	第3次比较：i-5 arr[i]-38
	第4次比较：i-12 arr[i]-53
	查找失败： -1
 */


/**
 * 二叉树查找-递归法
 * 数组已构成二叉查找树
 * 构建二叉查找树，左子树小于根节点，右子树大于根节点，依次比较
 *
 * @para = arr 数组
 * @para = key 关键字
 * @para = i 二叉树父节点索引
 * @para = k 比较次数
 */
function BinaryTreeSearch2(arr, key, i, k) {
	var len = arr.length;

	while(i < len) {
		console.log("第" + ++k + "次比较：i-" + i + " arr[i]-" + arr[i]);
		if(arr[i] == key) {
			return i;
		}
		else if(arr[i] > key) {
			//左子节点
			//return BinaryTreeSearch(arr, key, 2 * i + 1, k);
			//arguments的callee属性是一个指针，指向拥有这个arguments对象的函数
			return arguments.callee(arr, key, 2 * i + 1, k);
		}
		else {
			//右子节点
			//return BinaryTreeSearch(arr, key, 2 * i + 2, k);
			//arguments的callee属性是一个指针，指向拥有这个arguments对象的函数
			return arguments.callee(arr, key, 2 * i + 1, k);
		}
	}
	return -1;
}

var arr = [32, 24, 54, 22, 27, 38, 78, 7, 23, 26, 28, 33, 53];
console.log("二叉树查找2：");
console.log("查找成功： " + BinaryTreeSearch2(arr, 53, 0, 0));
console.log("查找失败： " + BinaryTreeSearch2(arr, 52, 0, 0));

/**
 * result
	第1次比较：i-0 arr[i]-32
	第2次比较：i-2 arr[i]-54
	第3次比较：i-5 arr[i]-38
	第4次比较：i-12 arr[i]-53
	查找成功： 12
	第1次比较：i-0 arr[i]-32
	第2次比较：i-2 arr[i]-54
	第3次比较：i-5 arr[i]-38
	第4次比较：i-12 arr[i]-53
	查找失败： -1
 */