const express = require('express');
const bodyParser = require('body-parser');
const { Vonage } = require('@vonage/server-sdk'); 

const app = express();
app.use(bodyParser.json());

const vonage = new Vonage({
    apiKey: 'f8bc0d3e', 
    apiSecret: 'KDRJrriCmosuMY5s' 
});

// Endpoint to send SMS
app.post('/send-sms', (req, res) => {
    const { to, message } = req.body;

    console.log(`Sending SMS to: ${to}, Message: ${message}`); // Log request data

    vonage.sms.send({ to, from: 'VonageAPI', text: message }, (err, responseData) => {
        if (err) {
            console.error('Error:', err.message); // Log the error details
            res.status(500).json({ error: err.message });
        } else if (responseData.messages[0].status === '0') {
            console.log('Message sent successfully:', responseData); // Log success
            res.status(200).json({ success: 'Message sent successfully' });
        } else {
            console.error('Vonage Error:', responseData.messages[0]['error-text']); // Log error from Vonage
            res.status(400).json({ error: responseData.messages[0]['error-text'] });
        }
    });
});

// Start the server
app.listen(3001, () => {
    console.log('Server is running on port 3001');
});
