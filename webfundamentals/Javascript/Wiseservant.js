function wiseservant(){
    var stash = 0;
    var mpd = 0.01;
    for(var days = 1; days < 31; days++){
        stash += mpd;
        mpd *= 2;
    }
    console.log(stash);
}
wiseservant();

function wiseservantmakes10000(){
    var stash = 0;
    var mpd = 0.01;
    for(var days = 1; days < 31; days++){
        stash += mpd;
        if(stash >= 10000){
            console.log(days);
            break;
        }
        mpd *= 2;
    }
    console.log(stash);
}
wiseservantmakes10000();


function wiseservantmakes1000000000(){
    var stash = 0;
    var mpd = 0.01;
    for(var days = 1; days < Infinity; days++){
        stash += mpd;
        if(stash >= 1000000000){
            console.log("It takes", days, "to make $1b");
            break;
        }
        mpd *= 2;
    }
    console.log(stash);
}
wiseservantmakes1000000000();

function wiseservantmakesInfiniteMoney(){
    var stash = 0;
    var mpd = 0.01;
    for(var days = 1; days < Infinity; days++){
        stash += mpd;
        if(stash >= Infinity){
            console.log("It takes", days, "to make Infinite money");
            break;
        }
        mpd *= 2;
    }
    console.log(stash);
}
wiseservantmakesInfiniteMoney();