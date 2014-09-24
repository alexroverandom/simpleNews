function clearBox(elementId) {
    var box = document.getElementById(elementId);
    box.innerHTML = '';

}

function validate(id) {
    var container = document.getElementById(id);
    container.innerHTML = '';
    var errorMessage = 'must be not empty';
    var title = document.getElementById('Title');
    var body = document.getElementById('Body');
    if (title.value === '')
        errorMessage = "Title " + errorMessage;
    if (body.value === '')
        errorMessage = 'Body ' + errorMessage;
    if (errorMessage === 'must be not empty')
        clearBox('add-new');
    else
        container.innerHTML = errorMessage;
}