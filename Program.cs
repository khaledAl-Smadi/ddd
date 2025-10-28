//collection
// 1 - Array
// 2 - List

// int[]array_1={1,1}

List<int> list_1 = new List<int>()
{
    1,
    2, 
    4,
    8
};
List<int> list_2 = new List<int>()
{
  5,
    6,
    8,
    9
};


list_1.Add(10);
list_1.Remove(1);
bool x=list_1.Contains(10);// اذا موجود  او لا 
list_1.AddRange(list_2); //list1|| list2
list_1.RemoveAt(0);// remove with count
list_1.RemoveRange(0, 3); //remove with count من الى index0 +1+2 

list_1.RemoveAll(x => x > 5);//remove with condeition

var sum=list_1.Sum();
var average=list_1.Average();
var max=list_1.Max();
var min = list_1.Min();
var count = list_1.Count(x => x == 5);

Console.WriteLine(count);

