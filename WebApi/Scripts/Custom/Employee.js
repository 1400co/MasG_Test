let employee = {
    baseUrl: "http://localhost:53385/api/employees",
    getAll: function (callback) {
        $.ajax({
            url: this.baseUrl,
            method: "GET"
        }).done(function (data) {
            callback(data);
        });
    },
    getById: function (callback, id) {
        $.ajax({
            url: this.baseUrl + "/" + id,
            method: "GET"
        }).done(function (data) {
            callback(data);
        });
    }
}