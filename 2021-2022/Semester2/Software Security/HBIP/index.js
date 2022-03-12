const hibp = require('hibp');
const suffix = '1E4C9B93F3F0682250B6CF8331B7EE68FD8';
hibp.pwnedPasswordRange('5BAA6')
// filter to matching suffix
.then(results => console.log((results[suffix] || 0)))
.catch(err => {
// ...
});