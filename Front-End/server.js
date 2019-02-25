'use strict';
var express = require('express');
var path = require('path');
var port = process.env.PORT || 1337;

var app = express();

var staticPath = path.join(__dirname, '/dist');
app.use(express.static(staticPath));
app.set('port', port);

var server = app.listen(app.get('port'), function () {
    console.log('Server running on port:' + app.get('port'));
});

