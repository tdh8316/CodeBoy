input.onGesture(Gesture.Shake, function () {
    serial.writeLine("RUN")
})
input.onButtonPressed(Button.A, function () {
    serial.writeLine("LEFT")
})
input.onButtonPressed(Button.B, function () {
    serial.writeLine("RIGHT")
})
input.onButtonPressed(Button.AB, function () {
    serial.writeLine("SEL")
})
