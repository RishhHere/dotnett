namespace Clonee;

public class Stack:ICloneable{
    private int size;
    private int[] arr = {4,23,5,35,13,75};

    public Stack(int size){
        this.size = size;
        this.arr = new int [size];
    }


public object Clone(){
    Stack replica = new Stack(5);
    this.arr.CopyTo(replica.arr,0);
    return replica;
}
}