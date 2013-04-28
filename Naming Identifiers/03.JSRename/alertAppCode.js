//Refactor the following examples to produce code with well-named identifiers in JavaScript


function allertAppCode(event, argumens) {
    var userWindow = window;
    var browser = userWindow.navigator.appCodeName;
    var isMozzila = browser === "Mozilla";
    if (isMozzila) {
        alert("Yes");
    }
    else {
        alert("No");
    }
}
 