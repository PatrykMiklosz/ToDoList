function goBack() {
    if (window.history.length > 1) {
        window.history.go(-1); 
    } else {
        window.location.href = "/Home"; 
    }
};

window.onload = function () {
    var deleteButtons = document.querySelectorAll('.open-modal');
    deleteButtons.forEach(function (button) {
        button.addEventListener('click', function () {
            var id = this.getAttribute('data-id');
            var confirmDeleteButton = document.getElementById('confirm-delete');
            confirmDeleteButton.href = '/ToDoItem/Delete/' + id;
        });
    });
};

toastr.options = {
    "timeOut": "5000" 
}

