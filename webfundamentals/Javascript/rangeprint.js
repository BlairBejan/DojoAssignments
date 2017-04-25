function printrange(x, y, z){
    for(var i = x; i < y; i += z){
        if(z === undefined){
            z = 1;
        }
        if(z < 0 && y > 0){
            console.log("My work will never end!!!");
            break;
        }
        console.log(i);
    }
}
printrange(2, 10, 2);