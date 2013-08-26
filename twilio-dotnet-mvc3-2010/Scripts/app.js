$(function () {
    // Send a text message
    $('#text').on('click', function () {
        var yourNumber = $('#number').val();

        $.ajax('/sms', {
            method: 'POST',
            dataType: 'json',
            data: {
                to: yourNumber
            },
            success: function (data) {
                alert('Just sent a text to ' + yourNumber);
            },
            error: function (xhr, status, error) {
                alert(error);
            }
        });
    });

    // Make a phone call
    $('#call').on('click', function () {
        var yourNumber = $('#number').val();

        $.ajax('/call', {
            method: 'POST',
            dataType: 'json',
            data: {
                to: yourNumber
            },
            success: function (data) {
                alert('Just made a call to ' + yourNumber);
            },
            error: function (xhr, status, error) {
                alert(error);
            }
        });
    });

    // Fetch a capability token and set up the Twilio Device
    function setup(callback) {
        $.ajax('/capability', {
            method: 'POST',
            dataType: 'json',
            success: function (data) {
                Twilio.Device.setup(data.token);
                callback();
            },
            error: function (xhr, status, error) {
                alert(error);
            }
        });
    }

    // Make an outbound VoIP call
    function call() {
        Twilio.Device.connect({
            number: $('#number').val()
        });
    }

    // Respond to the voip button click
    var initialized = false;
    $('#voip').on('click', function () {
        // If this is a first call, fetch a capability token, then make the call
        if (!initialized) {
            initialized = true;
            setup(call);
            return;
        }
        // Otherwise, just make the call
        call();
    });
});