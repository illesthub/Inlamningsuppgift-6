"use strict";

var validateText = function validateText(event) {
    if (event.terget.value.length >= 2) document.querySelector("[data-valmsg-for= \"" + event.target.id + "\"]").innerHTML = "";else document.querySelector("[data-valmsg-for= \"" + event.target.id + "\"]").innerHTML = "Invalid length";
};

var validateEmail = function validateEmail(event) {
    var regEx = /^[^\s@]+@[^\s@]+.[^\s@]+$/;
    if (regEx.test(event.target.value)) document.querySelector("[data-valmsg-for=\"" + event.target.id + "\"]").innerHTML = "";else document.querySelector("[data-valmsg-for=\"" + event.target.id + "\"]").innerHTML = "invalid email";
};

var validatePassword = function validatePassword(event) {
    var regEx = /^(?=.[a-z])(?=.[A-Z])(?=.\d)(?=.[!@#$%^&*]]).{8,}$/;

    if (regEx.test(event.target.value)) document.querySelector("[data-valmsg-for=\"" + event.target.id + "\"]").innerHTML = "";else document.querySelector("[data - valmsg -for= \"" + event.target.id + "\"]").innerHTML = "invalid password";
};

