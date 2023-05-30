const validateText = (event) => {
    if (event.terget.value.length >= 2)
        document.querySelector(`[data-valmsg-for= "${event.target.id}"]`).innerHTML = ""
    else
        document.querySelector(`[data-valmsg-for= "${event.target.id}"]`).innerHTML = "Invalid length"
}

const validateEmail = (event) => {
    const regEx = /^[^\s@]+@[^\s@]+.[^\s@]+$/
    if (regEx.test(event.target.value))
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = ""
    else
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = "invalid email"
}

const validatePassword = (event) => {
    const regEx = /^(?=.[a-z])(?=.[A-Z])(?=.\d)(?=.[!@#$%^&*]]).{8,}$/

    if (regEx.test(event.target.value))
        document.querySelector(`[data-valmsg-for="${event.target.id}"]`).innerHTML = ""
    else
        document.querySelector(`[data - valmsg -for= "${event.target.id}"]`).innerHTML = "invalid password"
}