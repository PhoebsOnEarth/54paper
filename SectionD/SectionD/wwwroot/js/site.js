let counter = 21;
window.onload = function () {
    
    let counterElem = document.getElementById("cw_count_down");
    if (counterElem) {
        /*
        var x = setInterval(function () {
            counter--;
            counterElem.innerHTML = counter;
            if (counter <= 0) {
                setTimeout(function() {
                    clearInterval(x);
                    window.location.href = "/Message/Read";
                },1000);  
            }
        },1000);
        */
        counterElem.innerHTML = counter;
           
        
    }
}

var source = new EventSource('/Message/CountDown');
source.onopen = function (e) {
    console.log('On Open: ', e);
};
source.onerror = function (e) {
    console.log('On Error', e);
};
source.onmessage = function (e) {
    if (counter == 0) {
        window.location.href = "/Message/Read";
    }
    counter--;
    let counterElem = document.getElementById("cw_count_down");
    if (counterElem) {
        counterElem.innerHTML = counter;
    }
};

    
    

    
