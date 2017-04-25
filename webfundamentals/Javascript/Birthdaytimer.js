function birthdaytimer(){
    var daysuntilmybirthday = 60;
    while (daysuntilmybirthday >= 0) {
        if (daysuntilmybirthday > 30) {
            console.log(daysuntilmybirthday, "days until my birthday.", "Still more than 30 days until my birthday :(");
        }
        else if (daysuntilmybirthday <= 30 && daysuntilmybirthday > 5) {
            console.log(daysuntilmybirthday, "days until my birthday.", "ooooh, my birthday is coming up!");
        }
        else if (daysuntilmybirthday <= 5) {
            console.log(daysuntilmybirthday, "days until my birthday.", "OH MY GOD! MY BIRTHDAY IS IN LESS THAN A WEEK!!!");
        }
        else if (daysuntilmybirthday === 0) {
            console.log(daysuntilmybirthday, "days until my birthday.", "IT'S MY BIRTHDAY TIME TO PARTY!!!");
        }
        daysuntilmybirthday--;
    }
}