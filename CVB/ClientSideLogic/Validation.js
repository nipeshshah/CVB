function Test() {
    var t = ValidateNumber($('#NumberTextBox'), "Some Number").Required().IsNumber();
    console.log(t.error);
}

function Validator() {

}

function ValidateNumber(obj, title) {
    this.obj = obj;
    this.title = title;
    this.error = [];
    return this;
}

ValidateNumber.prototype.IsNumber = function () {
    isNaN(this.obj.val()) ? this.error.push(this.title + " should be a number.") : "";
    return this;
}

ValidateNumber.prototype.Required = function () {
    Number(this.obj.val()) > 0 ? "" : this.error.push(this.title + " is Required");
    return this;
}

function ValidateText(obj, title) {
    this.obj = obj;
    this.title = title;
    this.error = [];
    return this;
}

ValidateText.prototype.Required = function () {
    this.obj.val().length > 0 ? "" : this.error.push(this.title + " is Required");
    return this;
}

ValidateText.prototype.MinLength = function (minlength) {
    this.obj.val().length < minlength ? this.error.push(this.title + " should be of minumum " + minlength + " characters") : "";
    return this;
};

ValidateText.prototype.FixedLength = function (fixlength) {
    this.obj.val().length != fixlength ? this.error.push(this.title + " should be of exactly " + fixlength + " characters") : "";
    return this;
};
function ValidateDate(obj, title) {
    this.obj = obj;
    this.title = title;
    this.error = [];
    return this;
}

ValidateText.prototype.ValidDate = function () {
    this.obj.val().length > 0 ? "" : this.error.push(this.title + " should be valid date");
    return this;
}

ValidateText.prototype.PastDate = function () {
    this.obj.val().length > 0 ? "" : this.error.push(this.title + " should be past date");
    return this;
}